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

        public string strName { get; private set; }
        public Position posParent { get; set; }
        public List<Position> listChildren { get; }
        public List<Condition> listConditions { get; }

        public Position(string _name, Position _parent)
        {
            strName = _name;
            posParent = _parent;
            _parent.listChildren.Add(this);

            listChildren = new List<Position>();
            listConditions = new List<Condition>();
        }
    }

    class Condition { }

    class PreCondition : Condition
    {
        public string strPre;

        public PreCondition(string _pre)
        {
            strPre = _pre;
        }
    }

    class SufCondition : Condition
    {
        public string strSuf;

        public SufCondition(string _suf)
        {
            strSuf = _suf;
        }
    }

    class PreSufCondition : Condition
    {
        public string strPre;
        public string strSuf;

        public PreSufCondition(string _pre, string _suf)
        {
            strPre = _pre;
            strSuf = _suf;
        }
    }

    class CsCondition : Condition
    {
        public string strCs;

        public CsCondition(string _cs)
        {
            strCs = _cs;
        }
    }
}
