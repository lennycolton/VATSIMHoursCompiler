using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VATSIMHoursCompiler
{
    [Serializable()]
    public class Position
    {
        [XmlIgnore()]
        private static int Count { get; set; } = 0;

        [XmlIgnore()]
        public static List<Position> list = new List<Position>();

        [XmlIgnore()]
        public static List<Position> listRoot = new List<Position>();

        [XmlElement("ID")]
        public int intID { get; set; }

        [XmlElement("Name")]
        public string strName { get; set; }

        [XmlIgnore()]
        public Position posParent { get; set; }

        [XmlArray("Children")]
        [XmlArrayItem("Position")]
        public List<Position> listChildren { get; set; } = new List<Position>();

        [XmlIgnore()]
        public List<Condition> listConditions { get; set; } = new List<Condition>();

        [XmlArray("Pres")]
        [XmlArrayItem("Pre")]
        public List<PreCondition> listPre { get; set; }

        [XmlArray("Sufs")]
        [XmlArrayItem("Suf")]
        public List<SufCondition> listSuf { get; set; }

        [XmlArray("Presufs")]
        [XmlArrayItem("Presufs")]
        public List<PreSufCondition> listPreSuf { get; set; }

        [XmlArray("Css")]
        [XmlArrayItem("Cs")]
        public List<CsCondition> listCs { get; set; }

        [XmlElement("Shown")]
        public bool isShown { get; set; } = false;

        public Position(int _id, string _name, Position _parent)
        {
            intID = _id;
            strName = _name;
            posParent = _parent;

            if (_parent != null)
            {
                _parent.listChildren.Add(this);
            }
        }

        public Position() { }

        public static Position Add(string _name, Position _parent)
        {
            Position pos = new Position(Count, _name, _parent);
            list.Add(pos);
            listRoot.Add(pos);
            Count++;
            return pos;
        }

        private static void IncrementCounter()
        {
            Count++;
        }

        public List<Position> FindDescendents()
        {
            List<Position> listSearch = new List<Position>(listChildren);
            List<Position> listReturn = new List<Position>(listChildren);

            foreach (Position pos in listSearch)
            {
                listReturn.AddRange(pos.FindDescendents());
            }

            return listReturn;
        }

        public static Position Find(int _id)
        {
            if (list.Count == 0)
            {
                return null;
            }

            //Create field
            Position posCurrent = null;

            //Set bounds
            int intMidpoint;
            int intMin = 0;
            int intMax = list.Count - 1;

            if (intMax < 0)
            {
                return null;
            }

            do
            {
                //Set midpoint
                intMidpoint = (intMin + intMax) / 2;

                //Find midpoint items
                posCurrent = list[intMidpoint];

                //Return if search term found
                if (posCurrent.intID == _id)
                {
                    return posCurrent;
                }
                //Set new minimum if current is too low
                else if (posCurrent.intID < _id)
                {
                    intMin = intMidpoint + 1;
                }
                //Set new maximum if current is too high
                else if (posCurrent.intID > _id)
                {
                    intMax = intMidpoint - 1;
                }
            } while (intMin <= intMax);

            //Return null if nothing found
            return null;
        }

        public static List<Position> Sort(List<Position> _list)
        {
            if (_list.Count <= 1)
            {
                return _list;
            }

            int midpoint = _list.Count / 2;

            List<Position> left = new List<Position>();
            List<Position> right = new List<Position>();

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

        private static List<Position> Combine(List<Position> _left, List<Position> _right)
        {
            List<Position> sorted = new List<Position>();

            while (_left.Count > 0 || _right.Count > 0)
            {
                if (_left.Count > 0 && _right.Count > 0)
                {
                    if (_left[0].intID <= _right[0].intID)
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

    public class Condition
    {
        [XmlIgnore()]
        private static int Count { get; set; } = 0;

        [XmlElement("ID")]
        public int intID { get; set; }

        [XmlElement("Name")]
        public string strName { get; set; }

        public Condition(int _id, string _name)
        {
            intID = _id;
            strName = _name;
        }

        public Condition() { }

        public static Condition Create(string _name)
        {
            Condition con = new Condition(Count, _name);
            Count++;
            return con;
        }

        private static void IncrementCounter()
        {
            Count++;
        }

        public static Condition Find(Position pos, int _id)
        {
            if (pos.listConditions.Count == 0)
            {
                return null;
            }

            //Create field
            Condition conCurrent = null;

            //Set bounds
            int intMidpoint;
            int intMin = 0;
            int intMax = pos.listConditions.Count - 1;

            do
            {
                //Set midpoint
                intMidpoint = (intMin + intMax) / 2;

                //Find midpoint items
                conCurrent = pos.listConditions[intMidpoint];

                //Return if search term found
                if (conCurrent.intID == _id)
                {
                    return conCurrent;
                }
                //Set new minimum if current is too low
                else if (conCurrent.intID < _id)
                {
                    intMin = intMidpoint + 1;
                }
                //Set new maximum if current is too high
                else if (conCurrent.intID > _id)
                {
                    intMax = intMidpoint - 1;
                }
            } while (intMin <= intMax);

            //Return null if nothing found
            return null;
        }

        public static List<Condition> Sort(List<Condition> _list)
        {
            if (_list.Count <= 1)
            {
                return _list;
            }

            int midpoint = _list.Count / 2;

            List<Condition> left = new List<Condition>();
            List<Condition> right = new List<Condition>();

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

        private static List<Condition> Combine(List<Condition> _left, List<Condition> _right)
        {
            List<Condition> sorted = new List<Condition>();

            while (_left.Count > 0 || _right.Count > 0)
            {
                if (_left.Count > 0 && _right.Count > 0)
                {
                    if (_left[0].intID <= _right[0].intID)
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

    public class PreCondition : Condition
    {
        [XmlElement("Pre")]
        public string strPre { get; set; }

        public PreCondition(int _id, string _name, string _pre) : base(_id, _name)
        {
            strPre = _pre;
        }

        public PreCondition() { }
    }

    public class SufCondition : Condition
    {
        [XmlElement("Suf")]
        public string strSuf { get; set; }

        public SufCondition(int _id, string _name, string _suf) : base(_id, _name)
        {
            strSuf = _suf;
        }

        public SufCondition() { }
    }

    public class PreSufCondition : Condition
    {
        [XmlElement("Pre")]
        public string strPre { get; set; }

        [XmlElement("Suf")]
        public string strSuf { get; set; }

        public PreSufCondition(int _id, string _name, string _pre, string _suf) : base(_id, _name)
        {
            strPre = _pre;
            strSuf = _suf;
        }

        public PreSufCondition() { }
    }

    public class CsCondition : Condition
    {
        [XmlElement("Cs")]
        public string strCs { get; set; }

        public CsCondition(int _id, string _name, string _cs) : base(_id, _name)
        {
            strCs = _cs;
        }

        public CsCondition() { }
    }
}
