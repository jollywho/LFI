using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class discView : UserControl
    {
        private BackgroundWorker worker = new BackgroundWorker();
        const int MAX_TOOLTIP = 500;
        bool isNewRecord = false;
        private int currentPage = 1;
        const int DISCS_PER_PAGE = 8;
        private int max_pages = 0;
        private DataTable dtView;
        VLabel[] dLabels = new VLabel[DISCS_PER_PAGE];

        public discView()
        {
            InitializeComponent();

            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);

            DataTable locations = DB_Handle.GetDataTable(string.Format(
                @"Select location_id from locations order by location_id"));
            ddLocation.DisplayMember = "location_id";
            ddLocation.DataSource = locations;
            
            
            DataTable titles = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles order by title_id"));
            ddInsTitle.DataSource = titles;
            ddInsTitle.DisplayMember = "title_id";

            for (int i = 1; i <= DISCS_PER_PAGE; i++)
            {
                Button btn = (Button)this.Controls[("btn" + i).ToString()];
                dLabels[i-1] = createVertLabel(btn, copyLabel, "");
                Controls.Add(dLabels[i - 1]);
            }

            loadView();
        }

        private void loadView()
        {
            dtView = DB_Handle.GetDataTable(string.Format(@"select * from discs
                where location_id='{0}'", ddLocation.Text));
            if (dtView.Rows.Count % DISCS_PER_PAGE != 0 && dtView.Rows.Count > 0)
                max_pages = dtView.Rows.Count / 8;
            else
                max_pages = (dtView.Rows.Count / 8) + 1;
            scrlPage.Maximum = max_pages;
            loadPage();
        }

        private void loadPage()
        {
            DataTable temp = new DataTable();
            for (int i = 1; i <= DISCS_PER_PAGE; i++)
            {
                temp = DB_Handle.GetDataTable(string.Format(@"select * from discs
                    where location_id='{0}' and page_number='{1}' and slot_number='{2}'",
                     ddLocation.Text, txtPageNo.Text, i.ToString()));
                if (temp.Rows.Count != 0)
                    dLabels[i-1].Text = temp.Rows[0][0].ToString();
                else
                    dLabels[i-1].Text = "Empty";
                //Controls[("btn" + i).ToString()].BackgroundImage = generateDiscImage(dLabels[i - 1].Text);
            }
            if (!worker.IsBusy)
                worker.RunWorkerAsync(temp);
            
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DataTable temp = (DataTable)e.Argument;

            for (int i = 1; i <= DISCS_PER_PAGE; i++)
            {
                Controls[("btn" + i).ToString()].BackgroundImage = generateDiscImage(dLabels[i - 1].Text);
            }
        }

        private VLabel createVertLabel(Button btn, Label copylabel, string text)
        {
            VLabel lbl = new VLabel();
            lbl.Text = text;
            lbl.Font = copylabel.Font;
            lbl.ForeColor = copylabel.ForeColor;
            lbl.Size = new System.Drawing.Size(18, btn.Height);
            Point point = btn.Location;
            point.X -= lbl.Size.Width;
            lbl.Location = point;
            return lbl;
        }

        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ddInsTitle.Text.Length > 0 && ddInsTitle.FindStringExact(ddInsTitle.Text) != -1)
            {
                if (txtSeason.Text.Length < 1)
                    Error_Handle.TipError("Season required\n", toolTip, txtSeason);
                else if (txtInsRangeStart.Text.Length < 1)
                    Error_Handle.TipError("Start range required\n", toolTip, txtInsRangeStart);
                else if (txtInsRangeEnd.Text.Length < 1)
                    Error_Handle.TipError("End range required\n", toolTip, txtInsRangeEnd);
                else
                {
                    DataGridViewRow gvr = new DataGridViewRow();
                    gvr.CreateCells(gvContents, ddInsTitle.Text, txtSeason.Text,
                        txtInsRangeStart.Text.Replace(" ", ""),
                        txtInsRangeEnd.Text.Replace(" ", ""));
                    gvContents.Rows.Add(gvr);

                    txtSeason.Clear();
                    ddInsTitle.SelectedText = "";
                    txtInsRangeStart.Clear();
                    txtInsRangeEnd.Clear();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gvContents.Rows.Count > 0)
                gvContents.Rows.Remove(gvContents.Rows[gvContents.SelectedCells[0].RowIndex]);
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            bool rollbackpos = false;

            if (txtDisc.Text.Length < 1)
                Error_Handle.TipError("Disc required\n", toolTip, txtDisc);
            else if (txtPage.Text.Length < 1)
                Error_Handle.TipError("Page required\n", toolTip, txtPage);
            else if (txtSlot.Text.Length < 1)
                Error_Handle.TipError("Slot required\n", toolTip, txtSlot);
            else if (ddLocation.Text.Length < 1)
                Error_Handle.TipError("Location required\n", toolTip, ddLocation);
            else if (gvContents.Rows.Count < 1)
                Error_Handle.TipError("Content required\n", toolTip, gvContents);
            else
            {
                try
                {
                    DB_Handle.UpdateTable(string.Format(
                        @"INSERT OR REPLACE INTO DISCS 
                        VALUES ('{0}','{1}','{2}','{3}');",
                        txtDisc.Text, txtPage.Text, txtSlot.Text, ddLocation.Text));
                    if (isNewRecord)
                        rollbackpos = true;

                    for (int i = 0; i <= gvContents.Rows.Count - 1; i++)
                    {
                        DB_Handle.UpdateTable(string.Format(
                            @"INSERT OR REPLACE INTO DISC_CONTENTS 
                            (disc_id, title_id, season, rangeStart, rangeEnd)
                            VALUES ('{0}','{1}','{2}','{3}','{4}');",
                            txtDisc.Text, gvContents.Rows[i].Cells[0].Value,
                            gvContents.Rows[i].Cells[1].Value, gvContents.Rows[i].Cells[2].Value,
                            gvContents.Rows[i].Cells[3].Value));
                    }
                    MessageBox.Show("Saved", "Success");
                }
                catch (Exception ex)
                {
                    if (rollbackpos)
                        DB_Handle.UpdateTable(string.Format(
                            @"DELETE FROM DISCS WHERE
                            disc_id = '{0}' AND location_id = '{1}'",
                            txtDisc.Text, ddLocation.Text));
                    Error_Handle.TipError(ex.Message, toolTip, btnAddDisc);
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
                    txtDisc.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString("000");
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

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void ddLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            //reload
        }

        private void scrlPage_Scroll(object sender, ScrollEventArgs e)
        {
            currentPage = e.NewValue;
            txtPageNo.Text = e.NewValue.ToString();
            loadPage();
        }

        private Image generateDiscImage(string discid)
        {
            Image img = LFI.Properties.Resources.border;
            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"Select * from discs natural join disc_contents where
                disc_id='{0}' order by title_id", discid));

            if (temp.Rows.Count > 0)
            {
                List<string> disc_titles = new List<string>();
                if (temp.Rows.Count > 0)
                {
                    for (int i = 0; i <= temp.Rows.Count - 1; i++)
                    {
                        disc_titles.Add(temp.Rows[i][4].ToString());
                    }
                }
                img = Image_IO.createMergedImage(disc_titles, btn1);
            }
            return img;
        }

        private void disc_btn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            gvContents.Rows.Clear();
            imgTitle.BackgroundImage = null;
            Button btn = (Button)sender;
            string discid = dLabels[Convert.ToInt32(btn.Name.Substring(btn.Name.Length-1, 1))-1].Text;

            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"Select * from discs natural join disc_contents where
                disc_id='{0}' order by title_id", discid));

            if (temp.Rows.Count > 0)
            {
                isNewRecord = false;
                txtDisc.Text = temp.Rows[0][0].ToString();
                txtPage.Text = temp.Rows[0][1].ToString();
                txtSlot.Text = temp.Rows[0][2].ToString();
                for (int i=0; i<=temp.Rows.Count -1; i++)
                {
                    gvContents.Rows.Add(temp.Rows[i][4], temp.Rows[i][5], temp.Rows[i][6], temp.Rows[i][7]);
                }
            }
            else
            {
                isNewRecord = true;
                txtDisc.Clear();
                txtPage.Text = txtPageNo.Text;
                txtSlot.Text = (Convert.ToInt32(btn.Name.Substring(btn.Name.Length - 1, 1))).ToString();
            }
            imgTitle.BackgroundImage = generateDiscImage(discid);
        }

        private void txtPageNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loadPage();
        }
    }
}
