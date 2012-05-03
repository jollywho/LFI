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
            DoubleBuffered = true;
            caller = main;
            animation.Image = LFI.Properties.Resources.progress;
            animation.Width = 16;
            animation.Height = 16;
            animation.BackColor = Color.Transparent;
            animation.Hide();
            gvFiles.Controls.Add(animation);
            gvFiles.CellPainting += new DataGridViewCellPaintingEventHandler(gvFiles_CellPainting);
            string[] folders = System.IO.Directory.GetDirectories(
                Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
            ddUrl.DataSource = folders;
        }

        private void open_Folder()
        {
            try
            {
                folder = new Folder_IO(ddUrl.Text);
                countFolders();
                btnShowDiv.Enabled = true;
                btnClear.Enabled = true;
                dirname = ddUrl.Text;
                lstDivs_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening : " + ex.Message);
            }
        }

        private void countFolders()
        {
            lstDivs.DataSource = null;
            lstDivs.Items.Clear();
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
            lstDivs.DataSource = folder_list;
        }

        private void btnShowDiv_Click(object sender, EventArgs e)
        {
            folder.Generate_Divisions();
            countFolders();
            btnDivide.Enabled = true;
            lstDivs_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            folder = null;
            lblSize.Text = "0.00 GB";
            ddUrl.Text = string.Empty;
            gvFiles.DataSource = null;
            lstDivs.DataSource = null;
            lstDivs.Items.Clear();
            btnClear.Enabled = false;
            btnDivide.Enabled = false;
            btnShowDiv.Enabled = false;
        }

        private void lstDivs_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy && folder.filenames.Count > 0)
            {
                int sel = Convert.ToInt32(lstDivs.Text);
                gvFiles.DataSource = null;
                gvFiles.Rows.Clear();
                if (lstDivs.Text == "0")
                {
                    lblSize.Text = folder.Get_Folder_Size(sel, true) + " GB";
                    for (int i = 0; i <= folder.folderitems.Count - 1; i++)
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            Path.GetFileName(folder.folderitems[i]),
                            folder.filenames[i]);
                    }
                }
                else
                {
                    lblSize.Text = folder.Get_Folder_Size(sel, false) + " GB";
                    for (int i = 0; i <= folder.folderDivisions[sel - 1].Count - 1; i++)
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            Path.GetFileName(folder.folderDivisions[sel - 1][i]),
                            folder.folderDivisions[sel - 1][i]
                        );
                    }
                }
                gvFiles_RowEnter(null, null);
            }
        }

        private void worker_ComputeCRC(object sender, DoWorkEventArgs e)
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

        private void bw_CheckCRCCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            animation.Hide();
            caller.stop_progBar();
            string newfilename = string.Empty;
            if (checksum == Folder_IO.ScanCRC(gvFiles.Rows[workingRow].Cells[2].Value.ToString(),
                    out newfilename))
                gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.check;
            else
                gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.error;
            gvFiles.Rows[workingRow].Cells[1].Value = newfilename;
        }

        private void bw_AddCRCCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            animation.Hide();
            caller.stop_progBar();
            string newfilename = string.Empty;
            gvFiles.Rows[workingRow].Cells[2].Value = 
                Folder_IO.AddCRC(gvFiles.Rows[workingRow].Cells[2].Value.ToString(),
                checksum, out newfilename);
            gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.check;
            gvFiles.Rows[workingRow].Cells[1].Value = newfilename;
        }

        void gvFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            animation.Location = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Location;
            animation.Width = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Width;
            animation.Height = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Height;
        }

        private void btnAddCRC_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                if (!Folder_IO.IsCRC(gvFiles.Rows[savedRow].Cells[1].Value.ToString()))
                {
                    gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.empty;
                    animation.Show();
                    worker = new BackgroundWorker();
                    worker.WorkerReportsProgress = true;
                    worker.WorkerSupportsCancellation = true;
                    worker.DoWork += new DoWorkEventHandler(worker_ComputeCRC);
                    worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_AddCRCCompleted);
                    workingRow = savedRow;
                    caller.start_progBar();
                    worker.RunWorkerAsync(gvFiles.Rows[workingRow].Cells[2].Value);
                }
            }
        }

        private void btnCheckCRC_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                gvFiles.Rows[savedRow].Cells[0].Value = LFI.Properties.Resources.empty;
                animation.Show();
                worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.WorkerSupportsCancellation = true;
                worker.DoWork += new DoWorkEventHandler(worker_ComputeCRC);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_CheckCRCCompleted);
                workingRow = savedRow;
                caller.start_progBar();
                worker.RunWorkerAsync(gvFiles.Rows[workingRow].Cells[2].Value);
            }
        }

        private void gvFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvFiles.SelectedCells.Count > 0)
                if (gvFiles.SelectedCells[0].Value != null)
                    savedRow = gvFiles.SelectedCells[0].RowIndex;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            btnShowDiv.Enabled = false;
            if (folder.folderDivisions.Count > 1)
            {
                try
                {
                    for (int i = 0; i <= folder.folderDivisions.Count - 1; i++)
                    {
                        System.IO.Directory.CreateDirectory(folder.dirname + "\\" + (i + 1));
                        for (int j = 0; j <= folder.folderDivisions[i].Count - 1; j++)
                        {
                            FileInfo ff = new FileInfo(folder.folderDivisions[i][j]);
                            ff.MoveTo(folder.dirname + "\\" + (i + 1) + "\\" + ff.Name);
                        }
                    }
                    btnDivide.Enabled = false;
                    MessageBox.Show("No Errors Detected", "Move Complete");
                    ddUrl_SelectedValueChanged(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
           
        }

        private void ddUrl_SelectedValueChanged(object sender, EventArgs e)
        {
            if (System.IO.Directory.GetDirectories(ddUrl.Text).Count<string>() > 1)
            {
                rebind_ddUrl();
            }
            open_Folder();
        }

        private void rebind_ddUrl()
        {
            ddUrl.DataSource = System.IO.Directory.GetDirectories(
                ddUrl.Text);
            open_Folder();
        }

        private void ddUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                open_Folder();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatStyle = FlatStyle.Popup;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatStyle = FlatStyle.Flat;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ddUrl.Text = Path.GetDirectoryName(Path.GetDirectoryName(ddUrl.Text));
            rebind_ddUrl();
        }
    }
}
