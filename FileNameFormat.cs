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

        public FileNameFormat(string file, EPFORMAT choice)
        {
           // Console.Write("Fansub = ");
            //Console.WriteLine(new Regex(regGroup).Match(file).Groups[1]);

           // Console.Write("Ep = ");
           // Match m = new Regex(regEp).Match(file);
           // while (m.Success)
           // {
           //     Console.Write(m.Value);
           //     Console.Write(", "); // Delimiter
           //     m = m.NextMatch();
           // }
           // Console.WriteLine();
            string regChoice = string.Empty;
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

            Console.WriteLine(new Regex(regChoice).Match(file).Groups[2]);
            Console.WriteLine(new Regex(regChoice).Match(file).Groups[3]);
            Console.WriteLine(new Regex(regChoice).Match(file).Groups[4]);

            Console.WriteLine(new Regex(regCRC).Match(file).Groups[0]);
        }
    }
}
