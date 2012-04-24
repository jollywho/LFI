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
        private MainForm caller;

        public addView(MainForm main)
        {
            InitializeComponent();
            caller = main;
            ddLocation.DataSource = DB_Handle.GetDataTable(string.Format(
                @"Select location_id from locations order by location_id"));
            ddLocation.DisplayMember = "location_id";
            DataTable titles = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles order by title_id"));
            ddInsTitle.DataSource = titles;
            ddInsTitle.DisplayMember = "title_id";
            ddTitle.DataSource = titles;
            ddTitle.DisplayMember = "title_id";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.pushback_formView();
        }

        //todo: restructure for proper validation + errormsg
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string error = "";
            if (ddInsTitle.Text.Length > 0 && ddInsTitle.FindStringExact(ddTitle.Text) != -1)
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
                {
                    MessageBox.Show(error, "Validation Error");
                    return;
                }
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

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                if (ddTitle.Text.Length < 0)
                    error += "Title required\n";
                if (ddTitle.FindStringExact(ddTitle.Text) != -1)
                    error += "Title already exists\n";
                if (ddCategory.Text.Length < 0)
                    error += "Category required\n";
                if (ddStatus.Text.Length < 0)
                    error += "Status required\n";
                if (txtYear.Text == "")
                    error += "Year required\n";
                if (ddLanguage.Text.Length < 0)
                    error += "Language required\n";
                if (txtEpisode.Text == "" || txtEpisode.Text.Length < 3)
                    error += "Episode required ('###')\n";

                if (error.Length != 0)
                {
                    MessageBox.Show(error, "Validation Error");
                }
                else
                {
                    //add
                    DB_Handle.UpdateTable(string.Format(@"INSERT INTO TITLES 
                        (title_id, episodes, year, status, language)
                        VALUES ('{0}','{1}','{2}','{3}','{4}');",
                        ddTitle.Text, txtEpisode.Text, txtYear.Text,
                        ddStatus.Text, ddLanguage.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }

        }

        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
        }
    }
}
