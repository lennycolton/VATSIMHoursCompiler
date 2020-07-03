using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIMHoursCompiler
{
    public class Record
    {
        public Member memMember { get; }
        public Position posPosition { get; }
        public decimal decMins { get; set; }

        public Record(Member _mem, Position _pos, decimal _mins)
        {
            memMember = _mem;
            posPosition = _pos;
            decMins = _mins;
        }

        public decimal MinsWithChildren()
        {
            decimal decReturn = decMins;

            foreach (Position child in posPosition.listChildren)
            {
                Record rcd = Find(memMember.listRecords, child.intID);

                decReturn += rcd.MinsWithChildren();
            }

            return decReturn;
        }

        public static Record Find(List<Record> _list, int _pos)
        {
            if (_list.Count == 0)
            {
                return null;
            }

            //Create field
            Record rcdCurrent = null;

            //Set bounds
            int intMidpoint;
            int intMin = 0;
            int intMax = _list.Count - 1;

            do
            {
                //Set midpoint
                intMidpoint = (intMin + intMax) / 2;

                //Find midpoint items
                rcdCurrent = _list[intMidpoint];

                //Return if search term found
                if (rcdCurrent.posPosition.intID == _pos)
                {
                    return rcdCurrent;
                }
                //Set new minimum if current is too low
                else if (rcdCurrent.posPosition.intID < _pos)
                {
                    intMin = intMidpoint + 1;
                }
                //Set new maximum if current is too high
                else if (rcdCurrent.posPosition.intID > _pos)
                {
                    intMax = intMidpoint - 1;
                }
            } while (intMin <= intMax);

            //Return null if nothing found
            return null;
        }

        public static List<Record> Sort(List<Record> _list)
        {
            if (_list.Count <= 1)
            {
                return _list;
            }

            int midpoint = _list.Count / 2;

            List<Record> left = new List<Record>();
            List<Record> right = new List<Record>();

            for (int i = 0; i < midpoint; i++)
            {
                left.Add(_list[i]);

            }
            for (int j = midpoint; j < _list.Count; j++)
            {
                right.Add(_list[j]);
            }

            left = Sort(left);
            right = Sort(right);
            return Combine(left, right);
        }

        private static List<Record> Combine(List<Record> _left, List<Record> _right)
        {
            List<Record> sorted = new List<Record>();

            while (_left.Count > 0 || _right.Count > 0)
            {
                if (_left.Count > 0 && _right.Count > 0)
                {
                    if (_left[0].posPosition.intID <= _right[0].posPosition.intID)
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

    public class Result
    {
        public string cs;
        public string pre;
        public string suf;
        public decimal time;

        public Result(string _cs)
        {
            cs = _cs;

            string[] split = _cs.Split('_');
            pre = split[0];
            suf = split.Last();

            time = 0;
        }

        public static List<Result> Create(List<IGrouping<string, JsonResult>> _list)
        {
            List<Result> listResults = new List<Result>();

            foreach (IGrouping<string, JsonResult> grp in _list)
            {
                listResults.Add(CreateSingle(grp));
            }

            return listResults;
        }

        private static Result CreateSingle(IGrouping<string, JsonResult> _grp)
        {
            List<JsonResult> listGrp = _grp.ToList();

            Result res = new Result(_grp.Key);

            foreach (JsonResult jrs in listGrp)
            {
                res.time += jrs.time;
            }

            return res;
        }

        public static Result FindCs(List<Result> _list, string _cs)
        {
            if (_list.Count == 0)
            {
                return null;
            }

            //Create field
            Result jsrCurrent = null;

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
        public static List<Result> FindPre(List<Result> _list, string _pre)
        {
            if (_list.Count == 0)
            {
                return new List<Result>();
            }

            //Create fields
            Result jsrCurrent = null;
            List<Result> listResults;
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
                    listResults = new List<Result>();
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
            return new List<Result>();
        }

        //Binary Search, based on ID of related Leg Route
        public static List<Result> FindSuf(List<Result> _list, string _suf)
        {
            if (_list.Count == 0)
            {
                return new List<Result>();
            }

            //Create fields
            Result jsrCurrent = null;
            List<Result> listResults;
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
                    listResults = new List<Result>();
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
            return new List<Result>();
        }

        public static List<Result> Sort(List<Result> _list, int _by)
        {
            if (_list.Count <= 1)
            {
                return _list;
            }

            int midpoint = _list.Count / 2;

            List<Result> left = new List<Result>();
            List<Result> right = new List<Result>();

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

        private static List<Result> CombineCs(List<Result> _left, List<Result> _right)
        {
            List<Result> sorted = new List<Result>();

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

        private static List<Result> CombinePre(List<Result> _left, List<Result> _right)
        {
            List<Result> sorted = new List<Result>();

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

        private static List<Result> CombineSuf(List<Result> _left, List<Result> _right)
        {
            List<Result> sorted = new List<Result>();

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
}
