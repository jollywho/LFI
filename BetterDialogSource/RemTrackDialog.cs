using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class RemTrackDialog : Form
    {
        private string dirname = string.Empty;
        private EPFORMAT fileformat;
        private FileNameFormat file;

        public RemTrackDialog(string path, FileNameFormat fn)
        {
            InitializeComponent();
            MainForm.Main.WindowState = FormWindowState.Normal;
            this.WindowState = MainForm.Main.WindowState;
            this.TopMost = MainForm.Main.TopMost;

            file = fn;
            fileformat = fn.Format;
            dirname = path;
        }

        public static void ShowDialog(string path, FileNameFormat fn)
        {
            RemTrackDialog dlg = new RemTrackDialog(path, fn);
            dlg.Owner = MainForm.Main;
            dlg.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private bool ValidateFields()
        {
            return false;
        }
    }
}
