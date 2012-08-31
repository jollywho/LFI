using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class FileMarkerDialog : Form
    {
        string dirname = string.Empty;

        public FileMarkerDialog(string path)
        {
            InitializeComponent();
            dirname = path;
        }

        public static void ShowDialog(string path)
        {
            using (FileMarkerDialog dlg = new FileMarkerDialog(path))
            {
                dlg.ShowDialog();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length < 1)
            {
                Error_Handle.TipError("Title Required\n", toolTip, txtTitle);
                return;
            }
            if (txtStart.Text.Length < 1)
            {
                Error_Handle.TipError("Start Required\n", toolTip, txtStart);
                return;
            }
            if (txtEnd.Text.Length < 1)
            {
                Error_Handle.TipError("End Required\n", toolTip, txtEnd);
                return;
            }
            
            string fullpath = Path.Combine(dirname, txtTitle.Text.Replace(' ', '_'));
            fullpath = Path.ChangeExtension(fullpath, radType_Filler.Checked ? "filler" : "missing");

            if (File.Exists(fullpath))
            {
                Error_Handle.TipError("Title Already Exists\n", toolTip, txtTitle);
                return;
            }

            imgWorking.Visible = true;
            File.CreateText(fullpath);
            Close();
        }
    }
}
