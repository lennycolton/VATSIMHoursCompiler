using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VATSIMHoursCompiler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SetColumnWidth();
            clbColumns.Tag = null;

            bgwMembers.DoWork += BgwMembers_DoWork;
            bgwMembers.RunWorkerCompleted += BgwMembers_RunWorkerCompleted;

            clbColumns.ItemCheck += ClbColumns_ItemCheck;
        }

        private void SetColumnWidth()
        {
            ResizeListViewColumns(lvMembers);
            ResizeListViewColumns(lvPositions);
            ResizeListViewColumns(lvConditions);
            ResizeListViewColumns(lvResults);
        }

        private Dictionary<string, int[]> listViewHeaderWidths = new Dictionary<string, int[]>();
        private void ResizeListViewColumns(ListView lv)
        {
            int[] headerWidths = listViewHeaderWidths.ContainsKey(lv.Name) ? listViewHeaderWidths[lv.Name] : null;

            lv.BeginUpdate();

            if (headerWidths == null)
            {
                lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                headerWidths = new int[lv.Columns.Count];

                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    headerWidths[i] = lv.Columns[i].Width;
                }

                listViewHeaderWidths.Add(lv.Name, headerWidths);
            }

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            for (int j = 0; j < lv.Columns.Count; j++)
            {
                lv.Columns[j].Width = Math.Max(lv.Columns[j].Width, headerWidths[j]);
            }

            lv.EndUpdate();
        }

        private void BtnMemAdd_Click(object sender, EventArgs e)
        {
            int cid = -1;

            if (int.TryParse(TxtMemCID.Text, out cid))
            {
                Member memTemp = new Member(cid);
                Member.list.Add(memTemp);

                ListViewItem lviTemp = new ListViewItem(new string[] { cid.ToString(), memTemp.strName, Member.ratings[memTemp.intRating] });
                lviTemp.Tag = memTemp;

                if (cid == 1332038)
                {
                    lviTemp.Font = new Font(new Font("Comic Sans MS", lviTemp.Font.Size), FontStyle.Bold);
                }

                lvMembers.Items.Add(lviTemp);

                lvMembers.SelectedItems.Clear();
                lvMembers.SelectedIndices.Add(lvMembers.Items.Count - 1);

                ResizeListViewColumns(lvMembers);
            }

            TxtMemCID.Clear();
        }

        private void BtnMemRemove_Click(object sender, EventArgs e)
        {
            if (lvMembers.SelectedItems.Count > 0)
            {
                Member.list.Remove((Member)lvMembers.SelectedItems[0].Tag);
                lvMembers.Items.Remove(lvMembers.SelectedItems[0]);

                ResizeListViewColumns(lvMembers);
            }
        }

        private void BtnPosAdd_Click(object sender, EventArgs e)
        {
            Position posTemp = new Position(TxtPosName.Text, null);
            Position.list.Add(posTemp);

            string parent = "";

            if (posTemp.posParent != null)
            {
                parent = posTemp.posParent.strName;
            }

            ListViewItem lviTemp = new ListViewItem(new string[] { posTemp.strName, parent, posTemp.listConditions.Count.ToString() });
            lviTemp.Tag = posTemp;
            lvPositions.Items.Add(lviTemp);

            lvPositions.SelectedItems.Clear();
            lvPositions.SelectedIndices.Add(lvPositions.Items.Count - 1);

            TxtPosName.Clear();
            ResizeListViewColumns(lvPositions);

            if (clbColumns.Tag == posTemp.posParent)
            {
                clbColumns.Items.Add(new ComboBoxItem(posTemp.strName, posTemp));
            }
        }

        private void BtnPosRemove_Click(object sender, EventArgs e)
        {
            if (lvPositions.SelectedItems.Count > 0)
            {
                Position posTemp = (Position)lvPositions.SelectedItems[0].Tag;

                if (clbColumns.Tag == posTemp.posParent)
                {
                    for (int i = clbColumns.Items.Count - 1; i >= 0; i--)
                    {
                        if (((ComboBoxItem)clbColumns.Items[i]).Value == posTemp)
                        {
                            clbColumns.Items.RemoveAt(i);
                        }
                    }
                }

                Position.list.Remove(posTemp);
                lvPositions.Items.Remove(lvPositions.SelectedItems[0]);

                ResizeListViewColumns(lvPositions);
            }
        }

        private void lvPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPositions.SelectedItems.Count > 0)
            {
                tlpConditions.Hide();

                Position posTemp = (Position)lvPositions.SelectedItems[0].Tag;

                cbDetParent.Items.Clear();
                cbDetParent.Items.Add(new ComboBoxItem("(none)", null));

                foreach (ListViewItem lvi in lvPositions.Items)
                {
                    if (lvi != lvPositions.SelectedItems[0] && !posTemp.listChildren.Contains((Position)lvi.Tag))
                    {
                        Position pos = (Position)lvi.Tag;

                        cbDetParent.Items.Add(new ComboBoxItem(pos.strName, pos));
                    }
                }

                TxtDetName.Text = posTemp.strName;

                foreach (ComboBoxItem cbi in cbDetParent.Items)
                {
                    if ((Position)cbi.Value == posTemp.posParent)
                    {
                        cbDetParent.SelectedItem = cbi;
                    }
                }

                lvConditions.Items.Clear();

                foreach (Condition con in posTemp.listConditions)
                {
                    string[] strData = null;

                    if (con is PreCondition)
                    {
                        PreCondition pcon = (PreCondition)con;

                        strData = new string[] { pcon.strName, "Prefix", pcon.strPre };
                    }
                    else if (con is SufCondition)
                    {
                        SufCondition scon = (SufCondition)con;

                        strData = new string[] { scon.strName, "Suffix", scon.strSuf };
                    }
                    else if (con is PreSufCondition)
                    {
                        PreSufCondition pscon = (PreSufCondition)con;

                        strData = new string[] { pscon.strName, "Prefix/Suffix", pscon.strPre + "/" + pscon.strSuf };
                    }
                    else if (con is CsCondition)
                    {
                        CsCondition cscon = (CsCondition)con;

                        strData = new string[] { cscon.strName, "Callsign", cscon.strCs };
                    }

                    ListViewItem lviTemp = new ListViewItem(strData);
                }

                tlpDetails.Show();
            }
            else
            {
                tlpDetails.Hide();
            }
        }

        private void lvConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConditions.SelectedItems.Count > 0)
            {
                Condition con = (Condition)lvConditions.SelectedItems[0].Tag;

                TxtConName.Text = con.strName;

                if (con is PreCondition)
                {
                    PreCondition pcon = (PreCondition)con;

                    cbConType.SelectedIndex = 0;

                    LblCon1.Text = "Prefix:";
                    TxtCon1.Text = pcon.strPre;

                    LblCon2.Hide();
                    TxtCon2.Hide();
                }
                else if (con is SufCondition)
                {
                    SufCondition scon = (SufCondition)con;

                    cbConType.SelectedIndex = 1;

                    LblCon1.Text = "Suffix:";
                    TxtCon1.Text = scon.strSuf;

                    LblCon2.Hide();
                    TxtCon2.Hide();
                }
                else if (con is PreSufCondition)
                {
                    PreSufCondition pscon = (PreSufCondition)con;

                    cbConType.SelectedIndex = 2;

                    LblCon1.Text = "Prefix:";
                    TxtCon1.Text = pscon.strPre;

                    LblCon2.Text = "Suffix:";
                    TxtCon2.Text = pscon.strSuf;

                    LblCon2.Show();
                    TxtCon2.Show();
                }
                else if (con is CsCondition)
                {
                    CsCondition cscon = (CsCondition)con;

                    cbConType.SelectedIndex = 3;

                    LblCon1.Text = "Callsign:";
                    TxtCon1.Text = cscon.strCs;

                    LblCon2.Hide();
                    TxtCon2.Hide();
                }
                else
                {
                    cbConType.SelectedIndex = -1;

                    LblCon1.Hide();
                    TxtCon1.Hide();

                    LblCon2.Hide();
                    TxtCon2.Hide();

                    BtnConSave.Hide();
                }

                tlpConditions.Show();
            }
            else
            {
                tlpConditions.Hide();
            }
        }

        private void BtnConAdd_Click(object sender, EventArgs e)
        {
            Condition con = new Condition("");
            ((Position)lvPositions.SelectedItems[0].Tag).listConditions.Add(con);

            ListViewItem lviTemp = new ListViewItem(new string[] { "", "None", "" });
            lviTemp.Tag = con;
            lvConditions.Items.Add(lviTemp);

            lvConditions.SelectedItems.Clear();
            lvConditions.SelectedIndices.Add(lvConditions.Items.Count - 1);

            lvPositions.SelectedItems[0].SubItems[2].Text = ((Position)lvPositions.SelectedItems[0].Tag).listChildren.Count.ToString();

            ResizeListViewColumns(lvConditions);
        }

        private void BtnConRemove_Click(object sender, EventArgs e)
        {
            if (lvConditions.SelectedItems.Count > 0)
            {
                ((Position)lvPositions.SelectedItems[0].Tag).listConditions.Remove((Condition)lvConditions.SelectedItems[0].Tag);
                lvConditions.Items.Remove(lvConditions.SelectedItems[0]);

                ResizeListViewColumns(lvConditions);
            }
        }

        private void cbConType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbConType.SelectedItem)
            {
                case "Prefix Only":
                    cbConType.SelectedIndex = 0;

                    LblCon1.Text = "Prefix:";
                    TxtCon1.Text = "";

                    LblCon1.Show();
                    TxtCon1.Show();
                    LblCon2.Hide();
                    TxtCon2.Hide();

                    BtnConSave.Show();

                    break;

                case "Suffix Only":
                    cbConType.SelectedIndex = 1;

                    LblCon1.Text = "Suffix:";
                    TxtCon1.Text = "";

                    LblCon1.Show();
                    TxtCon1.Show();
                    LblCon2.Hide();
                    TxtCon2.Hide();

                    BtnConSave.Show();

                    break;

                case "Prefix and Suffix":
                    cbConType.SelectedIndex = 2;

                    LblCon1.Text = "Prefix:";
                    TxtCon1.Text = "";

                    LblCon2.Text = "Suffix:";
                    TxtCon2.Text = "";

                    LblCon1.Show();
                    TxtCon1.Show();
                    LblCon2.Show();
                    TxtCon2.Show();

                    BtnConSave.Show();

                    break;

                case "Specific Callsign":
                    cbConType.SelectedIndex = 3;

                    LblCon1.Text = "Callsign:";
                    TxtCon1.Text = "";

                    LblCon1.Show();
                    TxtCon1.Show();
                    LblCon2.Hide();
                    TxtCon2.Hide();

                    BtnConSave.Show();

                    break;

                default:
                    BtnConSave.Hide();
                    break;
            }
        }

        private void BtnConSave_Click(object sender, EventArgs e)
        {
            Condition con = (Condition)lvConditions.SelectedItems[0].Tag;

            string strName = TxtConName.Text;
            string strType = "";
            string strValue = "";

            switch (cbConType.SelectedItem)
            {
                case "Prefix Only":
                    strType = "Prefix";
                    strValue = TxtCon1.Text;

                    con = new PreCondition(strName, strValue);
                    break;

                case "Suffix Only":
                    strType = "Suffix";
                    strValue = TxtCon1.Text;

                    con = new SufCondition(strName, strValue);
                    break;

                case "Prefix and Suffix":
                    strType = "Prefix/Suffix";

                    string str1 = TxtCon1.Text;
                    string str2 = TxtCon2.Text;
                    strValue = TxtCon1.Text + "/" + TxtCon2.Text;

                    con = new PreSufCondition(strName, str1, str2);
                    break;

                case "Specific Callsign":
                    strType = "Callsign";
                    strValue = TxtCon1.Text;

                    con = new CsCondition(strName, strValue);
                    break;

                default:
                    break;
            }

            lvConditions.SelectedItems[0].SubItems[0].Text = strName;
            lvConditions.SelectedItems[0].SubItems[1].Text = strType;
            lvConditions.SelectedItems[0].SubItems[2].Text = strValue;

            ResizeListViewColumns(lvConditions);
        }

        private void BtnDetSave_Click(object sender, EventArgs e)
        {
            Position pos = (Position)lvPositions.SelectedItems[0].Tag;
            Position oldparent = pos.posParent;

            pos.strName = TxtDetName.Text;

            Position parent = (Position)((ComboBoxItem)cbDetParent.SelectedItem).Value;

            if (oldparent != null)
            {
                oldparent.listChildren.Remove(pos);
            }

            pos.posParent = parent;

            string strParent = "";

            if (parent != null)
            {
                parent.listChildren.Add(pos);
                strParent = parent.strName;
            }

            lvPositions.SelectedItems[0].SubItems[0].Text = pos.strName;
            lvPositions.SelectedItems[0].SubItems[1].Text = strParent;

            ResizeListViewColumns(lvPositions);

            if (clbColumns.Tag == oldparent)
            {
                for (int i = clbColumns.Items.Count - 1; i >= 0; i--)
                {
                    if (((ComboBoxItem)clbColumns.Items[i]).Value == pos)
                    {
                        if (parent == oldparent)
                        {
                            ((ComboBoxItem)clbColumns.Items[i]).Text = pos.strName;
                        }
                        else
                        {
                            clbColumns.Items.RemoveAt(i);
                        }
                    }
                }
            }
            else if (clbColumns.Tag == parent)
            {
                clbColumns.Items.Add(new ComboBoxItem(pos.strName, pos));
            }
        }

        private void BtnParent_Click(object sender, EventArgs e)
        {
            clbColumns.Tag = ((Position)clbColumns.Tag).posParent;

            clbColumns.Items.Clear();

            foreach (Position pos in Position.list)
            {
                if (pos.posParent == (Position)clbColumns.Tag)
                {
                    clbColumns.Items.Add(new ComboBoxItem(pos.strName, pos));
                }
            }
        }

        private void BtnChildren_Click(object sender, EventArgs e)
        {
            if (clbColumns.SelectedIndex != -1)
            {
                clbColumns.Tag = ((ComboBoxItem)clbColumns.SelectedItem).Value;

                clbColumns.Items.Clear();

                foreach (Position pos in Position.list)
                {
                    if (pos.posParent == (Position)clbColumns.Tag)
                    {
                        clbColumns.Items.Add(new ComboBoxItem(pos.strName, pos));
                    }
                }

            }
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            StartProgressBar();
            bgwMembers.RunWorkerAsync();
        }

        private void BgwMembers_DoWork(object sender, DoWorkEventArgs e)
        {
            JsonMember.PullAll();
            JsonRecord.PullAll();
        }

        private void BgwMembers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (ListViewItem lvi in lvMembers.Items)
            {
                Member mem = (Member)lvi.Tag;

                lvi.SubItems[1].Text = mem.strName;
                lvi.SubItems[2].Text = Member.ratings[mem.intRating];
            }

            ColumnHeader chCID = lvResults.Columns[0];
            ColumnHeader chName = lvResults.Columns[1];

            lvResults.Columns.Clear();
            lvResults.Columns.Add(chCID);
            lvResults.Columns.Add(chName);

            foreach (Position pos in Position.list)
            {
                if (pos.isShown)
                {
                    lvResults.Columns.Add(pos.strName, -1, HorizontalAlignment.Left);
                    lvResults.Columns[lvResults.Columns.Count - 1].Tag = pos;
                }
            }

            foreach (Member mem in Member.list)
            {
                List<string> data = new List<string>();

                data.Add(mem.intCID.ToString());
                data.Add(mem.strName);

                for (int i = 2; i < lvResults.Columns.Count; i++)
                {
                    Position pos = (Position)lvResults.Columns[i].Tag;

                    Record rcd = Record.Find(mem.listRecords, pos.strName);

                    if (rcd == null)
                    {
                        data.Add("0");
                    }
                    else
                    {
                        data.Add(rcd.decMins.ToString("F2"));
                    }
                }

                lvResults.Items.Add(new ListViewItem(data.ToArray()));
            }

            ResizeListViewColumns(lvMembers);
            ResizeListViewColumns(lvResults);
            StopProgressBar();
        }

        private void ClbColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Position pos = (Position)((ComboBoxItem)clbColumns.Items[e.Index]).Value;

            if (e.NewValue == CheckState.Checked)
            {
                pos.isShown = true;
            }
            else
            {
                pos.isShown = false;
            }
        }

        private void StartProgressBar()
        {
            pbStatus.Style = ProgressBarStyle.Marquee;
            pbStatus.MarqueeAnimationSpeed = 30;
        }
        private void StopProgressBar()
        {
            pbStatus.Style = ProgressBarStyle.Continuous;
            pbStatus.Value = 0;
        }
    }
}
