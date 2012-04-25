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
    public partial class editPane : UserControl
    {
        public bool active = false;
        public editPane()
        {
            InitializeComponent();
        }

        public void disable()
        {
            active = false;
            this.Hide();
        }

        public void enable()
        {
            active = true;
            this.Show();
        }

        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
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

        public void load_data(DataTable sel)
        {
            DataTable titles = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles order by title_id"));
                ddTitle.DataSource = titles;
                ddTitle.DisplayMember = "title_id";
            try
            {
                ddTitle.Text = sel.Rows[0][0].ToString();
                txtEpisode.Text = sel.Rows[0][1].ToString();
                ddCategory.Text = sel.Rows[0][2].ToString();
                txtYear.Text = sel.Rows[0][3].ToString();
                ddStatus.Text = sel.Rows[0][4].ToString();
                ddLanguage.Text = sel.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            setImage(ddTitle.Text);
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

        public bool saveData()
        {
            string error = "";
            bool status = false;
            try
            {
                if (ddTitle.Text.Length == 0)
                    error += "Title required or too short\n";
                if (ddTitle.Text.Contains(','))
                    error += "Illegal Char in title";
                if (ddTitle.FindStringExact(ddTitle.Text) != ddTitle.SelectedIndex)
                    error += "Title already exists\n";
                if (ddCategory.Text.Length == 0)
                    error += "Category required\n";
                if (ddStatus.Text.Length < 3)
                    error += "Status required\n";
                if (ddLanguage.Text.Length < 1)
                    error += "Language required\n";
                if (txtYear.Text.Length < 4)
                    error += "Year required\n";
                if (txtEpisode.Text.Length < 3)
                    error += "Episode # required\n";

                if (error.Length != 0)
                {
                    MessageBox.Show(error, "Validation Error");
                }
                else
                {
                    //add
                    DB_Handle.UpdateTable(string.Format(
                        @"INSERT OR REPLACE INTO TITLES
                        (title_id, episodes, category, year, status, language)
                        VALUES ('{0}','{1:000}','{2}','{3}','{4}','{5}');",
                        ddTitle.Text, txtEpisode.Text, ddCategory.Text,
                        txtYear.Text, ddStatus.Text, ddLanguage.Text));
                    MessageBox.Show("Saved", "Success");
                    status = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return status;
        }
    }
}
