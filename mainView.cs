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
        DataTable loc;
        DataView dv;

        public mainView()
        {
            InitializeComponent();
            populateList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                dv = new DataView(dt);
                dv.RowFilter = string.Format("title like '%{0}*'", txtSearch.Text);
                
                gvTitles.DataSource = dv;

            }
            else
                populateList();
        }

        private void populateList()
        {
            dt = DB_Handle.GetDataTable("SELECT title FROM main ORDER BY title");
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
                ddLocation.Items.Clear();
                sel = DB_Handle.GetDataTable(string.Format(
                        @"SELECT * FROM main WHERE title='{0}' ORDER BY title",
                        gvTitles.SelectedCells[0].Value.ToString()));

                txtTitle.Text = sel.Rows[0][0].ToString();
                txtEpisode.Text = sel.Rows[0][1].ToString();
                txtCategory.Text = sel.Rows[0][2].ToString();
                txtYear.Text = sel.Rows[0][3].ToString();
                txtStatus.Text = sel.Rows[0][4].ToString();

                loc = DB_Handle.GetDataTable(string.Format(
                    @"SELECT location FROM loc where main_title='{0}'",
                    gvTitles.SelectedCells[0].Value.ToString()));
                for (int i = 0; i <= loc.Rows.Count - 1; i++)
                {
                    ddLocation.Items.Add(loc.Rows[i][0]);
                }
                ddLocation.SelectedIndex = ddLocation.Items.Count - 1;

                setImage(txtTitle.Text);
            }

        }


    }
}
