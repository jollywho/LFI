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
    public partial class infoPane : UserControl
    {
        public bool active = false;
        public infoPane()
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

        public void load_data(DataTable sel)
        {
            try
            {
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

        //todo: strip illegal chars OR prevent from the start
        private void setImage(string str)
        {
            string path = Path.Combine(
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                string.Format("image\\{0}.jpg", str));

            if (System.IO.File.Exists(path))
            {
                imgTitle.ImageLocation = path;
            }
            else
            {
                imgTitle.ImageLocation = null;
            }
        }
    }
}
