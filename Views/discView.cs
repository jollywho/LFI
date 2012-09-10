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
using System.IO;

namespace LFI
{
    public partial class discView : UserControl
    {
        private static Size IMG_SIZE = new Size(245, 345);
        private BackgroundWorker worker = new BackgroundWorker();
        public static bool AllowDiscEdit = true;
        public bool isNewRecord = false;
        const int DISCS_PER_PAGE = 4;
        const int PAGES_PER_VIEW = 2;
        private int max_pages = 0;
        private DataTable dtView;
        private int cur_page = 0;
        List<DButton> dbuttons = new List<DButton>();
        Control lastControlEntered;
        bool refreshRequired = false;
        private string selectRequiredID = string.Empty;

        public discView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            gvContents.AlternatingRowsDefaultCellStyle = null;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_Completed);

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

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            txtDisc.ReadOnly = AllowDiscEdit;
            loadView();
            foreach (Control c in panel1.Controls)
                c.Enter += new EventHandler(c_Enter);
            foreach (Control c in gbContents.Controls)
                c.Enter += new EventHandler(c_Enter);
        }

        /// <summary>
        /// Save active control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void c_Enter(object sender, EventArgs e)
        {
            if (sender is Control)
                lastControlEntered = (Control)sender;
        }

        public void Enable()
        {
            loadPage();
            DataTable titles = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles order by title_id"));
            ddInsTitle.DataSource = titles;
            ddInsTitle.DisplayMember = "title_id";
            ddInsTitle.Text = "";
            if (lastControlEntered != null)
                lastControlEntered.Focus();
        }
        
        /// <summary>
        /// Force focus off dropdown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddLocation_OnMouseWheel(object sender, MouseEventArgs e)
        {
            ComboBox bx = (ComboBox)sender;
            if (!bx.DroppedDown)
                ((HandledMouseEventArgs)e).Handled = true;
        }

        /// <summary>
        /// Custom event handler to move visible page during mousewheel.
        /// </summary>
        /// <remarks>Moves 2 pages at a time (1 if half page).</remarks>
        /// <param name="e"></param>
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (e.Delta > 0)
                txtJump.Text = findNextJump(-2).ToString();
            else
                txtJump.Text = findNextJump(2).ToString();
            loadPage();
        }

        /// <summary>
        /// Loads max pages for active location and sets scroll limit.
        /// </summary>
        private void loadView()
        {
            dtView = DB_Handle.GetDataTable(string.Format(@"select max_storage from locations
                where location_id='{0}'", ddLocation.Text));
            max_pages = Convert.ToInt32(dtView.Rows[0][0].ToString()) / DISCS_PER_PAGE;
            scrlPage.Maximum = max_pages + scrlPage.LargeChange-1;
            DButton.Location_ID = ddLocation.Text;
            txtJump.Text = "1";
            loadPage();
        }

        /// <summary>
        /// Finds next even page.
        /// </summary>
        /// <returns>Always even.</returns>
        private int jumpPage()
        {
            int pg = Convert.ToInt32(txtJump.Text);
            if (pg % 2 != 0)
                pg = Convert.ToInt32(txtJump.Text) - 1;
            lblPageLeft.Text = pg.ToString();
            lblPageRight.Text = (pg + 1).ToString();
            return pg;
        }

        /// <summary>
        /// Finds next page.
        /// </summary>
        /// <param name="pg"></param>
        /// <returns></returns>
        private int findNextJump(int pg)
        {
            int jmp = Convert.ToInt32(txtJump.Text);
            if (jmp % 2 != 0)
                jmp--;
            jmp = jmp + pg;
            return jmp < 1 ? 1 : jmp;
        }

        /// <summary>
        /// Loads info to dbuttons based on page and slot
        /// </summary>
        public void loadPage()
        {
            cur_page = jumpPage();
            hidePage(1, true, 2);
            if (cur_page == 0)
                hidePage(1, false);
            else if (cur_page == max_pages)
                hidePage(DISCS_PER_PAGE + 1, false);

            if (!worker.IsBusy)
                worker.RunWorkerAsync(cur_page);
            else
            {
                refreshRequired = true;
                Console.WriteLine("Cancel");
            }
        }

        /// <summary>
        /// Hides front or end page of binder.
        /// </summary>
        /// <param name="start">the start as integer</param>
        /// <param name="vis">visibility as boolean</param>
        /// <param name="all">show all as integer (default 1)</param>
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

        /// <summary>
        /// Start image worker and listens for cancel requests.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = (int)e.Argument;
            int slot = 1;
            for (int i = 0; i <= PAGES_PER_VIEW * DISCS_PER_PAGE - 1; i++, slot++)
            {
                if (slot > DISCS_PER_PAGE)
                {
                    page++;
                    slot = 1;
                }
                dbuttons[i].UnClick();
                dbuttons[i].load(page);
            }
        }

        /// <summary>
        /// Starts again if worker was asked to stop while working.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (refreshRequired)
            {
                Console.WriteLine("Continue");
                worker.RunWorkerAsync(cur_page);
                refreshRequired = false;
            }
            if (selectRequiredID != string.Empty)
            {
                foreach (DButton btn in dbuttons)
                {
                    if (btn.Disc == selectRequiredID)
                    {
                        btn.DButton_Click(null, null);
                        selectRequiredID = string.Empty;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Suppress ENTER key event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
        }

        /// <summary>
        /// Inserts title information to gridview if valid.
        /// Clears previous fields on success.
        /// Displays error tip on failure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                    txtSeason.Text = "1";
                    ddInsTitle.Text = "";
                    txtRangeStart.Clear();
                    txtRangeEnd.Clear();
                }
            }
            else
                Error_Handle.TipError("Invalid title\n", toolTip, ddInsTitle);
        }

        /// <summary>
        /// Removes selected title row from gridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gvContents.Rows.Count > 0)
            {
                DialogResult result = BetterDialog.ShowDialog("Remove Record?",
                    "Record will be deleted permanently.  Are you sure?",
                    string.Format("{0}\nSeason {1}\nStart {2}\nEnd {3}",
                    gvContents.SelectedCells[0].Value, gvContents.SelectedCells[1].Value,
                    gvContents.SelectedCells[2].Value, gvContents.SelectedCells[3].Value),
                    "Yes", "No", Image_IO.getImage(gvContents.SelectedCells[0].Value.ToString()),
                    BetterDialog.ImageStyle.Image);
                if (result == DialogResult.OK)
                {
                    if (gvContents.Rows[gvContents.SelectedCells[0].RowIndex].Cells[4].ToString() != "null")
                    {
                        DB_Handle.UpdateTable(string.Format(
                            @"DELETE FROM CONTENTS WHERE
                            content_id = '{0}'",
                            gvContents.Rows[gvContents.SelectedCells[0].RowIndex].Cells[4].Value));
                    }
                    gvContents.Rows.Remove(gvContents.Rows[gvContents.SelectedCells[0].RowIndex]);
                    loadPage();
                    DButton.SelBtn.DButton_Click(null, null);
                }
            }
        }

        /// <summary>
        /// Attempts to save selected disc and each of its content rows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            txtDisc.Text, 
                            ddLocation.Text));
                    }
                    BetterDialog.ShowDialog("Disc Save", "Success", "", "", "OK", null, BetterDialog.ImageStyle.Icon);
                }
                catch (Exception ex)
                {
                    if (rollbackpos)
                        DB_Handle.UpdateTable(string.Format(
                            @"DELETE FROM DISCS WHERE
                            disc_id = '{0}' AND location_id = '{1}'",
                            txtDisc.Text, ddLocation.Text));
                    BetterDialog.ShowDialog("Disc Save", "Error : " + ex.Message, "", "", "OK", null, BetterDialog.ImageStyle.Icon);
                }
                finally
                {
                    DB_Handle.CloseConnection();
                    DButton.SelBtn.DButton_Click(null, null);
                    loadPage();
                }
            }
        }

        /// <summary>
        /// Generates the next available disc_id from discs table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                BetterDialog.ShowDialog("DiscID Generation", "Error : " + ex.Message, "", "", "OK", null, BetterDialog.ImageStyle.Icon);
            }
        }

        /// <summary>
        /// Clears disc_id field if dropdown location changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDisc.Clear();
        }

        /// <summary>
        /// Reloads Disc View if dropdown location changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            gvContents.Rows.Clear();
            loadView();
        }

        /// <summary>
        /// Loads new page with scrollbar change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scrlPage_ValueChanged(object sender, EventArgs e)
        {
            txtJump.Text = scrlPage.Value.ToString();
            loadPage();
        }

        private void txtPageNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = true;
            if (e.KeyCode == Keys.Enter)
            {
                scrlPage.Value = Convert.ToInt32(txtJump.Text);
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        ///     Prevent zero values.
        ///     Prevent higher values than max pages.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == string.Empty) txt.Text = "0";
            if (txt.Text == "0") txt.Text = "1";
            if (txt.Text.Length > 0)
            {
                if (Convert.ToInt32(txtJump.Text) > max_pages)
                {
                    txt.Text = max_pages.ToString();
                    txt.Select(0, 0);
                }
                scrlPage.Value = Convert.ToInt32(txtJump.Text);
            }
        }

        #region INTERFACE
        /// <summary>
        /// Tell dbuttons to unselect.
        /// </summary>
        public void popContentPane()
        {
            gvContents.Rows.Clear();
            for (int i = 0; i <= (PAGES_PER_VIEW * DISCS_PER_PAGE) - 1; i++)
            {
                dbuttons[i].UnClick();
            }
            panel1.Focus();
            Error_Handle.Clear(toolTip);
        }

        /// <summary>
        /// Turn ImageDrop On/Off for imgTitle.
        /// </summary>
        /// <param name="val">Enable value.</param>
        public void allowDbuttonDrop(bool val)
        {
            imgTitle.AllowDrop = val;
        }

        public DataGridView getContentsGrid()
        {
            return gvContents;
        }

        public void setImagebox(Image img)
        {
            imgTitle.Image = img;
        }

        public Control getImagebox()
        {
            return imgTitle;
        }

        public void LoadFinder()
        {
            if (DiscFinderDialog.ShowDialog(ddLocation.Text) == DialogResult.OK)
            {
                ddLocation.Text = DiscFinderDialog.Location;
                txtJump.Text = DiscFinderDialog.Page;
                selectRequiredID = DiscFinderDialog.Disc;
                //check if disc is on current page
                foreach (DButton btn in dbuttons)
                {
                    if (btn.Disc == selectRequiredID)
                    {
                        btn.DButton_Click(null, null);
                        selectRequiredID = string.Empty;
                        return;
                    }
                }
            }
        }

        public void OpenAt(string locationID, string pageID, string discID)
        {
            ddLocation.Text = locationID;
            txtJump.Text = pageID;
            selectRequiredID = discID;
        }

        /// <summary>
        /// Sets selected information.
        /// </summary>
        /// <param name="disc">disc_id.</param>
        /// <param name="page">page_number.</param>
        /// <param name="slot">slot_number.</param>
        public void setData(object disc, object page, object slot)
        {
            txtDisc.Text = disc.ToString();
            txtPage.Text = page.ToString();
            txtSlot.Text = slot.ToString();
        }

        public void SwapDiscIDMode(bool check)
        {
            txtDisc.ReadOnly = check;
            AllowDiscEdit = check;
        }
        #endregion INTERFACE

        public void scrlPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
                txtJump.Text = findNextJump(-2).ToString();
            if (e.KeyCode == Keys.PageDown)
                txtJump.Text = findNextJump(2).ToString();
            if (e.KeyCode == Keys.Home)
                txtJump.Text = "1";
            if (e.KeyCode == Keys.End)
                txtJump.Text = max_pages.ToString();
            e.Handled = true;
        }

        private void imgTitle_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Save dragged image with selected gridview row title.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgTitle_DragDrop(object sender, DragEventArgs e)
        {
            if (gvContents.Rows.Count > 0)
            {
                try
                {
                    int x = this.PointToClient(new Point(e.X, e.Y)).X;

                    int y = this.PointToClient(new Point(e.X, e.Y)).Y;

                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    FileStream fs = new FileStream(files[0], FileMode.Open);
                    Image img = Image.FromStream(fs);
                    fs.Close();
                    img = Image_IO.resize_Image(img, IMG_SIZE.Width, IMG_SIZE.Height);
                    img.Save(
                        string.Format("{0}\\{1}.jpg",
                        Folder_IO.GetUserImagePath(), 
                        gvContents.SelectedRows[0].Cells[0].Value),
                        System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgTitle.Image = img;
                }
                catch (Exception ex)
                {
                    toolTip.Show(ex.Message, imgTitle);
                }
            }
            Enable();
            ParentForm.Activate();
            DButton.SelBtn.DButton_Click(null, null);
        }

        private void contextMenuImg_Opening(object sender, CancelEventArgs e)
        {
            Image img = Clipboard.GetImage();
            if (img == null)
            {
                e.Cancel = true;
                return;
            }

            pasteToolStripMenuItem.Image = Image_IO.resize_Image(img, imgTitle.Width, imgTitle.Height);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = Clipboard.GetImage();
            if (img != null)
            {
                if (gvContents.Rows.Count < 1)
                {
                    toolTip.Show("Title Required!", ddInsTitle);
                }
                else
                {
                    DialogResult result = DialogResult.OK;
                    if (imgTitle.Image != LFI.Properties.Resources.border)
                    {
                        result = BetterDialog.ShowDialog("Change Image", "Are you sure you want to overwrite this image?",
                            "", "Yes", "No", imgTitle.Image, BetterDialog.ImageStyle.Image);
                    }
                    if (result == DialogResult.OK)
                    {
                        img = Image_IO.resize_Image(img, imgTitle.Width, imgTitle.Height);
                        img.Save(string.Format("{0}\\{1}.jpg", Folder_IO.GetUserImagePath(), gvContents.SelectedRows[0].Cells[0].Value),
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgTitle.Image = img;
                    }
                }
            }
        }
    }
}
