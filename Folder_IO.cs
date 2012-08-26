using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace LFI
{
    class Folder_IO
    {
        static Regex reg = new Regex(@"(?<=(?:\[))[a-fA-F0-9]{8}(?=(?:\]))(?x)");
        const int CRC_STRLEN = 10; //square brackets inclusive
        const long DVD_SIZE = 4550000000;
        const long INCREMENT_VALUE = 10000000;
        public string dirname = "";
        public List<string> folderitems = new List<string>();
        public List<string> filenames = new List<string>();
        public List<List<string>> folderDivisions = new List<List<string>>();
        public List<string> subdiritems = new List<string>();
        private long folderSize = 0;
        private int itemCount = 0;
        private int folderCount = 0;
        private int dvCount = 0;
        public int dsCount = 0;
        private long folderAverage = 0;

        public Folder_IO(string dir)
        {
            dirname = dir;
            Set_Folder_Items();
            folderSize = DirSize(filenames);
        }

        static public string GetUserImagePath()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            dir = System.IO.Path.Combine(dir, "LFI\\Images");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return dir;
        }

        static public string GetUserDataPath()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            dir = System.IO.Path.Combine(dir, "LFI\\Data");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            dir += "\\lfi.db";
            return dir;
        }

        /// <summary>
        /// Get directory filenames, paths, and item count.
        /// </summary>
        public void Set_Folder_Items()
        {
            folderitems.Clear();
            filenames.Clear();
            subdiritems.Clear();
            itemCount = 0;
            try
            {
                var sorted = Directory.GetFiles(dirname);
                var subdirs = Directory.GetDirectories(dirname);
                Array.Sort(sorted, new AlphanumComparatorFast());
                foreach (string item in sorted)
                {
                    folderitems.Add(Path.GetFileName(item));
                    filenames.Add(item);
                    itemCount++;
                }
                foreach (string item in subdirs)
                {
                    subdiritems.Add(item);
                    folderCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public int GetItemCount()
        {
            return itemCount + folderCount;
        }

        /// <summary>
        /// Get folder size of specified directory.
        /// </summary>
        /// <param name="folder">folder index.</param>
        /// <param name="root">root folder or divisioned.</param>
        /// <returns>folder size.</returns>
        public string Get_Folder_Size(int folder, bool root)
        {
            if (root == true)
                return (folderSize / Math.Pow(1024, 3)).ToString("N3");
            else
                return (DirSize(folderDivisions[folder-1])/ Math.Pow(1024, 3)).ToString("N3");
        }

        /// <summary>
        /// Create folder divisions based on folder average ad max items per division.
        /// <returns>
        /// Returns a pass or fail condition.
        /// </returns>
        /// </summary>
        public bool Generate_Divisions()
        {
            if (itemCount < 1) return false;
            dsCount = (int)(folderSize / DVD_SIZE);
            if (folderSize % DVD_SIZE != 0 && dsCount > 0)
            {
                dsCount++;
                folderAverage = (folderSize /dsCount);
            }
            if (dsCount == 0)
                dsCount = 1;

            while (dvCount < itemCount)
            {
                int pos = 0;
                dvCount = 0;
                folderDivisions.Clear();
                for (int i=0; i<=dsCount-1; i++)
                {
                    pos = AddMaxItems(pos);
                }
                folderAverage += INCREMENT_VALUE;
            }

            Console.WriteLine(folderSize.ToString());
            Console.WriteLine(dsCount.ToString());
            Console.WriteLine(itemCount.ToString());
            Console.WriteLine(folderAverage.ToString());
            return true;
        }

        private long DirSize(List<string>itemlist)
        {
            long size = 0;
            foreach (string fi in itemlist)
            {
                FileInfo info = new FileInfo(fi);
                size += info.Length;
            }
            return size;
        }

        /// <summary>
        /// Add items to division until greater than folder average.
        /// </summary>
        /// <param name="pos">current item position.</param>
        /// <returns>new item position.</returns>
        private int AddMaxItems(int pos)
        {
            long sum = 0;
            int newpos = 0;
            List<string> temp = new List<string>();
            for (int i=pos; i<=filenames.Count - 1; i++)
            {
                FileInfo info = new FileInfo(filenames[i]);
                sum += info.Length;
                if (sum < folderAverage)
                {
                    temp.Add(info.ToString());
                    dvCount++;
                }
                else
                {
                    newpos = i;
                    break;
                }
            }
            folderDivisions.Add(temp);
            return newpos;
        }

        /// <summary>
        /// Find CRC within a given filename.
        /// </summary>
        /// <param name="filename">given filename.</param>
        /// <param name="newfilename">new filename.</param>
        /// <returns>the CRC code.</returns>
        public static string ScanCRC(string filename)
        {
            FileInfo file = new FileInfo(filename);

            string crcStr = reg.Match(filename).Groups[0].Value;
            crcStr = crcStr.ToUpper();

            Console.WriteLine("Detected CRC : " + crcStr);
            return crcStr;
        }

        /// <summary>
        /// Add CRC checksum to given filename.
        /// </summary>
        /// <param name="filename">string filename.</param>
        /// <param name="crc">string CRC code.</param>
        /// <param name="newfilename">new file name.</param>
        /// <returns>path + filename.</returns>
        public static string AddCRC(string filename, string crc, out string newfilename)
        {
            FileInfo file = new FileInfo(filename);
            file.Refresh();

            file.MoveTo(file.FullName.Insert(file.FullName.Length - (file.Extension.Length), "[" + crc + "]"));
            file.Refresh();
            newfilename = Path.GetFileName(file.Name);
            return file.FullName;
        }

        /// <summary>
        /// Remove CRC checksum from given filename.
        /// </summary>
        /// <param name="filename">string filename.</param>
        /// <param name="crc">string CRC code.</param>
        /// <param name="newfilename">new file name.</param>
        /// <returns>path + filename.</returns>
        public static string RemoveCRC(string filename, out string newfilename)
        {
            FileInfo file = new FileInfo(filename);
            file.MoveTo(file.FullName.Replace("[" + ScanCRC(filename) + "]", ""));
            file.Refresh();
            newfilename = Path.GetFileName(file.Name);
            return file.FullName;
        }

        public static string RenameFile(string filename, 
            string prefix, string title, string episode, string suffix,
            out string newfilename, out bool skipped)
        {
            FileInfo file = new FileInfo(filename);
            string destfilename = string.Empty;
            skipped = false;
            try
            {
                if (prefix.Trim().Length >= 1)
                    destfilename = '[' + prefix + ']' + ' ';
                destfilename += title;
                if (episode.Trim().Length >= 1)
                    destfilename += " - " + episode;
                else
                    skipped = true;
                if (suffix.Trim().Length >= 1)
                    destfilename += " [" + suffix + "]";
                destfilename = destfilename.Replace(' ', '_');

                if (!skipped)
                    file.MoveTo(file.FullName.Replace(file.Name, destfilename)+file.Extension);
                file.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("'{0}' :\n {1}", title, ex.Message), "Rename Error");
            }
            finally
            {
                newfilename = Path.GetFileName(file.Name);
            }
            return file.FullName;
        }

        /// <summary>
        /// Remove 'part' from file extension.
        /// </summary>
        /// <param name="file">File</param>
        public static void FixExtension(FileInfo file)
        {
            if (file.Extension.Contains(".part"))
            {
                file.MoveTo(file.FullName.Replace(".part", ""));
            }
        }

        /// <summary>
        /// Check if string contains valid CRC.
        /// </summary>
        /// <param name="str">the string.</param>
        /// <returns>True if contains valid CRC.</returns>
        public static bool IsCRC(string str)
        {
            return reg.IsMatch(str);
        }
    }
}
