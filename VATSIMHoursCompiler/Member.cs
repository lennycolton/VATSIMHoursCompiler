using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIMHoursCompiler
{
    class Member
    {
        public int intCID { get; private set; }
        public string strName { get; private set; }
        public int intRating { get; private set; }

        public Member(int _cid)
        {
            intCID = _cid;
            strName = "";
            intRating = 0;
        }

        public Member(int _cid, string _name, int _rating)
        {
            intCID = _cid;
            strName = _name;
            intRating = _rating;
        }
    }
}
