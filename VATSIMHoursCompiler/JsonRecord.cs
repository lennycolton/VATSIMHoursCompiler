using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VATSIMHoursCompiler
{
    public class JsonRecord
    {
        [JsonPropertyName("next")]
        public string next { get; set; }

        [JsonPropertyName("results")]
        public JsonResult[] results { get; set; }

        public static void PullAll(DateTime start, DateTime end)
        {
            List<Task> listTasks = new List<Task>();

            foreach (Member mem in Member.list)
            {
                listTasks.Add(Task.Run(() => CollateData(mem, start, end)));
            }

            Task.WaitAll(listTasks.ToArray());
        }

        private static async Task CollateData(Member mem, DateTime start, DateTime end)
        {
            List<JsonRecord> listSessions = PullSessions(mem.intCID);
            List<JsonResult> listResults = new List<JsonResult>();

            foreach (JsonRecord record in listSessions)
            {
                listResults.AddRange(record.results);
            }

            List<IGrouping<string, JsonResult>> enumJsonCs = null;

            if (start == default(DateTime) && end == default(DateTime))
            {
                enumJsonCs = listResults.Where(x => x.start >= start).Where(y => y.end <= end || y.end == null).GroupBy(z => z.cs).ToList();
            }
            else if (start == default(DateTime))
            {
                enumJsonCs = listResults.Where(y => y.end <= end || y.end == null).GroupBy(z => z.cs).ToList();
            }
            else if (end == default(DateTime))
            {
                enumJsonCs = listResults.Where(x => x.start >= start).GroupBy(z => z.cs).ToList();
            }
            else
            {
                enumJsonCs = listResults.GroupBy(z => z.cs).ToList();
            }

            List<Result> listRes = Result.Create(enumJsonCs);

            mem.listResCs = Result.Sort(listRes, 0);
            mem.listResPre = Result.Sort(listRes, 1);
            mem.listResSuf = Result.Sort(listRes, 2);

            foreach (Position pos in Position.list)
            {
                List<Result> listFind = new List<Result>();

                foreach (Condition con in pos.listConditions)
                {
                    if (con is PreCondition)
                    {
                        listFind.AddRange(Result.FindPre(mem.listResPre, ((PreCondition)con).strPre));
                    }
                    else if (con is SufCondition)
                    {
                        listFind.AddRange(Result.FindSuf(mem.listResSuf, ((SufCondition)con).strSuf));
                    }
                    else if (con is PreSufCondition)
                    {
                        List<Result> listTempFind = Result.FindPre(mem.listResPre, ((PreSufCondition)con).strPre);

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
                        Result jsrTemp = Result.FindCs(mem.listResCs, ((CsCondition)con).strCs);

                        if (jsrTemp != null)
                        {
                            listFind.Add(jsrTemp);
                        }
                    }
                }

                decimal decMins = 0;

                foreach (Result jsr in listFind)
                {
                    decMins += jsr.time;
                }

                Record rcdNew = new Record(mem, pos, decMins);
                mem.listRecords.Add(rcdNew);
            }

            //mem.listRecords = Record.Sort(mem.listRecords);
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

    public class JsonResult
    {
        [JsonPropertyName("callsign")]
        public string cs { get; set; }

        [JsonPropertyName("minutes_on_callsign")]
        public string time { get; set; }

        [JsonPropertyName("start")]
        public DateTime? start { get; set; }

        [JsonPropertyName("end")]
        public DateTime? end { get; set; }

        [JsonIgnore()]
        public string pre { get; set; }

        [JsonIgnore()]
        public string suf { get; set; }
    }

    public class JsonMember
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
            WebClient wct = new WebClient();
            string strJson = wct.DownloadString("https://api.vatsim.net/api/ratings/" + _cid + "/?format=json");
            return JsonSerializer.Deserialize<JsonMember>(strJson);
        }
    }
}
