using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LFI
{
    class NativeMethods
    {
        private const int FILE_ATTRIBUTE_NORMAL = 0x80;
        private const int SHGFI_TYPENAME = 0x400;
        private const int SHGFI_USEFILEATTRIBUTES = 0x000000010;
        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_SMALLICON = 0x0;
        public const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SHGetFileInfo(
            string pszPath,
            int dwFileAttributes,
            ref  SHFILEINFO shinfo,
            uint cbfileInfo,
            int uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DestroyIcon(IntPtr hIcon);


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, out SHFILEINFO psfi, uint cbFileInfo, uint uFlags);


        public static string GetShellFileType(string fileName)
        {
            var shinfo = new SHFILEINFO();
            const int flags = SHGFI_TYPENAME | SHGFI_USEFILEATTRIBUTES;

            if (SHGetFileInfo(fileName, FILE_ATTRIBUTE_NORMAL, ref shinfo, (uint)Marshal.SizeOf(shinfo), flags) == IntPtr.Zero)
            {
                return "File";
            }

            return shinfo.szTypeName;
        }

        public static Icon GetSmallIcon(string fileName)
        {
            // Need to add size check, although errors generated at present!    
            uint flags = SHGFI_ICON | SHGFI_USEFILEATTRIBUTES | SHGFI_SMALLICON;

            // Get the folder icon    
            var shfi = new SHFILEINFO();

            var res = SHGetFileInfo(fileName,
                0,
                out shfi,
                (uint)Marshal.SizeOf(shfi),
                flags);

            //hImgSmall = SHGetFileInfo(fileName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), flags);
            //The icon is returned in the hIcon member of the shinfo struct
            Icon icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();
            DestroyIcon(shfi.hIcon);
            return icon;
        }

        public static Icon GetFolderIcon()
        {
            // Need to add size check, although errors generated at present!    
            uint flags = SHGFI_USEFILEATTRIBUTES | SHGFI_SMALLICON;

            // Get the folder icon    
            var shfi = new SHFILEINFO();

            var res = SHGetFileInfo(@"C:\Windows",
                FILE_ATTRIBUTE_DIRECTORY,
                out shfi,
                (uint)Marshal.SizeOf(shfi),
                flags);

            if (res == IntPtr.Zero)
                throw Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error());

            // Load the icon from an HICON handle  
            Icon.FromHandle(shfi.hIcon);

            // Now clone the icon, so that it can be successfully stored in an ImageList
            var icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();

            DestroyIcon(shfi.hIcon);        // Cleanup    

            return icon;
        }
    }
}
