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
        public bool isNewRecord = false;
        const int DISCS_PER_PAGE = 4;
        const int PAGES_PER_VIEW = 2;
        private int max_pages = 0;
        private DataTable dtView;
        List<DButton> dbuttons = new List<DButton>();

        public discView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);

            for (int i = 0, slot = 1; i <= (PAGES_PER_VIEW * DISCS_PER_PAGE) - 1; i++, slot++)
            {
                if (slot > DISCS_PER_PAGE)
                    slot = 1;
                dbuttons.Add(new DButton(slot, copyLabel,
                    Controls["btn" + (i + 1)].Location, this));
                Controls.Add(dbuttons[i]);
                Controls.Add(dbuttons[i].vlbl);
            }

            DataTable locations = DB_Handle.GetDataTable(string.Format(
                @"Select location_id from locations order by location_id"));
            ddLocation.DisplayMember = "location_id";
            ddLocation.DataSource = locations;
            
            DataTable titles = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles order by title_id"));
            ddInsTitle.DataSource = titles;
            ddInsTitle.DisplayMember = "title_id";

            loadView();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            scrlPage.Focus();
            if (e.Delta < 0)
                txtJump.Text = (Convert.ToInt32(txtJump.Text) + 1).ToString();
            else
                txtJump.Text = (Convert.ToInt32(txtJump.Text) - 1).ToString();
        }

        private void loadView()
        {
            dtView = DB_Handle.GetDataTable(string.Format(@"select max_storage from locations
                where location_id='{0}'", ddLocation.Text));
            max_pages = Convert.ToInt32(dtView.Rows[0][0].ToString());
            scrlPage.Maximum = max_pages + scrlPage.LargeChange-1;
            DButton.Location_ID = ddLocation.Text;
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

        public void loadPage()
        {
            int page = jumpPage();

            hidePage(1, true, 2);
            if (page == 0)
                hidePage(1, false);
            else if (page == max_pages)
                hidePage(DISCS_PER_PAGE + 1, false);

            int slot = 1;
            for (int i = 0; i <= PAGES_PER_VIEW * DISCS_PER_PAGE - 1; i++, slot++)
            {
                if (slot > DISCS_PER_PAGE)
                {
                    page++;
                    slot = 1;
                }
                dbuttons[i].load(page);
            }

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
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
                dbuttons[i - 1].setVisibility(vis);
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 0; i <= PAGES_PER_VIEW * DISCS_PER_PAGE - 1; i++)
            {
                dbuttons[i].BackgroundImage = Image_IO.generateDiscImage(
                    dbuttons[i].Disc, DButton.Location_ID,  dbuttons[i]);
            }
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
            {
                if (MessageBox.Show(this, "Remove record?", "Record will be deleted",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (gvContents.Rows[gvContents.SelectedCells[0].RowIndex].Cells[4].ToString() != "null")
                    {
                        DB_Handle.UpdateTable(string.Format(
                            @"DELETE FROM CONTENTS WHERE
                            content_id = '{0}'",
                            gvContents.Rows[gvContents.SelectedCells[0].RowIndex].Cells[4].Value));
                    }
                    gvContents.Rows.Remove(gvContents.Rows[gvContents.SelectedCells[0].RowIndex]);
                }
            }
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

        private void ddLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            gvContents.Rows.Clear();
            loadView();
        }

        private void scrlPage_Scroll(object sender, ScrollEventArgs e)
        {
            txtJump.Text = e.NewValue.ToString();
            loadPage();
        }

        private void scrlPage_ValueChanged(object sender, EventArgs e)
        {
            loadPage();
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

        #region INTERFACE
        public void popContentPane()
        {
            panel1.Enabled = true;
            gvContents.Rows.Clear();
        }

        public DataGridView getContentsGrid()
        {
            return gvContents;
        }

        public List<string> getSelData()
        {
            return new List<string>() {txtDisc.Text, txtPage.Text,  txtSlot.Text};
        }

        public void setImagebox(Image img)
        {
            imgTitle.BackgroundImage = img;
        }

        public void setData(object disc, object page, object slot)
        {
            txtDisc.Text = disc.ToString();
            txtPage.Text = page.ToString();
            txtSlot.Text = slot.ToString();
        }
        #endregion INTERFACE
    }
}
