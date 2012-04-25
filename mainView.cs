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
        DataTable dt;
        DataView dv;
        discPane discPane;
        infoPane infoPane;

        public mainView() 
        {
            InitializeComponent();
            populateList();
            infoPane = new infoPane();
            discPane = new discPane();
            panelMain.Controls.Add(infoPane);
            panelMain.Controls.Add(discPane);
            infoPane.enable();
            discPane.disable();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                dv = new DataView(dt);
                dv.RowFilter = string.Format("title_id like '%{0}*'", txtSearch.Text);
                
                gvTitles.DataSource = dv;

            }
            else
                populateList();
        }

        public void populateList()
        {
            dt = DB_Handle.GetDataTable(string.Format(
                @"SELECT title_id 
                FROM titles WHERE language ='{0}' 
                ORDER BY title_id", MainForm.Lmode));
            gvTitles.DataSource = dt;
        }
        
        private void gvTitles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTitles.SelectedCells.Count > 0)
            {
                if (gvTitles.SelectedCells[0].Value != null)
                {
                    lblTitle.Text = gvTitles.SelectedCells[0].Value.ToString();
                    if (infoPane.active)
                    {
                        infoPane.load_data(DB_Handle.GetDataTable(string.Format(
                            @"SELECT * FROM titles WHERE title_id='{0}'",
                            gvTitles.SelectedCells[0].Value.ToString())));
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
                discPane.enable();
                infoPane.disable();
                discPane.load_data(gvTitles.SelectedCells[0].Value.ToString());
            }
        }

        private void gvTitles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contextMenuItemDisc_Click(sender, e);
        }

        private void titleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (discPane.active)
            {
                discPane.disable();
                infoPane.enable();
            }
        }
    }
}
