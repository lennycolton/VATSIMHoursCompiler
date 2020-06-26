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
            //Create field
            Record rcdCurrent = null;

            //Set bounds
            int intMidpoint;
            int intMin = 0;
            int intMax = _list.Count - 1;

            if (intMax < 0)
            {
                return null;
            }

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
}
