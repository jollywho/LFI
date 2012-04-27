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
        private string checksum;
        PictureBox animation = new PictureBox();
        int savedRow = 0;
        int workingRow = 0;

        public struct SimpleData
        {
            public string Text { get; set; }
            public string Hidden { get; set; }
        }

        public folderView(MainForm main)
        {
            InitializeComponent();
            caller = main;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            animation.Image = LFI.Properties.Resources.progress;
            animation.Width = 16;
            animation.Height = 16;
            animation.BackColor = Color.Transparent;
            animation.Hide();
            gvFiles.Controls.Add(animation);
            gvFiles.CellPainting += new DataGridViewCellPaintingEventHandler(gvFiles_CellPainting);
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
            countFolders();
            lstFolders_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            folder = null;
            lblSize.Text = "0.00 GB";
            ddUrl.Text = string.Empty;
            gvFiles.DataSource = null;
            lstFolders.DataSource = null;
            lstFolders.Items.Clear();
            btnClear.Enabled = false;
            btnDivide.Enabled = false;
        }

        private void lstFolders_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                int sel = Convert.ToInt32(lstFolders.Text);
                gvFiles.DataSource = null;
                var bindingSource = new BindingSource();
                if (lstFolders.Text == "0")
                {
                    lblSize.Text = folder.Get_Folder_Size(sel, true) + " GB";
                    for (int i = 0; i <= folder.folderitems.Count - 1; i++)
                    {
                        bindingSource.Add(new SimpleData
                        {
                            Text = Path.GetFileName(folder.folderitems[i]),
                            Hidden = folder.filenames[i]
                        });
                    }
                }
                else
                {
                    lblSize.Text = folder.Get_Folder_Size(sel, false) + " GB";
                    for (int i = 0; i <= folder.folderDivisions[sel - 1].Count - 1; i++)
                    {
                        bindingSource.Add(new SimpleData
                        {
                            Text = Path.GetFileName(folder.folderDivisions[sel - 1][i]),
                            Hidden = folder.folderDivisions[sel - 1][i]
                        });
                    }
                }
                gvFiles.DataSource = bindingSource;
                gvFiles.Columns[2].Visible = false;
                gvFiles_RowEnter(null, null);
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string file = (string)e.Argument;

            try
            {
                Crc32 crc32 = new Crc32();
                Crc32.worker = worker;
                String hash = String.Empty;
                using (FileStream fs = File.Open(file, FileMode.Open))
                    foreach (byte b in crc32.ComputeHash(fs))
                    {
                        hash += b.ToString("x2").ToUpper();
                    }
                checksum = hash;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        //todo: method for cutting crc from filename
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            animation.Hide();
            caller.stop_progBar();
            if (checksum == "7FB94658")
                gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.check;
            else
                gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.error;
        }

        void gvFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            animation.Location = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Location;
            animation.Width = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Width;
            animation.Height = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Height;
        }

        private void btnCheckCRC_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy != true)
            {
                animation.Show();
                caller.start_progBar();
                workingRow = savedRow;
                worker.RunWorkerAsync(gvFiles.Rows[savedRow].Cells[2].Value);
            }
        }

        private void gvFiles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i <= gvFiles.RowCount - 1; i++)
            {
                gvFiles.Rows[i].Cells[0].Value = LFI.Properties.Resources.empty;
            }
        }

        private void gvFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvFiles.SelectedCells.Count > 0)
                if (gvFiles.SelectedCells[0].Value != null)
                    savedRow = gvFiles.SelectedCells[0].RowIndex;

        }
    }
}
