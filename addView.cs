using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class addView : UserControl
    {
        public addView()
        {
            InitializeComponent();
            ddLocation.DataSource = DB_Handle.GetDataTable(string.Format(
                @"Select location_id from locations"));
            ddLocation.DisplayMember = "location_id";
            ddInsTitle.DataSource = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles"));
            ddInsTitle.DisplayMember = "title_id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainView mv = new mainView();
            this.Controls.Clear();
            this.Controls.Add(mv);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ddInsTitle.Text.Length > 0)
            {
                if (ddInsRangeType.Text == "Item" && txtInsRangeStart.Text.Length > 0)
                {
                    lstContents.Items.Add(ddInsTitle.Text + ", " + txtInsRangeStart.Text + "," + txtSeason.Text);
                }
                else if (ddInsRangeType.Text == "Range" && txtInsRangeStart.Text.Length > 0 &&
                    txtInsRangeEnd.Text.Length > 0)
                {
                    lstContents.Items.Add(ddInsTitle.Text + ", " + txtInsRangeStart.Text +
                        "-" + txtInsRangeEnd.Text + "," + txtSeason.Text);
                }
                else if (ddInsRangeType.Text == "Full")
                {
                    lstContents.Items.Add(ddInsTitle.Text + ", " + "Full" + "," + txtSeason.Text);
                }
                else
                    return;
                txtSeason.Clear();
                ddInsTitle.SelectedText = "";
                txtInsRangeStart.Clear();
                txtInsRangeEnd.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstContents.Items.Count > 0)
                lstContents.Items.RemoveAt(lstContents.SelectedIndex);
        }

        private void ddInsRangeType_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInsRangeStart.ReadOnly = true;
            txtInsRangeEnd.ReadOnly = true;
            txtInsRangeStart.Clear();
            txtInsRangeEnd.Clear();

            if (ddInsRangeType.Text == "Item")
                txtInsRangeStart.ReadOnly = false;
            else if (ddInsRangeType.Text == "Range")
            {
                txtInsRangeStart.ReadOnly = false;
                txtInsRangeEnd.ReadOnly = false;
            }
        }

        private void Change_Text_Color(object sender, EventArgs e)
        {
            TextBox text = new TextBox();
            text = (TextBox)sender;
            if (text.ReadOnly)
                text.BackColor = System.Drawing.Color.Gainsboro;
            else
                text.BackColor = System.Drawing.Color.Black; 
        }
    }
}
