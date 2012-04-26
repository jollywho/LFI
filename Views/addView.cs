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
            ddInsRangeType_SelectedValueChanged(null, null);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.pushback_formView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string error = "";
            if (ddInsTitle.Text.Length > 0 && ddInsTitle.FindStringExact(ddTitle.Text) != -1)
            {
                if (ddInsRangeType.Text == "")
                    error += "Range type required\n";
                if (ddInsRangeType.Text == "Item" && txtInsRangeStart.Text.Length < 3)
                    error += "Item required\n";
                if (ddInsRangeType.Text == "Range" &&
                    txtInsRangeStart.Text.Length < 3 && txtInsRangeEnd.Text.Length < 3)
                    error += "range required\n";
                if (txtSeason.Text.Length < 2)
                    error += "Season required\n";

                if (error != "")
                {
                    MessageBox.Show(error, "Validation Error");
                    return;
                }
                else
                {
                    switch (ddInsRangeType.Text)
                    {
                        case "Item":
                            lstContents.Items.Add(ddInsTitle.Text + "," +
                                txtSeason.Text + "," + txtInsRangeStart.Text);
                            break;
                        case "Range":
                            lstContents.Items.Add(ddInsTitle.Text + "," +
                                txtSeason.Text + "," + txtInsRangeStart.Text + 
                                "-" + txtInsRangeEnd.Text);
                                
                            break;
                        case "Full":
                            lstContents.Items.Add(ddInsTitle.Text + "," + 
                                txtSeason.Text + "," + "Full");
                            break;
                    }

                    txtSeason.Clear();
                    ddInsTitle.SelectedText = "";
                    txtInsRangeStart.Clear();
                    txtInsRangeEnd.Clear();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstContents.Items.Count > 0)
                lstContents.Items.RemoveAt(lstContents.SelectedIndex);
        }

        private void ddInsRangeType_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInsRangeStart.Hide();
            txtInsRangeEnd.Hide();
            lblStart.Hide();
            lblEnd.Hide();
            lblRange.Hide();
            txtInsRangeStart.Clear();
            txtInsRangeEnd.Clear();

            if (ddInsRangeType.Text == "Item")
            {
                txtInsRangeStart.Show();
                lblStart.Show();
                lblStart.Text = "Ep #";
            }
            else if (ddInsRangeType.Text == "Range")
            {
                txtInsRangeStart.Show();
                txtInsRangeEnd.Show();
                lblStart.Text = "Start";
                lblEnd.Text = "End";
                lblRange.Show();
                lblStart.Show();
                lblEnd.Show();
            }
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                if (ddTitle.Text.Length == 0)
                    error += "Title required or too short\n";
                if (ddTitle.Text.Contains(','))
                    error += "Illegal Char in title";
                if (ddTitle.FindStringExact(ddTitle.Text) != -1)
                    error += "Title already exists\n";
                if (ddCategory.Text.Length == 0)
                    error += "Category required\n";
                if (ddStatus.Text.Length < 3)
                    error += "Status required\n";
                if (txtYear.Text.Length < 4)
                    error += "Year required\n";
                if (ddLanguage.Text.Length < 1)
                    error += "Language required\n";
                if (txtEpisode.Text.Length < 3)
                    error += "Episode # required\n";

                if (error.Length != 0)
                {
                    MessageBox.Show(error, "Validation Error");
                }
                else
                {
                    //add
                    DB_Handle.UpdateTable(string.Format(@"INSERT INTO TITLES 
                        (title_id, episodes, year, status, language)
                        VALUES ('{0}','{1:000}','{2}','{3}','{4}');",
                        ddTitle.Text, txtEpisode.Text, txtYear.Text,
                        ddStatus.Text, ddLanguage.Text));
                    MessageBox.Show("Saved", "Success");
                    caller.load_formView(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
        }

        private void btnAddDisc_Click(object sender, EventArgs e)
        {
            string error = "";
            bool rollbackpos = false;

            if (txtDisc.Text.Length < 1)
                error += "Disc required\n";
            if (txtPage.Text.Length < 3)
                error += "Error required\n";
            if (ddLocation.Text.Length < 1)
                error += "Location required\n";
            if (lstContents.Items.Count < 1)
                error += "Content required\n";

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Validation Error");
            }
            else
            {
                try
                {
                    DB_Handle.UpdateTable(string.Format(
                    @"INSERT INTO DISCS 
                    (disc_id, page_number, location_id)
                    VALUES ('{0:000}','{1:000}','{2:000}');",
                    txtDisc.Text, txtPage.Text, ddLocation.Text));
                    rollbackpos = true;

                    foreach (string str in lstContents.Items)
                    {
                        string[] item = str.Split(',');
                        DB_Handle.UpdateTable(string.Format(
                        @"INSERT INTO DISC_CONTENTS 
                        (disc_id, title_id, season, range)
                        VALUES ('{0:000}','{1:000}','{2:000}','{3}');",
                        txtDisc.Text, item[0], item[1], item[2]));
                    }
                    MessageBox.Show("Saved", "Success");
                    caller.load_formView(this);
                }
                catch (Exception ex)
                {
                    if (rollbackpos)
                        DB_Handle.UpdateTable(string.Format(
                        @"DELETE FROM DISCS WHERE
                        disc_id = '{0:000}' AND location_id = '{1:000}'",
                        txtDisc.Text, ddLocation.Text));
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DB_Handle.GetDataTable(string.Format(
                @"select max(disc_id) from discs 
                where location_id = '{0}'", ddLocation.Text));
                txtDisc.Text = (Convert.ToInt32(dt.Rows[0][0])+1).ToString("000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ddLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDisc.Clear();
        }
    }
}
