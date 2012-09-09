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
            SetStyle(ControlStyles.Selectable, false);
            UpdateStyles();
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
                lblTitle.Text = sel.Rows[0][0].ToString();
                lblEpisode.Text = sel.Rows[0][1].ToString();
                lblCategory.Text = sel.Rows[0][2].ToString();
                lblYear.Text = sel.Rows[0][3].ToString();
                lblStatus.Text = sel.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {
                BetterDialog.ShowDialog("Load Error", "Error : " + ex.Message, "", "", "OK", null, BetterDialog.ImageStyle.Icon);
            }

            setImage(lblTitle.Text);
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

        /// <summary>
        /// Save, resize, and format dragged image with lblTitle filename.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoPane_DragDrop(object sender, DragEventArgs e)
        {
            if (lblTitle.Text.Length < 1)
            {
                BetterDialog.ShowDialog("Image Save", "Error : Title Required", "", "", "OK", null, BetterDialog.ImageStyle.Icon);
            }
            else
            {
                try
                {
                    int x = this.PointToClient(new Point(e.X, e.Y)).X;

                    int y = this.PointToClient(new Point(e.X, e.Y)).Y;

                    //inside imgTitle boundaries
                    if (x >= imgTitle.Location.X && x <= imgTitle.Location.X + imgTitle.Width
                        && y >= imgTitle.Location.Y && y <= imgTitle.Location.Y + imgTitle.Height)
                    {

                        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                        FileStream fs = new FileStream(files[0], FileMode.Open);
                        Image img = Image.FromStream(fs);
                        fs.Close();
                        img = Image_IO.resize_Image(img, imgTitle.Width, imgTitle.Height);
                        img.Save(string.Format("{0}\\{1}.jpg", Folder_IO.GetUserImagePath(), lblTitle.Text),
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgTitle.Image = img;
                    }
                }
                catch (Exception ex)
                {
                    BetterDialog.ShowDialog("Image Save", "Error : " + ex.Message, "", "", "OK", null, BetterDialog.ImageStyle.Icon);
                }
            }
            ParentForm.Activate();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                Graphics g = e.Graphics;
                Rectangle r = e.CellBounds;
                SolidBrush br = new SolidBrush(Color.FromArgb(240, 52, 57, 77));
                g.FillRectangle(br, r);
            }
            if (e.Row != 0)
            {
                Graphics ge = e.Graphics;
                ge.DrawLine(new Pen(Brushes.Gray, 1), e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Top);
            }
        }
    }
}
