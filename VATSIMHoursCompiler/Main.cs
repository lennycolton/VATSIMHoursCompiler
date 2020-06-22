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

            lvPositions.SelectedIndexChanged += LvPositions_SelectedIndexChanged;
        }

        private void LvPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SetColumnWidth()
        {
            foreach (ColumnHeader header in lvMembers.Columns)
            {
                header.Width = -2;
            }

            foreach (ColumnHeader header in lvPositions.Columns)
            {
                header.Width = -2;
            }
        }

        private void BtnMemAdd_Click(object sender, EventArgs e)
        {
            int cid = -1;

            if (int.TryParse(TxtMemCID.Text, out cid))
            {
                Member memTemp = new Member(cid);
                Member.list.Add(memTemp);

                string last = "";

                if (memTemp.dtLastLogon != default(DateTime))
                {
                    last = memTemp.dtLastLogon.ToString("dd/MM/yyyy HH:mm");
                }

                ListViewItem lviTemp = new ListViewItem(new string[] { cid.ToString(), memTemp.strName, memTemp.intRating.ToString(), last });
                lviTemp.Tag = memTemp;

                if (cid == 1332038)
                {
                    lviTemp.Font = new Font(new Font("Comic Sans MS", lviTemp.Font.Size), FontStyle.Bold);
                }

                lvMembers.Items.Add(lviTemp);

                SetColumnWidth();
            }

            TxtMemCID.Clear();
        }

        private void BtnMemRemove_Click(object sender, EventArgs e)
        {
            if (lvMembers.SelectedItems.Count > 0)
            {
                Member.list.Remove((Member)lvMembers.SelectedItems[0].Tag);
                lvMembers.Items.Remove(lvMembers.SelectedItems[0]);
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
        }

        private void BtnPosRemove_Click(object sender, EventArgs e)
        {
            if (lvPositions.SelectedItems.Count > 0)
            {
                Position.list.Remove((Position)lvPositions.SelectedItems[0].Tag);
                lvPositions.Items.Remove(lvPositions.SelectedItems[0]);
            }
        }
    }
}
