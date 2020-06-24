using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATSIMHoursCompiler
{
    class Member
    {
        public static readonly string[] ratings = { "", "OBS", "S1", "S2", "S3", "C1", "C2", "C3", "I1", "I2", "I3", "SUP", "ADM" };

        public static List<Member> list = new List<Member>();

        public int intCID { get; private set; }
        public string strName { get; set; }
        public int intRating { get; set; }

        public List<Record> listRecords { get; }
        public List<JsonResult> listJsonCs { get; set; }
        public List<JsonResult> listJsonPre { get; set; }
        public List<JsonResult> listJsonSuf { get; set; }

        public Member(int _cid)
        {
            intCID = _cid;
            strName = "";
            intRating = 0;
            listRecords = new List<Record>();
            listJsonCs = new List<JsonResult>();
            listJsonPre = new List<JsonResult>();
            listJsonSuf = new List<JsonResult>();
        }

        public Member(int _cid, string _name, int _rating)
        {
            intCID = _cid;
            strName = _name;
            intRating = _rating;
            listRecords = new List<Record>();
            listJsonCs = new List<JsonResult>();
            listJsonPre = new List<JsonResult>();
            listJsonSuf = new List<JsonResult>();
        }
    }
}
