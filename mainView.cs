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

        public mainView()
        {
            InitializeComponent();
            populateList();
        }

        private void listTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddLocation.Items.Clear();
            if (listTitles.SelectedItem != null)
            {
                sel = DB_Handle.GetDataTable(string.Format(
                        @"SELECT * FROM main WHERE title='{0}' ORDER BY title",
                        listTitles.SelectedItem.ToString()));
                txtTitle.Text = sel.Rows[0][0].ToString();
                txtEpisode.Text = sel.Rows[0][1].ToString();
                txtCategory.Text = sel.Rows[0][2].ToString();
                txtYear.Text = sel.Rows[0][3].ToString();
                txtStatus.Text = sel.Rows[0][4].ToString();

                loc = DB_Handle.GetDataTable(string.Format(
                    @"SELECT location FROM loc where main_title='{0}'",
                    listTitles.SelectedItem.ToString()));
                for (int i=0; i <= loc.Rows.Count - 1; i++)
                {
                    ddLocation.Items.Add(loc.Rows[i][0]);
                }
                ddLocation.SelectedIndex = ddLocation.Items.Count - 1;

                setImage(txtTitle.Text);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listTitles.Items.Clear();
            if (txtSearch.Text.Length > 0)
            {
                DataRow[] result = dt.Select(string.Format("title like '%{0}*'", txtSearch.Text));
                foreach (DataRow data in result)
                {
                    listTitles.Items.Add(data[0]);
                }
            }
            else
                populateList();
        }

        private void populateList()
        {
            dt = DB_Handle.GetDataTable("SELECT * FROM main ORDER BY title");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listTitles.Items.Add(dt.Rows[i][0]);
            }
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



    }
}
