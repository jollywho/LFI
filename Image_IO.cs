using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data;

namespace LFI
{
    class Image_IO
    {

        public static Image createMergedImage(List<string> titleStrs, Control btn)
        {
            List<Image> imgLst = new List<Image>();
            string path = Folder_IO.GetUserDataPath();
            for (int i = 0; i <= titleStrs.Count - 1; i++)
            {
                if (System.IO.File.Exists(path + string.Format("\\{0}.jpg", titleStrs[i])))
                {
                    FileStream fs = new FileStream(path + string.Format("\\{0}.jpg", titleStrs[i]), FileMode.Open);
                    Image img = Image.FromStream(fs);
                    fs.Close();
                    imgLst.Add(resize_Image(img, btn.Width, btn.Height / titleStrs.Count));
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
            string path = Folder_IO.GetUserDataPath() + string.Format("\\{0}.jpg", str);

            if (System.IO.File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                bx.Image = img;
            }
            else
            {
                bx.Image = null;
            }
        }

        public static Image generateDiscImage(string discid, string locationid,  Control btn)
        {
            Image img = LFI.Properties.Resources.border;
            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM contents JOIN disc_contents on contents.content_id =
                disc_contents.content_id WHERE disc_id='{0}' and location_id='{1}';",
                discid, locationid));

            if (temp.Rows.Count > 0)
            {
                List<string> disc_titles = new List<string>();
                if (temp.Rows.Count > 0)
                {
                    for (int i = 0; i <= temp.Rows.Count - 1; i++)
                    {
                        disc_titles.Add(temp.Rows[i][1].ToString());
                    }
                }
                img = Image_IO.createMergedImage(disc_titles, btn);
            }
            return img;
        }
    }
}
