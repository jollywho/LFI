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
        NUM_X_NUM,
        S_NUM_E_NUM,
    };
    /* Load */
    //save crc
    //guess at episode
        //check for S[/d]{1,2}E[/d]{1,2}
        //check for [/d]{1,2}X[/d]{1,3}
        //check for first number [/d]{1,4}
    //display info on form

    /* Run */
    //accepts: prefix, title, ep, crc 
    //replace spaces in title with underscores
    //rename with given info
    //
    class FileNameFormat
    {
        private static string reg_NUM = @"(\[(.*?)\])?(.*?)([\d]{1,4}).*?";
        private static string reg_NUM_X_NUM = @"(\[(.*?)\])?(.*?)(\d{1,3}[Xx]?\d{1,3}).*?";
        private static string reg_S_NUM_E_NUM = @"(\[(.*?)\])?(.*?)([Ss]?\d{1,2}[Ee]?\d{2}).*?";
        private static string regCRC = @"((?<=(?:\[))[a-fA-F0-9]{8}(?=(?:\]))(?x))";
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
                case EPFORMAT.NUM_X_NUM:
                    regChoice = reg_NUM_X_NUM;
                    break;
                case EPFORMAT.S_NUM_E_NUM:
                    regChoice = reg_S_NUM_E_NUM;
                    break;
            }
        }

        public string EstimateEpisode()
        {
            return (new Regex(regChoice).Match(strFile).Groups[4]).ToString().ToUpper();
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
