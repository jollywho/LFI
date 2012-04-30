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

        public static Image createMergedImage(List<string> titleStrs, Control btn)
        {
            List<Image> imgLst = new List<Image>();
            for (int i = 0; i <= titleStrs.Count - 1; i++)
            {
                if (System.IO.File.Exists(string.Format("image\\{0}.jpg", titleStrs[i])))
                {
                    imgLst.Add(resize_Image(Image.FromFile(string.Format("image\\{0}.jpg",
                        titleStrs[i])), btn.Width, btn.Height / titleStrs.Count));
                }
                else
                    imgLst.Add(resize_Image(LFI.Properties.Resources.notavailable,
                        btn.Width, btn.Height / titleStrs.Count));
            }
            Image finalImage = merge_Images(imgLst, btn.Width, btn.Height, titleStrs.Count);
            return finalImage;
        }


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

        public static Image merge_Images(List<Image> imgLst, int newWidth, int newHeight, int items)
        {
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics grfx = Graphics.FromImage(newImage))
            {
                for (int i = 0; i <= imgLst.Count - 1; i++)
                {
                    grfx.DrawImage(imgLst[i], new Rectangle(0, (newHeight / items) * i, newWidth, newHeight / items));
                    if (i > 0 && i != imgLst.Count)
                        grfx.DrawLine(new Pen(Color.Black), 0, (newHeight / items) * i, newWidth, (newHeight / items) * i);
                }
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
