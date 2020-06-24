using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIMHoursCompiler
{
    class Position
    {
        public static List<Position> list = new List<Position>();

        public string strName { get; set; }
        public Position posParent { get; set; }
        public List<Position> listChildren { get; set; }
        public List<Condition> listConditions { get; set; }
        public bool isShown { get; set; } = false;

        public Position(string _name, Position _parent)
        {
            strName = _name;
            posParent = _parent;

            if (_parent != null)
            {
                _parent.listChildren.Add(this);
            }

            listChildren = new List<Position>();
            listConditions = new List<Condition>();
        }
    }

    class Condition
    {
        public string strName;

        public Condition(string _name)
        {
            strName = _name;
        }
    }

    class PreCondition : Condition
    {
        public string strPre;

        public PreCondition(string _name, string _pre) : base(_name)
        {
            strPre = _pre;
        }
    }

    class SufCondition : Condition
    {
        public string strSuf;

        public SufCondition(string _name, string _suf) : base(_name)
        {
            strSuf = _suf;
        }
    }

    class PreSufCondition : Condition
    {
        public string strPre;
        public string strSuf;

        public PreSufCondition(string _name, string _pre, string _suf) : base(_name)
        {
            strPre = _pre;
            strSuf = _suf;
        }
    }

    class CsCondition : Condition
    {
        public string strCs;

        public CsCondition(string _name, string _cs) : base(_name)
        {
            strCs = _cs;
        }
    }
}
