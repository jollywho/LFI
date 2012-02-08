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
        DataTable sel;
        DataView dv;

        public mainView(Panel parent) 
        {
            InitializeComponent();
            populateList();
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

        private void populateList()
        {
            dt = DB_Handle.GetDataTable("SELECT title_id FROM titles ORDER BY title_id");
            gvTitles.DataSource = dt;
        }
        
        //todo: strip illegal chars OR prevent from the start
        private void setImage(string str)
        {
            string path = Path.Combine(
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                string.Format("..\\..\\image\\{0}.jpg", str));

            if (System.IO.File.Exists(path))
            {
                imgTitle.ImageLocation = path;
            }
            else
            {
                imgTitle.ImageLocation = null;
            }
        }

        //todo: commit img
        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    imgTitle.ImageLocation = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gvTitles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvTitles.SelectedCells.Count > 0)
            {

                if (gvTitles.SelectedCells[0].Value != null)
                {
                    try
                    {
                        sel = DB_Handle.GetDataTable(string.Format(
                            @"SELECT * FROM titles WHERE title_id='{0}'",
                            gvTitles.SelectedCells[0].Value.ToString()));

                        txtTitle.Text = sel.Rows[0][0].ToString();
                        txtEpisode.Text = sel.Rows[0][1].ToString();
                        txtCategory.Text = sel.Rows[0][2].ToString();
                        txtYear.Text = sel.Rows[0][3].ToString();
                        txtStatus.Text = sel.Rows[0][4].ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    setImage(txtTitle.Text);
                }
            }
        }

        private void gvTitles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = gvTitles.HitTest(e.X, e.Y);
                gvTitles.ClearSelection();
                gvTitles.Rows[hti.RowIndex].Cells[0].Selected = true;
            }
        }

        private void contextMenuItemDisc_Click(object sender, EventArgs e)
        {
            //discView us = new discView(gvTitles.SelectedCells[0].Value.ToString());
            //this.Parent.Controls.Add(us);
            //this.Parent.Controls.Remove(this);
        }

        private void gvTitles_KeyDown(object sender, KeyEventArgs e)
        {
           // if (e.KeyCode == Keys.Enter)
                
        }
    


    }
}
