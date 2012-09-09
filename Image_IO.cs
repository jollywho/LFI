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
        /// <summary>
        /// Create a merged image using the list of titles.
        /// Default image is used when an image cannot be found.
        /// </summary>
        /// <param name="titleStrs">list of string titles.</param>
        /// <param name="btn">control to resize to.</param>
        /// <returns>the final image.</returns>
        public static Image createMergedImage(List<string> titleStrs, Control btn)
        {
            List<Image> imgLst = new List<Image>();
            List<string> titleLst = new List<string>();
            string path = Folder_IO.GetUserImagePath();
            for (int i = 0; i <= titleStrs.Count - 1; i++)
            {
                if (!titleLst.Contains(titleStrs[i]))
                {
                    titleLst.Add(titleStrs[i]);
                    if (System.IO.File.Exists(path + string.Format("\\{0}.jpg", titleStrs[i])))
                    {
                        FileStream fs = new FileStream(path + string.Format("\\{0}.jpg", titleStrs[i]), FileMode.Open);
                        Image img = Image.FromStream(fs);
                        fs.Close();
                        imgLst.Add(resize_Image(img, 245, 345));
                    }
                    else
                        imgLst.Add(resize_Image(LFI.Properties.Resources.notavailable,
                            245, 345));
                }
            }
            Image finalImage = merge_Images(imgLst, btn.Width, btn.Height, titleLst.Count);
            return finalImage;
        }

        /// <summary>
        /// Resize an image to a specific width and height.
        /// </summary>
        /// <param name="srcImage">original image.</param>
        /// <param name="newWidth">new width.</param>
        /// <param name="newHeight">new height.</param>
        /// <returns></returns>
        public static Image resize_Image(Image srcImage, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.InterpolationMode = InterpolationMode.HighQualityBilinear;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
                return newImage;
            }
        }

        /// <summary>
        /// Rename an image file to a new string.
        /// </summary>
        /// <param name="str">original filename.</param>
        /// <param name="newstr">new filename.</param>
        public static void rename_Image(string str, string newstr)
        {
            if (str == newstr)
                return;
            string path = Folder_IO.GetUserImagePath();
            string file = string.Format("\\{0}.jpg", str);
            string newfile = string.Format("\\{0}.jpg", newstr);

            if (System.IO.File.Exists(path + file))
            {
                File.Move(path + file, path + newfile);
            }
        }

        /// <summary>
        /// Delete a specific image file.
        /// </summary>
        /// <param name="str">the filename.</param>
        public static void delete_Image(string str)
        {
            string path = Folder_IO.GetUserImagePath();
            string file = string.Format("\\{0}.jpg", str);

            if (System.IO.File.Exists(path + file))
            {
                File.Delete(path + file);
            }
        }

        /// <summary>
        /// Merge a list of images into a single image with dividing lines.
        /// </summary>
        /// <param name="imgLst">list of images.</param>
        /// <param name="newWidth">new width.</param>
        /// <param name="newHeight">new height.</param>
        /// <param name="items">item count.</param>
        /// <returns>the final image.</returns>
        public static Image merge_Images(List<Image> imgLst, int newWidth, int newHeight, int items)
        {
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics grfx = Graphics.FromImage(newImage))
            {
                for (int i = 0; i <= imgLst.Count - 1; i++)
                {
                    grfx.DrawImage(imgLst[i], new Rectangle((newWidth / items) * i, 0, newWidth / items, newHeight));
                    if (i > 0 && i != imgLst.Count)
                        grfx.DrawLine(new Pen(Color.Black), (newWidth / items) * i, 0, (newWidth / items) * i, newHeight);
                }
                return newImage;
            }
        }

        /// <summary>
        /// Load image file to stream and place it into control property.
        /// </summary>
        /// <param name="str">filename.</param>
        /// <param name="bx">picturebox control.</param>
        public static void setImage(string str, PictureBox bx)
        {
            string path = Folder_IO.GetUserImagePath() + string.Format("\\{0}.jpg", str);

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

        public static Image getImage(string str)
        {
            string path = Folder_IO.GetUserImagePath() + string.Format("\\{0}.jpg", str);
            Image foundImage = null;
            if (System.IO.File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                foundImage = Image.FromStream(fs);
                fs.Close();
            }
            return foundImage;
        }

        /// <summary>
        /// Get contents of a disc_id and generate a merged image for it.
        /// </summary>
        /// <param name="discid"></param>
        /// <param name="locationid"></param>
        /// <param name="btn"></param>
        /// <returns></returns>
        public static Image generateDiscImage(string discid, string locationid,  Control btn)
        {
            Image img = resize_Image(LFI.Properties.Resources.border, 245, 345);
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
