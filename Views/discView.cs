using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LFI
{
    public partial class discView : UserControl
    {
        public discView()
        {
            InitializeComponent();

            Image image = ResizeImage("..\\..\\image\\Air TV.jpg", ImageFormat.Jpeg, 0);
            Image newimage = Image.FromFile("..\\..\\image\\Air TV.jpg");
            using (Graphics grfx = Graphics.FromImage(image))
            {
                //grfx.DrawImage(newimage, newimage.Width / 2, newimage.Height / 2);
            }
            //btn1.Image = image;

            Controls.Add(createVertLabel(btn1, copyLabel, "a001"));
            Controls.Add(createVertLabel(btn2, copyLabel, "a002"));
            Controls.Add(createVertLabel(btn3, copyLabel, "a003"));
            Controls.Add(createVertLabel(btn4, copyLabel, "a004"));

            Controls.Add(createVertLabel(btn5, copyLabel, "a005"));
            Controls.Add(createVertLabel(btn6, copyLabel, "a006"));
            Controls.Add(createVertLabel(btn7, copyLabel, "a007"));
            Controls.Add(createVertLabel(btn8, copyLabel, "a008"));
        }

        private VLabel createVertLabel(Button btn, Label copylabel, string text)
        {
            VLabel lbl = new VLabel();
            lbl.Text = text;
            lbl.Font = copylabel.Font;
            lbl.ForeColor = copylabel.ForeColor;
            lbl.Size = new System.Drawing.Size(18, btn.Height);
            Point point = btn.Location;
            point.X -= lbl.Size.Width;
            lbl.Location = point;
            return lbl;
        }


        public Image ResizeImage(string fileName,
            ImageFormat format, int percent)
        {
            try
            {
                Image thumbNail;
                using (Image img = Image.FromFile(fileName))
                {
                    int width = 150;
                    int height = 150;
                    thumbNail = new Bitmap(width, height, img.PixelFormat);
                    Graphics g = Graphics.FromImage(thumbNail);
                    Rectangle rect = new Rectangle(0, 0, width, height);
                    g.DrawImage(img, rect);
                    //thumbNail.Save(imgFileName, format);
                }
                return thumbNail;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //setImage(ddInsTitle.Text);
            //setImage("Air TV");
            if (btn.FlatAppearance.BorderColor == Color.Red)
            {
                btn.FlatAppearance.BorderColor = Color.Silver;
            }
            else
            {
                btn.FlatAppearance.BorderColor = Color.Red;
            }
        }

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
    }
}
