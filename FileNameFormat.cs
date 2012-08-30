using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LFI
{
    enum EPFORMAT
    {
        REG_NUM,
        ALL_NUM,
        NUM_X_NUM,
        S_NUM_E_NUM,
    };

    class FileNameFormat
    {
        private static string reg_NUM = @"(\[(.*?)\])?(.*?)()([\d]{1,4}).*?";
        private static string reg_NUM_X_NUM = @"(\[(.*?)\])?(.*?)(\d{1,3})[Xx]?(\d{1,3}).*?";
        private static string reg_S_NUM_E_NUM = @"(\[(.*?)\])?(.*?)([Ss]?\d{1,2})([Ee]?\d{2}).*?";
        private static string reg_ALL_NUM = @"(\[(.*?)\])?(.*?)(0?[\d]{1,}?)([\d]{2}).*?";
        private string regChoice;
        private string strFile;

        public FileNameFormat(string file, EPFORMAT choice)
        {
            strFile = file;
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

        public string EstimateSeason()
        {
            return (new Regex(regChoice).Match(strFile).Groups[4]).ToString().ToUpper();
        }

        public string EstimateEpisode()
        {
            return (new Regex(regChoice).Match(strFile).Groups[5]).ToString().ToUpper();
        }

        public string EstimateGroup()
        {
            return (new Regex(regChoice).Match(strFile).Groups[2]).ToString();
        }
        public string EstimateCRC()
        {
            return Folder_IO.ScanCRC(strFile);
        }
    }
}
