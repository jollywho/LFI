﻿using System;
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
        private long folderSize = 0;
        private int itemCount = 0;
        private int dvCount = 0;
        public int dsCount = 0;
        private long folderAverage = 0;

        public Folder_IO(string dir)
        {
            dirname = dir;
            Set_Folder_Items();
            folderSize = DirSize(filenames);
        }

        public void Set_Folder_Items()
        {
            folderitems.Clear();
            filenames.Clear();
            itemCount = 0;
            try
            {
                var sorted = Directory.GetFiles(dirname);
                Array.Sort(sorted, new AlphanumComparatorFast());
                foreach (string item in sorted)
                {
                    folderitems.Add(Path.GetFileName(item));
                    filenames.Add(item);
                    itemCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public string Get_Folder_Size(int folder, bool root)
        {
            if (root == true)
                return (folderSize / Math.Pow(1024, 3)).ToString("N3");
            else
                return (DirSize(folderDivisions[folder-1])/ Math.Pow(1024, 3)).ToString("N3");
        }

        public void Generate_Divisions()
        {
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

        public static string ScanCRC(string filename, out string newfilename)
        {
            FileInfo file = new FileInfo(filename);
            FixExtension(file);

            string crcStr = reg.Match(filename).Groups[0].Value;

            Console.WriteLine("Detected CRC : " + crcStr);
            newfilename = Path.GetFileName(file.Name);
            return crcStr;
        }

        public static string AddCRC(string filename, string crc, out string newfilename)
        {
            FileInfo file = new FileInfo(filename);
            FixExtension(file);
            file.Refresh();

            file.MoveTo(file.FullName.Insert(file.FullName.Length - (file.Extension.Length), "[" + crc + "]"));
            file.Refresh();
            newfilename = Path.GetFileName(file.Name);
            return file.FullName;
        }

        public static void FixExtension(FileInfo file)
        {
            if (file.Extension.Contains(".part"))
            {
                file.MoveTo(file.FullName.Replace(".part", ""));
            }
        }

        public static bool IsCRC(string str)
        {
            return reg.IsMatch(str);
        }
    }
}
