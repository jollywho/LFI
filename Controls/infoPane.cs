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

        public void Disable()
        {
            active = false;
            this.Hide();
        }

        public void Enable()
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

        /// <summary>
        /// Checks for existing image and loads it from stream to imgTitle.
        /// </summary>
        /// <param name="str">title_id</param>
        private void setImage(string str)
        {
            string path = Folder_IO.GetUserImagePath() + string.Format("\\{0}.jpg", str);

            if (System.IO.File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                imgTitle.Image = img;
            }
            else
            {
                imgTitle.Image = LFI.Properties.Resources.notavailable;
            }
        }

        private void infoPane_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void infoPane_DragDrop(object sender, DragEventArgs e)
        {
            if (txtTitle.Text.Length < 1)
            {
                MessageBox.Show("Title Required!");
            }
            else
            {
                try
                {
                    int x = this.PointToClient(new Point(e.X, e.Y)).X;

                    int y = this.PointToClient(new Point(e.X, e.Y)).Y;

                    if (x >= imgTitle.Location.X && x <= imgTitle.Location.X + imgTitle.Width
                        && y >= imgTitle.Location.Y && y <= imgTitle.Location.Y + imgTitle.Height)
                    {

                        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                        FileStream fs = new FileStream(files[0], FileMode.Open);
                        Image img = Image.FromStream(fs);
                        fs.Close();
                        img = Image_IO.resize_Image(img, imgTitle.Width, imgTitle.Height);
                        img.Save(string.Format("{0}\\{1}.jpg", Folder_IO.GetUserImagePath(), txtTitle.Text),
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgTitle.Image = img;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ParentForm.Activate();
        }
    }
}
