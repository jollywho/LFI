using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LFI
{
    class Image_IO
    {
        public static Image resize_Image(Image srcImage, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                return newImage;
            }
        }

        public static Image merge_Images(Image image1, Image image2, int newWidth, int newHeight)
        {
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics grfx = Graphics.FromImage(newImage))
            {
                grfx.DrawImage(image1, new Rectangle(0, 0, newWidth, newHeight / 2));

                grfx.DrawImage(image1, new Rectangle(0, newHeight / 2, newWidth, newHeight / 2));
                grfx.DrawLine(new Pen(Color.Black), 0, newHeight / 2, newWidth, newHeight / 2);
                return newImage;
            }
        }

        public static void setImage(string str, PictureBox bx)
        {
            string path = Path.Combine(
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                string.Format("image\\{0}.jpg", str));

            if (System.IO.File.Exists(path))
            {
                bx.ImageLocation = path;
            }
            else
            {
                bx.ImageLocation = null;
            }
        }
    }
}
