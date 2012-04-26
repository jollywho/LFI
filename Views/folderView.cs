using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LFI
{
    public partial class folderView : UserControl
    {
        private BackgroundWorker worker = new BackgroundWorker();
        private Folder_IO folder;
        private string dirname;
        private MainForm caller;

        public folderView(MainForm main)
        {
            InitializeComponent();
            caller = main;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.pushback_formView();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                folder = new Folder_IO(ddUrl.Text);
                countFolders();
                btnDivide.Enabled = true;
                btnClear.Enabled = true;
                dirname = ddUrl.Text;
                lstFolders_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening : " + ex.Message);
            }
        }

        private void countFolders()
        {
            lstFolders.DataSource = null;
            lstFolders.Items.Clear();
            List<string> folder_list = new List<string>();

            if (folder.dsCount == 0)
                folder_list.Add("0");
            else
            {
                for (int i = 1; i <= folder.dsCount; i++)
                {
                    folder_list.Add(i.ToString());
                }
            }
            lstFolders.DataSource = folder_list;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            folder.Generate_Divisions();
            lstFiles.DataSource = null;
            lstFiles.Items.Clear();
            lstFiles.DataSource = folder.files;
            countFolders();
            lstFolders_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            folder = null;
            lblSize.Text = "0.00 GB";
            ddUrl.Text = string.Empty;
            lstFiles.DataSource = null;
            lstFiles.Items.Clear();
            lstFolders.DataSource = null;
            lstFolders.Items.Clear();
            btnClear.Enabled = false;
            btnDivide.Enabled = false;
        }

        private void lstFolders_Click(object sender, EventArgs e)
        {
            int sel = Convert.ToInt32(lstFolders.Text);
            lstFiles.DataSource = null;
            lstFiles.Items.Clear();
            if (lstFolders.Text == "0")
            {
                lblSize.Text = folder.Get_Folder_Size(sel, true) + " GB";
                lstFiles.DataSource = folder.files;
            }
            else
            {
                lblSize.Text = folder.Get_Folder_Size(sel, false) + " GB";
                lstFiles.DataSource = folder.folderDivisions[sel - 1];
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            OpenFileDialog file = (OpenFileDialog)e.Argument;
            try
            {
                Crc32 crc32 = new Crc32();
                Crc32.worker = worker;
                String hash = String.Empty;
                using (FileStream fs = File.Open(file.FileName, FileMode.Open))
                    foreach (byte b in crc32.ComputeHash(fs))
                    {
                        hash += b.ToString("x2").ToUpper();
                    }
                Console.WriteLine(hash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            caller.stop_progBar();
        }

        private void btbCRC_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy != true)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() != DialogResult.Cancel)
                {
                    caller.start_progBar();
                    worker.RunWorkerAsync(dlg);
                }
            }
        }
    }
}
