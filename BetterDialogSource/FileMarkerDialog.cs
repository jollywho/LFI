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
        private string dirname = string.Empty;
        private EPFORMAT fileformat;
        private FileNameFormat file;

        public FileMarkerDialog(string path, FileNameFormat fn)
        {
            InitializeComponent();

            this.TopMost = MainForm.Main.TopMost;
            file = fn;
            fileformat = fn.Format;
            dirname = path;
            txtGroup.Text = fn.EstimateGroup();
            txtStart.Text = fn.EstimateEpisode();
            txtSeason.Text = fn.EstimateSeason();
        }

        public static void ShowDialog(string path, FileNameFormat fn)
        {
            using (FileMarkerDialog dlg = new FileMarkerDialog(path, fn))
            {
                dlg.ShowDialog(MainForm.Main);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            string filename = string.Empty;
            try
            {
                if (txtGroup.Text.Length > 1)
                    filename = '[' + txtGroup.Text + ']' + ' ';
                filename += txtTitle.Text + FileNameFormat.ToFormat(txtStart.Text, txtSeason.Text, fileformat);

                string fullpath = Path.Combine(dirname, filename.Replace(' ', '_'));
                file.FileName = fullpath;
                if (txtEnd.Text.Length > 1)
                    fullpath = file.FileName.Replace(file.EstimateEpisode(), file.EstimateEpisode() + "-" + txtEnd.Text);

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
            catch (Exception ex)
            {
                Error_Handle.TipError("Error Creating File : " + ex.Message, toolTip, txtTitle);
            }
        }

        private bool ValidateFields()
        {
            if (txtTitle.Text.Length < 1)
            {
                Error_Handle.TipError("Title Required\n", toolTip, txtTitle);
                return false;
            }
            if (txtStart.Text.Length < 1)
            {
                Error_Handle.TipError("Start Required\n", toolTip, txtStart);
                return false;
            }
            if (txtEnd.Text.Length >= 1)
            {
                if (Convert.ToInt32(txtEnd.Text) < Convert.ToInt32(txtStart.Text))
                {
                    Error_Handle.TipError("Cannot Be Less Than Start\n", toolTip, txtEnd);
                    return false;
                }
            }

            return true;
        }
    }
}
