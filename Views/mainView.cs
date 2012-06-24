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

        public void Disable() 
        {
            this.Hide();
            enabled = false; 
        }

        public void Enable()
        {
            enabled = true;
            this.Show();
            txtSearch_TextChanged(null, null);
            
            if (gvTitles.Rows.Count > 0)
                gvTitles.Rows[savedRow].Selected = true;
            gvTitles.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                dvSearch = new DataView(dvTitles);
                dvSearch.RowFilter = string.Format(@"title_id like '%{0}*'",
                    txtSearch.Text.Replace("'", "''"));
                
                gvTitles.DataSource = dvSearch;
            }
            else
                populateList();
        }

        public void populateList()
        {
            dvTitles = DB_Handle.GetDataTable(string.Format(
                @"SELECT title_id 
                FROM titles WHERE language ='{0}' 
                ORDER BY title_id", MainForm.Lmode));
            gvTitles.DataSource = dvTitles; 
        }

        public bool IsEmpty()
        {
            if (gvTitles.Rows.Count < 1)
                return true;
            else
                return false;
        }

        public void Force_RowEnter()
        {
            gvTitles_RowEnter(null, null);
        }
        
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

        private void contextMenuItemDisc_Click(object sender, EventArgs e)
        {
            if (infoPane.active)
            {
                discPane.Enable();
                infoPane.Disable();
                editPane.Disable();
                discPane.load_data(gvTitles.SelectedCells[0].Value.ToString());
            }
        }

        private void gvTitles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);
        }

        private void titleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (discPane.active)
            {
                discPane.Disable();
                editPane.Disable();
                load_infoPane();
            }
        }

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

        public void load_editPane()
        {
            discPane.Disable();
            infoPane.Disable();
            gvTitles.Enabled = false;
            txtSearch.Enabled = false;
            editPane.load_data(DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM titles WHERE title_id={0}",
                "\"" + gvTitles.SelectedCells[0].Value.ToString() + "\"")));
            editPane.Enable();
        }

        public void load_blank_editPane()
        {
            discPane.Disable();
            infoPane.Disable();
            gvTitles.Enabled = false;
            txtSearch.Enabled = false;
            editPane.Clear_Fields();
            editPane.Enable();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                int row = gvTitles.SelectedCells[0].RowIndex;
                DB_Handle.UpdateTable(string.Format(
                    @"DELETE FROM TITLES WHERE title_id={0}",
                    "\"" + gvTitles.SelectedCells[0].Value.ToString() + "\""));
                Image_IO.delete_Image(gvTitles.SelectedCells[0].Value.ToString());
                savedRow = row--;
                if (gvTitles.Rows.Count > 0)
                    gvTitles[0, row].Selected = true;
                if (txtSearch.Text.Length != 0)
                    txtSearch_TextChanged(null, null);
                load_infoPane();
                
                gvTitles.Focus();
            }
        }

        private void gvTitles_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            cellHover[0] = e.RowIndex;
            cellHover[1] = e.ColumnIndex;
        }

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
    }
}
