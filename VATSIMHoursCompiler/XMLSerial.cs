using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VATSIMHoursCompiler
{
    [Serializable()]
    public class XMLSerial
    {
        [XmlArray("Members")]
        [XmlArrayItem("Member")]
        public List<Member> listMembers { get; set; }

        [XmlArray("Positions")]
        [XmlArrayItem("Position")]
        public List<Position> listPositions { get; set; }

        [XmlElement("Start")]
        public DateTime? dtStart { get; set; }

        [XmlElement("End")]
        public DateTime? dtEnd { get; set; }

        public XMLSerial(List<Member> _mem, List<Position> _pos, DateTime? _start, DateTime? _end)
        {
            listMembers = _mem;
            listPositions = _pos;
            dtStart = _start;
            dtEnd = _end;
        }

        public XMLSerial() { }

        public static void Save(string _path, DateTime? _start, DateTime? _end)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLSerial));

            XMLSerial xms = new XMLSerial(Member.list, Position.listRoot, _start, _end);

            foreach (Position pos in Position.list)
            {
                pos.listPre = new List<PreCondition>();
                pos.listSuf = new List<SufCondition>();
                pos.listPreSuf = new List<PreSufCondition>();
                pos.listCs = new List<CsCondition>();

                foreach (Condition con in pos.listConditions)
                {
                    if (con is PreCondition)
                    {
                        pos.listPre.Add((PreCondition)con);
                    }
                    else if (con is SufCondition)
                    {
                        pos.listSuf.Add((SufCondition)con);
                    }
                    else if (con is PreSufCondition)
                    {
                        pos.listPreSuf.Add((PreSufCondition)con);
                    }
                    else if (con is CsCondition)
                    {
                        pos.listCs.Add((CsCondition)con);
                    }
                }
            }

            if (File.Exists(_path))
            {
                File.Delete(_path);
            }

            FileStream fs = File.Create(_path);
            serializer.Serialize(fs, xms);
            fs.Close();
        }

        public static DateTime?[] Load(string _path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLSerial));

            try
            {
                FileStream fs = File.OpenRead(_path);
                XMLSerial xms = (XMLSerial)serializer.Deserialize(fs);
                fs.Close();

                Member.list = xms.listMembers;
                Position.listRoot = xms.listPositions;

                Position.list = new List<Position>(Position.listRoot);

                foreach (Position pos in Position.listRoot)
                {
                    Position.list.AddRange(pos.FindDescendents());
                }

                Position.list = Position.Sort(Position.list);
                Position.setCount();

                foreach (Position pos in Position.list)
                {
                    pos.listChildren = Position.Sort(pos.listChildren);

                    foreach (Position child in pos.listChildren)
                    {
                        child.posParent = pos;
                    }

                    pos.listConditions.AddRange(pos.listPre);
                    pos.listConditions.AddRange(pos.listSuf);
                    pos.listConditions.AddRange(pos.listPreSuf);
                    pos.listConditions.AddRange(pos.listCs);

                    pos.listConditions = Condition.Sort(pos.listConditions);
                }

                return new DateTime?[] { xms.dtStart, xms.dtEnd };
            }
            catch
            {
                MessageBox.Show("Unable to read data from file. The file may be corrupt, incorrectly formatted, or inaccessible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
