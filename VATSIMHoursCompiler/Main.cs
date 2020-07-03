using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            bgwAPI.DoWork += BgwAPI_DoWork;
            bgwAPI.RunWorkerCompleted += BgwAPI_RunWorkerCompleted;

            bgwExport.DoWork += BgwExport_DoWork;
            bgwExport.RunWorkerCompleted += BgwExport_RunWorkerCompleted;

            bgwSaveProfile.DoWork += BgwSaveProfile_DoWork;
            bgwSaveProfile.RunWorkerCompleted += BgwSaveProfile_RunWorkerCompleted;

            bgwLoadProfile.DoWork += BgwLoadProfile_DoWork;
            bgwLoadProfile.RunWorkerCompleted += BgwLoadProfile_RunWorkerCompleted;

            clbColumns.ItemCheck += ClbColumns_ItemCheck;

            Text += " - Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
        }

        private void SetColumnWidth()
        {
            ResizeListViewColumns(lvMembers);
            ResizeListViewColumns(lvPositions);
            ResizeListViewColumns(lvConditions);
            ResizeListViewColumns(lvResults);
        }

        private void ResizeListViewColumns(ListView lv)
        {
            lv.BeginUpdate();

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            int[] headerWidths = new int[lv.Columns.Count];

            for (int i = 0; i < lv.Columns.Count; i++)
            {
                headerWidths[i] = lv.Columns[i].Width;
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
                Member memTemp = Member.Add(cid);

                if (memTemp == null)
                {
                    MessageBox.Show("Member has already been added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ListViewItem lviTemp = new ListViewItem(new string[] { cid.ToString(), memTemp.strName, Member.ratings[memTemp.intRating] });
                lviTemp.Tag = memTemp;

                if (cid == 1332038)
                {
                    lviTemp.Font = new Font("Comic Sans MS", lviTemp.Font.Size);
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
            Position posTemp = Position.Add(TxtPosName.Text, null);

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

                if (posTemp.posParent == null)
                {
                    Position.listRoot.Remove(posTemp);
                }
                else
                {
                    posTemp.posParent.listChildren.Remove(posTemp);
                }

                foreach (Position pos in posTemp.listChildren)
                {
                    pos.posParent = null;
                }

                lvPositions.SelectedItems.Clear();
                lvPositions.Items.Clear();

                foreach (Position pos in Position.list)
                {
                    string parent = "";

                    if (pos.posParent != null)
                    {
                        parent = pos.posParent.strName;
                    }

                    ListViewItem lviTemp = new ListViewItem(new string[] { pos.strName, parent, pos.listConditions.Count.ToString() });
                    lviTemp.Tag = pos;
                    lvPositions.Items.Add(lviTemp);
                }

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

                List<Position> descendents = posTemp.FindDescendents();

                foreach (ListViewItem lvi in lvPositions.Items)
                {
                    if (lvi != lvPositions.SelectedItems[0] && !descendents.Contains((Position)lvi.Tag))
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

                for (int i = 0; i < posTemp.listConditions.Count; i++)
                {
                    Condition con = posTemp.listConditions[i];

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
                    else
                    {
                        strData = new string[] { "", "None", "" };
                    }

                    ListViewItem lviTemp = new ListViewItem(strData);
                    lviTemp.Tag = con.intID;
                    lvConditions.Items.Add(lviTemp);
                }

                tlpDetails.Show();
            }
            else
            {
                tlpDetails.Hide();
            }

            ResizeListViewColumns(lvConditions);
        }

        private void lvConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConditions.SelectedItems.Count > 0)
            {
                int conid = (int)lvConditions.SelectedItems[0].Tag;
                Condition con = Condition.Find((Position)lvPositions.SelectedItems[0].Tag, conid);

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
            Condition con = Condition.Create("");
            ((Position)lvPositions.SelectedItems[0].Tag).listConditions.Add(con);

            ListViewItem lviTemp = new ListViewItem(new string[] { "", "None", "" });
            lviTemp.Tag = con.intID;
            lvConditions.Items.Add(lviTemp);

            lvConditions.SelectedItems.Clear();
            lvConditions.SelectedIndices.Add(lvConditions.Items.Count - 1);

            lvPositions.SelectedItems[0].SubItems[2].Text = ((Position)lvPositions.SelectedItems[0].Tag).listConditions.Count.ToString();

            ResizeListViewColumns(lvConditions);
        }

        private void BtnConRemove_Click(object sender, EventArgs e)
        {
            if (lvConditions.SelectedItems.Count > 0)
            {
                ((Position)lvPositions.SelectedItems[0].Tag).listConditions.Remove(Condition.Find((Position)lvPositions.SelectedItems[0].Tag, (int)lvConditions.SelectedItems[0].Tag));

                lvConditions.Items.Remove(lvConditions.SelectedItems[0]);
                lvPositions.SelectedItems[0].SubItems[2].Text = ((Position)lvPositions.SelectedItems[0].Tag).listConditions.Count.ToString();

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
            int conid = (int)lvConditions.SelectedItems[0].Tag;
            Condition con;

            string strName = TxtConName.Text;
            string strType = "";
            string strValue = "";

            switch (cbConType.SelectedItem)
            {
                case "Prefix Only":
                    strType = "Prefix";
                    strValue = TxtCon1.Text;

                    con = new PreCondition(conid, strName, strValue);
                    break;

                case "Suffix Only":
                    strType = "Suffix";
                    strValue = TxtCon1.Text;

                    con = new SufCondition(conid, strName, strValue);
                    break;

                case "Prefix and Suffix":
                    strType = "Prefix/Suffix";

                    string str1 = TxtCon1.Text;
                    string str2 = TxtCon2.Text;
                    strValue = TxtCon1.Text + "/" + TxtCon2.Text;

                    con = new PreSufCondition(conid, strName, str1, str2);
                    break;

                case "Specific Callsign":
                    strType = "Callsign";
                    strValue = TxtCon1.Text;

                    con = new CsCondition(conid, strName, strValue);
                    break;

                default:
                    con = new Condition(conid, "");
                    break;
            }

            Position pos = (Position)lvPositions.SelectedItems[0].Tag;

            pos.listConditions[pos.listConditions.IndexOf(Condition.Find(pos, conid))] = con;

            lvConditions.SelectedItems[0].SubItems[0].Text = strName;
            lvConditions.SelectedItems[0].SubItems[1].Text = strType;
            lvConditions.SelectedItems[0].SubItems[2].Text = strValue;

            lvPositions.SelectedItems[0].SubItems[2].Text = pos.listConditions.Count.ToString();

            ResizeListViewColumns(lvConditions);
        }

        private void BtnDetSave_Click(object sender, EventArgs e)
        {
            Position pos = (Position)lvPositions.SelectedItems[0].Tag;
            pos.strName = TxtDetName.Text;

            lvPositions.SelectedItems[0].SubItems[0].Text = pos.strName;
            ResizeListViewColumns(lvPositions);

            if (clbColumns.Tag == pos.posParent)
            {
                foreach (ComboBoxItem cbi in clbColumns.Items)
                {
                    if (((Position)cbi.Value) == pos)
                    {
                        cbi.Text = pos.strName;
                    }
                }
            }
        }

        private void BtnParent_Click(object sender, EventArgs e)
        {
            if (clbColumns.Tag != null)
            {
                clbColumns.Tag = ((Position)clbColumns.Tag).posParent;

                PopulateColumnsSelector();
            }
        }

        private void BtnChildren_Click(object sender, EventArgs e)
        {
            if (clbColumns.SelectedIndex != -1)
            {
                clbColumns.Tag = ((ComboBoxItem)clbColumns.SelectedItem).Value;

                PopulateColumnsSelector();

            }
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            if (bgwAPI.IsBusy)
            {
                MessageBox.Show("Already getting data from the VATSIM API.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StartProgressBar();
                bgwAPI.RunWorkerAsync();
            }
        }

        private void BgwAPI_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = new bool[] { true, true };

            try
            {
                JsonMember.PullAll();
            }
            catch
            {
                ((bool[])e.Result)[0] = false;
                MessageBox.Show("There was an error while accessing the VATSIM Member Data API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                DateTime dtStart = default(DateTime);
                DateTime dtEnd = default(DateTime);

                if (dtpDatStart.Enabled)
                {
                    dtStart = dtpDatStart.Value;
                    dtStart = new DateTime(dtStart.Year, dtStart.Month, dtStart.Day, 0, 0, 0);
                }

                if (dtpDatEnd.Enabled)
                {
                    dtEnd = dtpDatEnd.Value;
                    dtEnd = new DateTime(dtEnd.Year, dtEnd.Month, dtEnd.Day, 23, 59, 59);
                }

                JsonRecord.PullAll(dtStart, dtEnd);
            }
            catch
            {
                ((bool[])e.Result)[1] = false;
                MessageBox.Show("There was an error while accessing the VATSIM Statistics API. Note that the API will always fail if one of the requested members is currently online.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BgwAPI_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (((bool[])e.Result)[0])
            {
                foreach (ListViewItem lvi in lvMembers.Items)
                {
                    Member mem = (Member)lvi.Tag;

                    lvi.SubItems[1].Text = mem.strName;
                    lvi.SubItems[2].Text = Member.ratings[mem.intRating];
                }

                ResizeListViewColumns(lvMembers);
            }

            if (((bool[])e.Result)[1])
            {
                PopulateResults();
            }


            if (!bgwExport.IsBusy && !bgwSaveProfile.IsBusy && !bgwLoadProfile.IsBusy)
            {
                StopProgressBar();
            }
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

        private void BtnRefilter_Click(object sender, EventArgs e)
        {
            PopulateResults();
        }

        private void PopulateResults()
        {
            List<string[]> listResults = new List<string[]>();

            lvResults.Items.Clear();

            ColumnHeader chCID = lvResults.Columns[0];
            ColumnHeader chName = lvResults.Columns[1];
            ColumnHeader chResBlank = lvResults.Columns[lvResults.Columns.Count - 1];

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

            lvResults.Columns.Add(chResBlank);

            foreach (Member mem in Member.list)
            {
                List<string> data = new List<string>();

                data.Add(mem.intCID.ToString());
                data.Add(mem.strName);

                for (int i = 2; i < lvResults.Columns.Count - 1; i++)
                {
                    Position pos = (Position)lvResults.Columns[i].Tag;

                    Record rcd = Record.Find(mem.listRecords, pos.intID);

                    if (rcd == null)
                    {
                        data.Add("0");
                    }
                    else
                    {
                        decimal decMins = rcd.MinsWithChildren();

                        data.Add(decimal.Truncate(decMins / 60).ToString("F0") + ":" + decimal.Truncate(decMins % 60).ToString("00"));
                    }
                }

                string[] arrData = data.ToArray();
                listResults.Add(arrData);

                ListViewItem lviTemp = new ListViewItem(arrData);

                if (mem.intCID == 1332038)
                {
                    lviTemp.Font = new Font("Comic Sans MS", lviTemp.Font.Size);
                }

                lvResults.Items.Add(lviTemp);
            }

            lvResults.Tag = listResults;

            ResizeListViewColumns(lvResults);
        }

        private void cbDetParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Position pos = (Position)lvPositions.SelectedItems[0].Tag;
            Position oldparent = pos.posParent;

            Position parent = (Position)((ComboBoxItem)cbDetParent.SelectedItem).Value;

            if (oldparent == null)
            {
                Position.listRoot.Remove(pos);
            }
            else
            {
                oldparent.listChildren.Remove(pos);
            }

            pos.posParent = parent;

            string strParent = "";

            if (parent == null)
            {
                Position.listRoot.Add(pos);
            }
            else
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

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bgwExport.IsBusy)
            {
                MessageBox.Show("Already exporting data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = sfdExport.ShowDialog();

                if (result == DialogResult.OK && sfdExport.FileName != "")
                {
                    StartProgressBar();
                    bgwExport.RunWorkerAsync(sfdExport.FileName);
                }

            }
        }

        private void BgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            string export = "";

            export += lvResults.Columns[0].Text;

            for (int i = 1; i < lvResults.Columns.Count; i++)
            {
                export += "," + lvResults.Columns[i].Text;
            }

            foreach (string[] arr in (List<string[]>)lvResults.Tag)
            {
                export += "\r\n" + arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    export += "," + arr[i];
                }
            }

            File.WriteAllText((string)e.Argument, export);
        }

        private void BgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bgwAPI.IsBusy && !bgwSaveProfile.IsBusy && !bgwLoadProfile.IsBusy)
            {
                StopProgressBar();
            }

            MessageBox.Show("Export completed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bgwLoadProfile.IsBusy)
            {
                MessageBox.Show("Currently loading another profile. Please try again later.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bgwSaveProfile.IsBusy)
            {
                MessageBox.Show("Already saving profile.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = sfdProfile.ShowDialog();

                if (result == DialogResult.OK && sfdProfile.FileName != "")
                {
                    StartProgressBar();
                    bgwSaveProfile.RunWorkerAsync(sfdProfile.FileName);
                }
            }
        }

        private void BgwSaveProfile_DoWork(object sender, DoWorkEventArgs e)
        {
            XMLSerial.Save((string)e.Argument);
        }

        private void BgwSaveProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bgwAPI.IsBusy && !bgwExport.IsBusy && !bgwLoadProfile.IsBusy)
            {
                StopProgressBar();
            }

            MessageBox.Show("Profile saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bgwLoadProfile.IsBusy)
            {
                MessageBox.Show("Already loading profile.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bgwSaveProfile.IsBusy)
            {
                MessageBox.Show("Currently saving the open profile. Please try again later.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = ofdProfile.ShowDialog();

                if (result == DialogResult.OK && ofdProfile.FileName != "")
                {
                    StartProgressBar();
                    bgwLoadProfile.RunWorkerAsync(ofdProfile.FileName);
                }
            }

        }

        private void BgwLoadProfile_DoWork(object sender, DoWorkEventArgs e)
        {
            XMLSerial.Load((string)e.Argument);
        }

        private void BgwLoadProfile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bgwAPI.IsBusy && !bgwExport.IsBusy && !bgwSaveProfile.IsBusy)
            {
                StopProgressBar();
            }

            lvMembers.Items.Clear();
            lvPositions.Items.Clear();

            tlpDetails.Hide();
            tlpConditions.Hide();

            foreach (Member mem in Member.list)
            {
                ListViewItem lviTemp = new ListViewItem(new string[] { mem.intCID.ToString(), mem.strName, Member.ratings[mem.intRating] });
                lviTemp.Tag = mem;

                if (mem.intCID == 1332038)
                {
                    lviTemp.Font = new Font("Comic Sans MS", lviTemp.Font.Size);
                }

                lvMembers.Items.Add(lviTemp);
            }

            ResizeListViewColumns(lvMembers);

            foreach (Position pos in Position.list)
            {
                string parent = "";

                if (pos.posParent != null)
                {
                    parent = pos.posParent.strName;
                }

                ListViewItem lviTemp = new ListViewItem(new string[] { pos.strName, parent, pos.listConditions.Count.ToString() });
                lviTemp.Tag = pos;
                lvPositions.Items.Add(lviTemp);
            }

            ResizeListViewColumns(lvPositions);

            PopulateColumnsSelector();

            //MessageBox.Show("Profile loaded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PopulateColumnsSelector()
        {
            clbColumns.Items.Clear();

            foreach (Position pos in Position.list)
            {
                if (pos.posParent == (Position)clbColumns.Tag)
                {
                    clbColumns.Items.Add(new ComboBoxItem(pos.strName, pos));
                    clbColumns.SetItemChecked(clbColumns.Items.Count - 1, pos.isShown);
                }
            }

            if (clbColumns.Tag == null)
            {
                LblColumns.Text = "";
            }
            else
            {
                LblColumns.Text = "Parent:\n" + ((Position)clbColumns.Tag).strName;
            }
        }

        private void cbDatStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDatStart.Checked)
            {
                dtpDatStart.Enabled = true;
            }
            else
            {
                dtpDatStart.Enabled = false;
            }
        }

        private void cbDatEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDatEnd.Checked)
            {
                dtpDatEnd.Enabled = true;
            }
            else
            {
                dtpDatEnd.Enabled = false;
            }
        }
    }
}
