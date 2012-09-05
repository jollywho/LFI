using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LFI
{
    public enum EPFORMAT
    {
        REG_NUM,        //{##}
        ALL_NUM,        //{##}{##}
        NUM_X_NUM,      //{##}x{##}
        S_NUM_E_NUM,    //S{##}E{##}
    };

    public class FileNameFormat
    {
        private const string reg_NUM = @"(\[(.*?)\])?(.*?)()([\d]{1,4}).*?";
        private const string reg_NUM_X_NUM = @"(\[(.*?)\])?(.*?)(\d{1,3})[Xx]?(\d{1,3}).*?";
        private const string reg_S_NUM_E_NUM = @"(\[(.*?)\])?(.*?)[Ss]?(\d{1,2})[Ee]?(\d{2}).*?";
        private const string reg_ALL_NUM = @"(\[(.*?)\])?(.*?)(0?[\d]{1,}?)([\d]{2}).*?";

        private const string format_NUM = @" - {0:d2}";
        private const string format_NUM_X_NUM = @" - {1:d2}x{0:d2}";
        private const string format_S_NUM_E_NUM = @" - S{1:d2}E{0:d2}";

        private string regChoice;
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private EPFORMAT format;

        public EPFORMAT Format
        {
            get { return format; }
            set { format = value; }
        }

        public FileNameFormat(string file, EPFORMAT choice)
        {
            fileName = file;
            format = choice;
            switch (choice)
            {
                case EPFORMAT.REG_NUM:
                    regChoice = reg_NUM;
                    break;
                case EPFORMAT.ALL_NUM:
                    regChoice = reg_ALL_NUM;
                    break;
                case EPFORMAT.NUM_X_NUM:
                    regChoice = reg_NUM_X_NUM;
                    break;
                case EPFORMAT.S_NUM_E_NUM:
                    regChoice = reg_S_NUM_E_NUM;
                    break;
            }
        }
        public string EstimateTitle()
        {
            return (new Regex(regChoice).Match(fileName).Groups[3]).ToString();
        }
        public string EstimateSeason()
        {
            return (new Regex(regChoice).Match(fileName).Groups[4]).ToString().ToUpper();
        }
        public string EstimateEpisode()
        {
            return (new Regex(regChoice).Match(fileName).Groups[5]).ToString().ToUpper();
        }
        public string EstimateGroup()
        {
            return (new Regex(regChoice).Match(fileName).Groups[2]).ToString();
        }
        public string EstimateCRC()
        {
            return Folder_IO.ScanCRC(fileName);
        }

        private static string GetFormat(EPFORMAT format)
        {
            string formatString = string.Empty;
            switch (format)
            {
                case EPFORMAT.REG_NUM:
                    formatString = format_NUM;
                    break;
                case EPFORMAT.NUM_X_NUM:
                    formatString = format_NUM_X_NUM;
                    break;
                case EPFORMAT.S_NUM_E_NUM:
                    formatString = format_S_NUM_E_NUM;
                    break;
            }
            return formatString;
        }

        public static string ToFormat(string episode, string season, EPFORMAT format)
        {
            if (string.IsNullOrEmpty(season))
                season = "01";

            return string.Format(GetFormat(format), Convert.ToInt32(episode), Convert.ToInt32(season));
        }
    }
}
