using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace VATSIMHoursCompiler
{
    [Serializable()]
    public class Member
    {
        [XmlIgnore()]
        public static readonly string[] ratings = { "", "OBS", "S1", "S2", "S3", "C1", "C2", "C3", "I1", "I2", "I3", "SUP", "ADM" };

        [XmlIgnore()]
        public static List<Member> list = new List<Member>();

        [XmlElement("CID")]
        public int intCID { get; set; }

        [XmlElement("Name")]
        public string strName { get; set; }

        [XmlElement("Rating")]
        public int intRating { get; set; }

        [XmlIgnore()]
        public List<Record> listRecords { get; set; } = new List<Record>();

        [XmlIgnore()]
        public List<Result> listResCs { get; set; } = new List<Result>();

        [XmlIgnore()]
        public List<Result> listResPre { get; set; } = new List<Result>();

        [XmlIgnore()]
        public List<Result> listResSuf { get; set; } = new List<Result>();

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

        public Member () { }

        public static Member Add(int _cid)
        {
            foreach (Member mem in list)
            {
                if (mem.intCID == _cid)
                {
                    return null;
                }
            }

            Member memNew = new Member(_cid);
            list.Add(memNew);
            return memNew;
        }
    }
}
