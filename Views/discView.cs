using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LFI
{
    public partial class discView : UserControl
    {
        private BackgroundWorker worker = new BackgroundWorker();
        const int MAX_TOOLTIP = 500;
        bool isNewRecord = false;
        const int DISCS_PER_PAGE = 4;
        const int PAGES_PER_VIEW = 2;
        private int max_pages = 0;
        private DataTable dtView;
        VLabel[][] dLabels = new VLabel[PAGES_PER_VIEW][];

        public discView()
        {
            InitializeComponent();
            DoubleBuffered = true;
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

            for (int j = 1; j <= PAGES_PER_VIEW; j++)
            {
                dLabels[j - 1] = new VLabel[DISCS_PER_PAGE];
                for (int i = 1; i <= DISCS_PER_PAGE; i++)
                {
                    Button btn = (Button)this.Controls[("btn" + (i + (DISCS_PER_PAGE * (j - 1))).ToString())];
                    btn.Visible = true;
                    dLabels[j - 1][i - 1] = createVertLabel(btn, copyLabel, "");
                    Controls.Add(dLabels[j-1][i - 1]);
                }
            }
            loadView();
        }

        private void loadView()
        {
            dtView = DB_Handle.GetDataTable(string.Format(@"select max_storage from locations
                where location_id='{0}'", ddLocation.Text));
            max_pages = Convert.ToInt32(dtView.Rows[0][0].ToString());
            scrlPage.Maximum = max_pages + scrlPage.LargeChange-1;
            loadPage();
        }

        private int jumpPage()
        {
            int pg = Convert.ToInt32(txtJump.Text);
            if (pg % 2 != 0)
                pg = Convert.ToInt32(txtJump.Text) - 1;
            lblPageLeft.Text = pg.ToString();
            lblPageRight.Text = (pg + 1).ToString();
            return pg;
        }

        private void loadPage()
        {
            DataTable temp = new DataTable();
            int jump = jumpPage();
            hidePage(1, true, 2);
            for (int j = 1; j <= PAGES_PER_VIEW; j++)
            {
                int page = jump + j - 1;

                for (int i = 1; i <= DISCS_PER_PAGE; i++)
                {
                    temp = DB_Handle.GetDataTable(string.Format(@"select * from discs
                        where location_id='{0}' and page_number='{1}' and slot_number='{2}'",
                         ddLocation.Text, page, i.ToString()));
                    if (temp.Rows.Count != 0)
                        dLabels[j - 1][i - 1].Text = temp.Rows[0][0].ToString();
                    else if (jump == 0 || page - 1 == max_pages)
                        dLabels[j - 1][i - 1].Text = "";
                    else
                        dLabels[j - 1][i - 1].Text = "Empty";
                }
            }
            if (jump == 0)
                hidePage(1, false);
            else if (jump == max_pages)
                hidePage(DISCS_PER_PAGE + 1, false);

            if (!worker.IsBusy)
                worker.RunWorkerAsync(temp);
        }

        private void hidePage(int start, bool vis, int all=1)
        {
            lblPageLeft.Visible = true;
            lblPageRight.Visible = true;

            if (start == 1)
                lblPageLeft.Visible = vis;
            else
                lblPageRight.Visible = vis;

            for (int i = start; i <= start + (DISCS_PER_PAGE * all) -1; i++)
            {
                Button btn = (Button)this.Controls[("btn" + i.ToString())];
                btn.Visible = vis;
            }
        }

        private void scrlPage_ValueChanged(object sender, EventArgs e)
        {
            loadPage();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DataTable temp = (DataTable)e.Argument;

            for (int j = 1; j <= PAGES_PER_VIEW; j++)
            {
                int page = Convert.ToInt32(txtJump.Text) + j;
                for (int i = 1; i <= DISCS_PER_PAGE; i++)
                {
                    Button btn = (Button)Controls[("btn" + (i + (DISCS_PER_PAGE * (j - 1))).ToString())];
                    btn.BackgroundImage = generateDiscImage(dLabels[j - 1][i - 1].Text, btn1);
                }
            }
        }

        private VLabel createVertLabel(Button btn, Label copylabel, string text)
        {
            VLabel lbl = new VLabel();
            lbl.Name = btn.Name.Replace("btn", "lbl");
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
                else if (txtRangeStart.Text.Length < 1)
                    Error_Handle.TipError("Start range required\n", toolTip, txtRangeStart);
                else if (txtRangeEnd.Text.Length < 1)
                    Error_Handle.TipError("End range required\n", toolTip, txtRangeEnd);
                else
                {
                    DataGridViewRow gvr = new DataGridViewRow();
                    gvr.CreateCells(gvContents, ddInsTitle.Text, txtSeason.Text,
                        txtRangeStart.Text.Replace(" ", ""),
                        txtRangeEnd.Text.Replace(" ", ""), "null");
                    gvContents.Rows.Add(gvr);

                    txtSeason.Clear();
                    ddInsTitle.SelectedText = "";
                    txtRangeStart.Clear();
                    txtRangeEnd.Clear();
                }
            }
            else
                Error_Handle.TipError("Invalid title\n", toolTip, ddInsTitle);
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
                    DB_Handle.OpenConnection();
                    for (int i = 0; i <= gvContents.Rows.Count - 1; i++)
                    {
                        DB_Handle.ScalarUpdate(string.Format(
                            @"INSERT OR REPLACE INTO CONTENTS 
                            (content_id, title_id, season, rangeStart, rangeEnd)
                            VALUES ({0},{1},'{2}','{3}','{4}');",
                            gvContents.Rows[i].Cells[4].Value,
                            "\"" + gvContents.Rows[i].Cells[0].Value + "\"",
                            gvContents.Rows[i].Cells[1].Value,
                            gvContents.Rows[i].Cells[2].Value,
                            gvContents.Rows[i].Cells[3].Value));

                        DB_Handle.ScalarUpdate(string.Format(
                            @"INSERT OR REPLACE INTO DISC_CONTENTS
                            (content_id, disc_id, location_id)
                            VALUES (last_insert_rowid(),'{0}','{1}');",
                            txtDisc.Text, ddLocation.Text));
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
                finally
                {
                    DB_Handle.CloseConnection();
                    loadPage();
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
                if (dt.Rows[0][0] is DBNull)
                    txtDisc.Text = "001";
                else
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
            txtJump.Text = e.NewValue.ToString();
            loadPage();
        }

        private Image generateDiscImage(string discid, Control btn)
        {
            Image img = LFI.Properties.Resources.border;
            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"Select discs.disc_id, discs.page_number, discs.slot_number,
                contents.title_id, contents.season, contents.rangeStart,
                contents.rangeEnd, disc_contents.content_id from discs
                INNER JOIN disc_contents ON discs.disc_id = 
                disc_contents.disc_id INNER JOIN contents on
                disc_contents.content_id = contents.content_id WHERE
                discs.disc_id='{0}'", discid));

            if (temp.Rows.Count > 0)
            {
                List<string> disc_titles = new List<string>();
                if (temp.Rows.Count > 0)
                {
                    for (int i = 0; i <= temp.Rows.Count - 1; i++)
                    {
                        disc_titles.Add(temp.Rows[i][3].ToString());
                    }
                }
                img = Image_IO.createMergedImage(disc_titles, btn);
            }
            return img;
        }

        private void disc_btn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            gvContents.Rows.Clear();
            imgTitle.BackgroundImage = null;
            Button btn = (Button)sender;
            int pos = Convert.ToInt32(btn.Name.Substring(btn.Name.Length-1, 1));
            int page = 0;
            if (pos > DISCS_PER_PAGE)
            {
                pos -= DISCS_PER_PAGE;
                page = 1;
            }
            
            string discid = dLabels[page][pos-1].Text;

            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"Select discs.disc_id, discs.page_number, discs.slot_number,
                contents.title_id, contents.season, contents.rangeStart,
                contents.rangeEnd, disc_contents.content_id from discs
                INNER JOIN disc_contents ON discs.disc_id = 
                disc_contents.disc_id INNER JOIN contents on
                disc_contents.content_id = contents.content_id WHERE
                discs.disc_id='{0}'", discid));

            if (temp.Rows.Count > 0)
            {
                isNewRecord = false;
                txtDisc.Text = temp.Rows[0][0].ToString();
                txtPage.Text = temp.Rows[0][1].ToString();
                txtSlot.Text = temp.Rows[0][2].ToString();
                for (int i=0; i<=temp.Rows.Count -1; i++)
                {
                    gvContents.Rows.Add(temp.Rows[i][3], temp.Rows[i][4],
                        temp.Rows[i][5], temp.Rows[i][6],  temp.Rows[i][7]);
                }
            }
            else
            {
                isNewRecord = true;
                txtDisc.Clear();
                txtPage.Text = txtJump.Text;
                txtSlot.Text = (Convert.ToInt32(btn.Name.Substring(btn.Name.Length - 1, 1))).ToString();
            }
            imgTitle.BackgroundImage = generateDiscImage(discid, imgTitle);
        }

        private void txtPageNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter)
                scrlPage.Value = Convert.ToInt32(txtJump.Text);
        }

        private void numericTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length > 0)
            {
                int pos = txt.SelectionStart;
                if (txt.Name == "txtJump" && Convert.ToInt32(txtJump.Text) > max_pages)
                {
                    txt.Text = max_pages.ToString();
                    txt.Select(pos, 0);
                }

                Regex reg = new Regex("[^0-9]");
                txt.Text = reg.Replace(txt.Text, "");
                txt.Select(pos, 0);
            }
        }
    }
}
