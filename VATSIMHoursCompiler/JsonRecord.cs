using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VATSIMHoursCompiler
{
    class JsonRecord
    {
        [JsonPropertyName("next")]
        public string next { get; set; }

        [JsonPropertyName("results")]
        public JsonResult[] results { get; set; }

        public static void PullAll()
        {
            foreach (Member mem in Member.list)
            {
                List<JsonRecord> listSessions = PullSessions(mem.intCID);
                List<JsonResult> listResults = new List<JsonResult>();
                
                foreach (JsonRecord record in listSessions)
                {
                    listResults.AddRange(record.results);
                }

                mem.listJsonCs = JsonResult.Sort(listResults.GroupBy(x => x.cs).Select(y => y.First()).ToList(), 0);

                foreach (JsonResult jrs in mem.listJsonCs)
                {
                    string[] split = jrs.cs.Split('_');
                    jrs.pre = split[0];
                    jrs.suf = split.Last();
                }

                mem.listJsonPre = JsonResult.Sort(listResults.GroupBy(x => x.cs).Select(y => y.First()).ToList(), 1);
                mem.listJsonSuf = JsonResult.Sort(listResults.GroupBy(x => x.cs).Select(y => y.First()).ToList(), 2);

                foreach (Position pos in Position.list)
                {
                    List<JsonResult> listFind = new List<JsonResult>();

                    foreach (Condition con in pos.listConditions)
                    {
                        if (con is PreCondition)
                        {
                            listFind.AddRange(JsonResult.FindPre(mem.listJsonCs, ((PreCondition)con).strPre));
                        }
                        else if (con is SufCondition)
                        {
                            listFind.AddRange(JsonResult.FindSuf(mem.listJsonCs, ((SufCondition)con).strSuf));
                        }
                        else if (con is PreSufCondition)
                        {
                            List<JsonResult> listTempFind = JsonResult.FindPre(mem.listJsonCs, ((PreSufCondition)con).strPre);

                            for (int i = listTempFind.Count - 1; i >= 0; i--)
                            {
                                if (listTempFind[i].suf != ((PreSufCondition)con).strSuf)
                                {
                                    listTempFind.RemoveAt(i);
                                }
                            }

                            listFind.AddRange(listTempFind);
                        }
                        else if (con is CsCondition)
                        {
                            JsonResult jsrTemp = JsonResult.FindCs(mem.listJsonCs, ((CsCondition)con).strName);

                            if (jsrTemp != null)
                            {
                                listFind.Add(jsrTemp);
                            }
                        }
                    }

                    decimal decMins = 0;

                    foreach (JsonResult jsr in listFind)
                    {
                        decMins += jsr.time;
                    }

                    Record rcdNew = new Record(mem, pos, decMins);
                    mem.listRecords.Add(rcdNew);
                }
            }
        }

        private static List<JsonRecord> PullSessions(int _cid)
        {
            List<JsonRecord> listReturn = new List<JsonRecord>();

            WebClient wct = new WebClient();
            listReturn.Add(JsonSerializer.Deserialize<JsonRecord>(wct.DownloadString("https://api.vatsim.net/api/ratings/" + _cid + "/atcsessions/?format=json")));

            while (listReturn.Last().next != null)
            {
                listReturn.Add(JsonSerializer.Deserialize<JsonRecord>(wct.DownloadString(listReturn.Last().next)));
            }

            return listReturn;
        }

        
    }

    class JsonResult
    {
        [JsonPropertyName("callsign")]
        public string cs { get; set; }

        [JsonPropertyName("total_minutes_on_callsign")]
        public decimal time { get; set; }

        [JsonIgnore()]
        public string pre { get; set; }

        [JsonIgnore()]
        public string suf { get; set; }

        public static JsonResult FindCs(List<JsonResult> _list, string _cs)
        {
            //Create field
            JsonResult jsrCurrent = null;

            //Set bounds
            int intMidpoint;
            int intMin = 0;
            int intMax = _list.Count - 1;

            do
            {
                //Set midpoint
                intMidpoint = (intMin + intMax) / 2;

                //Find midpoint items
                jsrCurrent = _list[intMidpoint];

                //Return if search term found
                if (string.Compare(jsrCurrent.cs, _cs) == 0)
                {
                    return jsrCurrent;
                }
                //Set new minimum if current is too low
                else if (string.Compare(jsrCurrent.cs, _cs) < 0)
                {
                    intMin = intMidpoint + 1;
                }
                //Set new maximum if current is too high
                else if (string.Compare(jsrCurrent.cs, _cs) > 0)
                {
                    intMax = intMidpoint - 1;
                }
            } while (intMin <= intMax);

            //Return null if nothing found
            return null;
        }

        //Binary Search, based on ID of related Leg Route
        public static List<JsonResult> FindPre(List<JsonResult> _list, string _pre)
        {
            //Create fields
            JsonResult jsrCurrent = null;
            List<JsonResult> listResults;
            int intCurrent;

            //Set bounds
            int intMidpoint;
            int intMin = 0;
            int intMax = _list.Count - 1;

            do
            {
                //Set midpoint
                intMidpoint = (intMin + intMax) / 2;

                //Find midpoint items
                jsrCurrent = _list[intMidpoint];

                //Find all matching if search term found
                if (string.Compare(jsrCurrent.pre, _pre) == 0)
                {
                    //Add current element to results list
                    listResults = new List<JsonResult>();
                    listResults.Add(jsrCurrent);

                    //Add all matching with lower indices
                    intCurrent = intMidpoint - 1;
                    jsrCurrent = _list[intCurrent];

                    while (string.Compare(jsrCurrent.pre, _pre) == 0 && intCurrent > 0)
                    {
                        //Add value to results list and increment down
                        listResults.Add(jsrCurrent);
                        intCurrent--;
                        jsrCurrent = _list[intCurrent];
                    }

                    //Add all matching with higher indices
                    intCurrent = intMidpoint + 1;
                    jsrCurrent = _list[intCurrent];

                    while (string.Compare(jsrCurrent.pre, _pre) == 0 && intCurrent < _list.Count - 1)
                    {
                        //Add value to results list and increment up
                        listResults.Add(jsrCurrent);
                        intCurrent++;
                        jsrCurrent = _list[intCurrent];
                    }

                    //Return results
                    return listResults;
                }
                //Set new minimum if current is too low
                else if (string.Compare(jsrCurrent.pre, _pre) < 0)
                {
                    intMin = intMidpoint + 1;
                }
                //Set new maximum if current is too high
                else if (string.Compare(jsrCurrent.pre, _pre) > 0)
                {
                    intMax = intMidpoint - 1;
                }
            } while (intMin <= intMax);

            //Return empty if nothing found
            return new List<JsonResult>();
        }

        //Binary Search, based on ID of related Leg Route
        public static List<JsonResult> FindSuf(List<JsonResult> _list, string _suf)
        {
            //Create fields
            JsonResult jsrCurrent = null;
            List<JsonResult> listResults;
            int intCurrent;

            //Set bounds
            int intMidpoint;
            int intMin = 0;
            int intMax = _list.Count - 1;

            do
            {
                //Set midpoint
                intMidpoint = (intMin + intMax) / 2;

                //Find midpoint items
                jsrCurrent = _list[intMidpoint];

                //Find all matching if search term found
                if (string.Compare(jsrCurrent.suf, _suf) == 0)
                {
                    //Add current element to results list
                    listResults = new List<JsonResult>();
                    listResults.Add(jsrCurrent);

                    //Add all matching with lower indices
                    intCurrent = intMidpoint - 1;
                    jsrCurrent = _list[intCurrent];

                    while (string.Compare(jsrCurrent.suf, _suf) == 0 && intCurrent > 0)
                    {
                        //Add value to results list and increment down
                        listResults.Add(jsrCurrent);
                        intCurrent--;
                        jsrCurrent = _list[intCurrent];
                    }

                    //Add all matching with higher indices
                    intCurrent = intMidpoint + 1;
                    jsrCurrent = _list[intCurrent];

                    while (string.Compare(jsrCurrent.suf, _suf) == 0 && intCurrent < _list.Count - 1)
                    {
                        //Add value to results list and increment up
                        listResults.Add(jsrCurrent);
                        intCurrent++;
                        jsrCurrent = _list[intCurrent];
                    }

                    //Return results
                    return listResults;
                }
                //Set new minimum if current is too low
                else if (string.Compare(jsrCurrent.suf, _suf) < 0)
                {
                    intMin = intMidpoint + 1;
                }
                //Set new maximum if current is too high
                else if (string.Compare(jsrCurrent.suf, _suf) > 0)
                {
                    intMax = intMidpoint - 1;
                }
            } while (intMin <= intMax);

            //Return empty if nothing found
            return new List<JsonResult>();
        }

        public static List<JsonResult> Sort(List<JsonResult> _list, int _by)
        {
            if (_list.Count <= 1)
            {
                return _list;
            }

            int midpoint = _list.Count / 2;

            List<JsonResult> left = new List<JsonResult>();
            List<JsonResult> right = new List<JsonResult>();

            for (int i = 0; i < midpoint; i++)
            {
                left.Add(_list[i]);

            }
            for (int j = midpoint; j < _list.Count; j++)
            {
                right.Add(_list[j]);
            }

            left = Sort(left, _by);
            right = Sort(right, _by);

            switch (_by)
            {
                case 0:
                    return CombineCs(left, right);
                case 1:
                    return CombinePre(left, right);
                case 2:
                    return CombineSuf(left, right);
                default:
                    return CombineCs(left, right);
            }

        }

        private static List<JsonResult> CombineCs(List<JsonResult> _left, List<JsonResult> _right)
        {
            List<JsonResult> sorted = new List<JsonResult>();

            while (_left.Count > 0 || _right.Count > 0)
            {
                if (_left.Count > 0 && _right.Count > 0)
                {
                    if (string.Compare(_left[0].cs, _right[0].cs) <= 0)
                    {
                        sorted.Add(_left[0]);
                        _left.Remove(_left[0]);
                    }
                    else
                    {
                        sorted.Add(_right[0]);
                        _right.Remove(_right[0]);
                    }
                }
                else if (_left.Count > 0)
                {
                    sorted.Add(_left[0]);
                    _left.Remove(_left[0]);
                }
                else if (_right.Count > 0)
                {
                    sorted.Add(_right[0]);
                    _right.Remove(_right[0]);
                }
            }

            return sorted;
        }

        private static List<JsonResult> CombinePre(List<JsonResult> _left, List<JsonResult> _right)
        {
            List<JsonResult> sorted = new List<JsonResult>();

            while (_left.Count > 0 || _right.Count > 0)
            {
                if (_left.Count > 0 && _right.Count > 0)
                {
                    if (string.Compare(_left[0].pre, _right[0].pre) <= 0)
                    {
                        sorted.Add(_left[0]);
                        _left.Remove(_left[0]);
                    }
                    else
                    {
                        sorted.Add(_right[0]);
                        _right.Remove(_right[0]);
                    }
                }
                else if (_left.Count > 0)
                {
                    sorted.Add(_left[0]);
                    _left.Remove(_left[0]);
                }
                else if (_right.Count > 0)
                {
                    sorted.Add(_right[0]);
                    _right.Remove(_right[0]);
                }
            }

            return sorted;
        }

        private static List<JsonResult> CombineSuf(List<JsonResult> _left, List<JsonResult> _right)
        {
            List<JsonResult> sorted = new List<JsonResult>();

            while (_left.Count > 0 || _right.Count > 0)
            {
                if (_left.Count > 0 && _right.Count > 0)
                {
                    if (string.Compare(_left[0].suf, _right[0].suf) <= 0)
                    {
                        sorted.Add(_left[0]);
                        _left.Remove(_left[0]);
                    }
                    else
                    {
                        sorted.Add(_right[0]);
                        _right.Remove(_right[0]);
                    }
                }
                else if (_left.Count > 0)
                {
                    sorted.Add(_left[0]);
                    _left.Remove(_left[0]);
                }
                else if (_right.Count > 0)
                {
                    sorted.Add(_right[0]);
                    _right.Remove(_right[0]);
                }
            }

            return sorted;
        }
    }

    class JsonMember
    {
        [JsonPropertyName("name_first")]
        public string first { get; set; }

        [JsonPropertyName("name_last")]
        public string last { get; set; }

        [JsonPropertyName("rating")]
        public int rating { get; set; }

        public static void PullAll()
        {
            foreach (Member mem in Member.list)
            {
                JsonMember jsTemp = Create(mem.intCID);

                if (jsTemp != null)
                {
                    mem.strName = jsTemp.first + " " + jsTemp.last;
                    mem.intRating = jsTemp.rating;
                }
            }
        }

        private static JsonMember Create(int _cid)
        {
            try
            {
                WebClient wct = new WebClient();
                string strJson = wct.DownloadString("https://api.vatsim.net/api/ratings/" + _cid + "/?format=json");
                return JsonSerializer.Deserialize<JsonMember>(strJson);
            }
            catch
            {
                return null;
            }
        }
    }
}
