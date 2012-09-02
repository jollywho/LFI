using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace LFI
{
    public partial class mainView : UserControl
    {
        DataTable dvTitles;
        DataView dvSearch;
        public contentsPane discPane;
        public editPane editPane;
        public infoPane infoPane;
        int[] cellHover = new int[2];
        int savedRow = 0;
        public bool enabled;
        private int scrollpos = 0;

        /// <summary>
        /// Load child Panes and components.
        /// </summary>
        public mainView() 
        {
            InitializeComponent();
            DoubleBuffered = true;
            populateList();
            infoPane = new infoPane();
            discPane = new contentsPane();
            editPane = new editPane();
            panelMain.Controls.Add(infoPane);
            panelMain.Controls.Add(discPane);
            panelMain.Controls.Add(editPane);
            infoPane.Enable();
            discPane.Disable();
        }

        /// <summary>
        /// Filter gridview while typing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                string filter = txtSearch.Text.Replace("'", "''");
                string[] pattern = filter.Split('*');
                dvSearch = new DataView(dvTitles);

                //filter = string.Format(@"title_id like '%{0}*%'", pattern[0].ToString());
                filter = string.Format(@"title_id like '%*{0}*%'", pattern[0].ToString());
                if (pattern.Count() > 0)
                {
                    for (int i = 1; i < pattern.Count(); i++)
                    {
                        filter += string.Format(@"and title_id like '%*{0}*%'", pattern[i]);
                    }
                }
                dvSearch.RowFilter = filter;
                savedRow = 0;
                gvTitles.DataSource = dvSearch;
            }
            else
                populateList();
        }
        
        /// <summary>
        /// Load Info Pane with data for selected gridview title.
        /// or
        /// Load Disc Pane with data for selected gridview title.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvTitles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTitles.SelectedCells.Count > 0)
            {
                if (gvTitles.SelectedCells[0].Value != null)
                {
                    savedRow = gvTitles.SelectedCells[0].RowIndex;
                    lblTitle.Text = gvTitles.SelectedCells[0].Value.ToString();
                    if (infoPane.active)
                    {
                        infoPane.load_data(DB_Handle.GetDataTable(string.Format(
                            @"SELECT * FROM titles WHERE title_id={0}",
                            "\"" + gvTitles.SelectedCells[0].Value.ToString() + "\"")));
                    }
                    else
                    {
                        discPane.load_data(gvTitles.SelectedCells[0].Value.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Keydown event for gridview:
        /// Delete - Force delete event for selected row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvTitles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);

            if (e.Control & (e.KeyCode == Keys.A))
            {
                txtSearch.Focus();
                txtSearch.SelectAll();
            }
        }

#region CONTEXT_MENU

        /// <summary>
        /// Sets correct positon for context menu when opened.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuDisc_Opened(object sender, EventArgs e)
        {
            if (gvTitles.Rows.Count > 0)
            {
                contextMenuDisc.Enabled = true;
                if (gvTitles[cellHover[1], cellHover[0]].Value != null)
                    gvTitles[cellHover[1], cellHover[0]].Selected = true;
            }
            else
                contextMenuDisc.Enabled = false;
        }
        /// <summary>
        /// Load Disc Pane and disable all others.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void discInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (infoPane.active)
            {
                discPane.Enable();
                infoPane.Disable();
                editPane.Disable();
                discPane.load_data(gvTitles.SelectedCells[0].Value.ToString());
            }
        }

        /// <summary>
        /// Load Info Pane and disable all others.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (discPane.active)
            {
                discPane.Disable();
                editPane.Disable();
                load_infoPane();
            }
        }

        /// <summary>
        /// Prompt to delete selected row:
        /// Yes - Deletes title and image then refreshes gridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = BetterDialog.ShowDialog("Delete Title?", "Are you sure you want to delete this title?",
                gvTitles.SelectedCells[0].Value.ToString(), "Yes", "No",
                Image_IO.getImage(gvTitles.SelectedCells[0].Value.ToString()), BetterDialog.ImageStyle.Image);
            if (dlg == DialogResult.OK)
            {
                int row = gvTitles.SelectedCells[0].RowIndex;
                DB_Handle.UpdateTable(string.Format(
                    @"DELETE FROM TITLES WHERE title_id={0}",
                    "\"" + gvTitles.SelectedCells[0].Value.ToString() + "\""));
                Image_IO.delete_Image(gvTitles.SelectedCells[0].Value.ToString());

                if (gvTitles.Rows.Count > 0 && row > 0)
                {
                    savedRow = row - 1;
                    gvTitles[0, row].Selected = true;
                }
                else
                    savedRow = 0;
                if (txtSearch.Text.Length != 0)
                    txtSearch_TextChanged(null, null);
                load_infoPane();
                
                gvTitles.Focus();
            }
        }
#endregion CONTEXT_MENU

        /// <summary>
        /// Mouse hover saves row-to-mouse position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvTitles_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            cellHover[0] = e.RowIndex;
            cellHover[1] = e.ColumnIndex;
        }

#region INTERFACE
        /// <summary>
        /// Set View to disabled and hide self.
        /// </summary>
        public void Disable()
        {
            this.Hide();
            enabled = false;
        }

        /// <summary>
        /// Set View to enabled and show self.
        /// Reselect last row selected in gridview.
        /// </summary>
        public void Enable()
        {
            enabled = true;
            this.Show();
            txtSearch_TextChanged(null, null);

            if (gvTitles.Rows.Count > 0)
                gvTitles.Rows[savedRow].Selected = true;
            txtSearch.Focus();
        }

        /// <summary>
        /// Populate gridview with titles.
        /// </summary>
        public void populateList()
        {
            dvTitles = DB_Handle.GetDataTable(string.Format(
                @"SELECT title_id 
                FROM titles WHERE language ='{0}' 
                ORDER BY title_id", MainForm.Lmode));
            gvTitles.DataSource = dvTitles;
        }

        /// <summary>
        /// Checks gridview row count.
        /// </summary>
        /// <returns>True if empty.</returns>
        public bool IsEmpty()
        {
            return gvTitles.Rows.Count < 1 ? true : false;
        }

        /// <summary>
        /// Force a gridview row enter event.
        /// </summary>
        public void Force_RowEnter()
        {
            gvTitles_RowEnter(null, null);
        }

        /// <summary>
        /// Public interface to load Info Pane.
        /// </summary>
        public void load_infoPane()
        {
            try
            {
                if (gvTitles.Rows.Count > 0)
                    scrollpos = gvTitles.FirstDisplayedScrollingRowIndex;
                infoPane.Enable();
                editPane.Disable();
                discPane.Disable();
                gvTitles.Enabled = true;
                txtSearch.Enabled = true;
                populateList();
                Enable();
                if (gvTitles.Rows.Count > 0)
                    gvTitles.FirstDisplayedScrollingRowIndex = scrollpos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Public interface to load Edit Pane.
        /// </summary>
        public void load_editPane()
        {
            discPane.Disable();
            infoPane.Disable();
            gvTitles.Enabled = false;
            txtSearch.Enabled = false;
            editPane.Clear_Fields();
            editPane.load_data(DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM titles WHERE title_id={0}",
                "\"" + gvTitles.SelectedCells[0].Value.ToString() + "\"")));
            editPane.Enable();
        }

        /// <summary>
        /// Public interface to load Edit Pane with blank record.
        /// </summary>
        public void load_blank_editPane()
        {
            discPane.Disable();
            infoPane.Disable();
            gvTitles.Enabled = false;
            txtSearch.Enabled = false;
            lblTitle.Text = string.Empty;
            editPane.Clear_Fields();
            editPane.Enable();
        }
#endregion INTERFACE

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void gvTitles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                txtSearch.Text += e.KeyChar;
                txtSearch.SelectionStart = txtSearch.Text.Length;
                txtSearch.Focus();
            }
        }
    }
}
