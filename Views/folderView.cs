using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LFI
{
    public partial class folderView : UserControl
    {
        private Folder_IO folder;
        private string dirname;
        private MainForm caller;
        private string checksum;
        private DataTable dtFilter = new DataTable();
        PictureBox animation = new PictureBox();
        int savedRow = 0;
        int workingRow = 0;
        int refreshRow = 0;
        int refreshIndex = 0;
        private bool showFields = false;
        private bool multiRun = false;
        private bool cancel = false;
        int[] cellHover = new int[2];

        public folderView(MainForm main)
        {
            InitializeComponent();
            DoubleBuffered = true;
            caller = main;
            gvFiles.CellPainting += new DataGridViewCellPaintingEventHandler(gvFiles_CellPainting);
            List<string> folders = System.IO.Directory.GetDirectories(
                Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)).ToList();
            folders.Insert(0, Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
            ddUrl.ComboBox.DataSource = folders;
            ddUrl.ComboBox.MouseWheel += new MouseEventHandler(combobox_MouseWheel);
            ddUrl.ComboBox.SelectedValueChanged += new EventHandler(ddUrl_SelectedValueChanged);
            ddUrl.ComboBox.KeyDown += new KeyEventHandler(ddUrl_KeyDown);

            animation.Image = LFI.Properties.Resources.progress;
            animation.Width = 16;
            animation.Height = 16;
            animation.BackColor = Color.Transparent;
            animation.Hide();
            gvFiles.Controls.Add(animation);

            Dictionary<EPFORMAT, string> choices = new Dictionary<EPFORMAT, string>();
            choices.Add(EPFORMAT.REG_NUM, "##");
            choices.Add(EPFORMAT.NUM_X_NUM, "## x ##");
            choices.Add(EPFORMAT.S_NUM_E_NUM, "S##E##");
            ddFormat.DataSource = new BindingSource(choices, null);
            ddFormat.DisplayMember = "Value";
            ddFormat.ValueMember = "Key";
            toolStrip1.Renderer = new TSystemRenderer();
            gvFiles.AlternatingRowsDefaultCellStyle = null;
            for (int i = 0; i < gvFiles.Columns.Count; i++)
                dtFilter.Columns.Add(i.ToString());

            open_Folder();
        }

        /// <summary>
        /// Opens folder pointed at by ddUrl.
        /// </summary>
        /// <remarks>
        /// This refreshes the gridview if already open.
        /// </remarks>
        private void open_Folder()
        {
            try
            {
                folder = new Folder_IO(ddUrl.Text);
                countFolders();
                btnShowDiv.Enabled = true;
                btnDivide.Enabled = false;
                btnRefresh.Enabled = true;
                dirname = ddUrl.Text;
                lstDivs_Click(null, null);
                txtFilter.Enabled = true;
                if (showFields) LoadFormatFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening : " + ex.Message);
            }
        }

        private void refresh_Folder()
        {
            refreshRow = gvFiles.SelectedCells[0].RowIndex;
            refreshIndex = gvFiles.FirstDisplayedScrollingRowIndex;
            open_Folder();
            gvFiles.Rows[refreshRow].Selected = true;
            gvFiles.FirstDisplayedScrollingRowIndex = refreshIndex;
            gvFiles.Focus();
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
            open_Folder();
            if (folder.Generate_Divisions())
            {
                countFolders();
                btnDivide.Enabled = true;
                lstDivs_Click(sender, e);
                txtFilter.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh_Folder();
            if (showFields)
                LoadFormatFields();
        }

        //populate gvFiles with items from selected divison
        private void lstDivs_Click(object sender, EventArgs e)
        {
            if (!Crc32.worker.IsBusy && folder.GetItemCount() > 0)
            {
                int sel = Convert.ToInt32(lstDivs.Text);
                int row = 0;
                gvFiles.DataSource = null;
                gvFiles.Rows.Clear();
                dtFilter.Clear();

                if (lstDivs.Text == "0")
                {
                    caller.SetLabelSize(folder.Get_Folder_Size(sel, true));
                    caller.SetLabelItemCount(folder.folderitems.Count);
                    for (int i = 0; i <= folder.subdiritems.Count - 1; i++, row++)
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                           LFI.Properties.Resources.folder,
                           Path.GetFileName(folder.subdiritems[i]), folder.subdiritems[i], null, null, null, row.ToString());
                        dtFilter.Rows.Add(null, null, Path.GetFileName(folder.subdiritems[i]), folder.subdiritems[i], null, null, null, row.ToString());
                    } 
                    for (int i = 0; i <= folder.folderitems.Count - 1; i++, row++)
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            Icon.ExtractAssociatedIcon(folder.filenames[i]),
                            Path.GetFileName(folder.folderitems[i]),
                            folder.filenames[i], null, null, null, row.ToString());
                        dtFilter.Rows.Add(null, null, Path.GetFileName(folder.folderitems[i]), folder.filenames[i], null,null,null, row.ToString());
                    }
                }
                else
                {
                    caller.SetLabelSize(folder.Get_Folder_Size(sel, false));
                    caller.SetLabelItemCount(folder.folderitems.Count);
                    for (int i = 0; i <= folder.folderDivisions[sel - 1].Count - 1; i++)
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            Icon.ExtractAssociatedIcon(folder.filenames[i]),
                            Path.GetFileName(folder.folderDivisions[sel - 1][i]),
                            folder.folderDivisions[sel - 1][i]
                        );
                    }
                }
                gvFiles.Focus();
            }
        }

        private void LoadFormatFields()
        {
            for (int i = 0; i < gvFiles.RowCount; i++)
            {
                if (!Directory.Exists(gvFiles.Rows[i].Cells[3].Value.ToString()))
                {
                    FileNameFormat fn = new FileNameFormat(gvFiles.Rows[i].Cells[2].Value.ToString(), (EPFORMAT)ddFormat.SelectedValue);
                    gvFiles.Rows[i].Cells[4].Value = fn.EstimateGroup();
                    gvFiles.Rows[i].Cells[5].Value = fn.EstimateEpisode();
                    gvFiles.Rows[i].Cells[6].Value = fn.EstimateCRC();
                }
            }
        }

        #region WORKER
        private void worker_ComputeCRC(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            string file = (string)e.Argument;

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

        private void bw_CheckCRCCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine(checksum);
            animation.Hide();
            caller.stop_progBar();

            if (checksum == Folder_IO.ScanCRC(gvFiles.Rows[workingRow].Cells[3].Value.ToString()))
                gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.check;
            else
                gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.error;

            DisableRunButtons();
            Check_MultiRunIncrement();
        }

        public void Cancel_MultiRun()
        {
            cancel = true;
        }

        private void bw_AddCRCCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            animation.Hide();
            caller.stop_progBar();
            string newfilename = string.Empty;
            gvFiles.Rows[workingRow].Cells[3].Value =
                Folder_IO.AddCRC(gvFiles.Rows[workingRow].Cells[3].Value.ToString(),
                checksum, out newfilename);
            gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.check;
            gvFiles.Rows[workingRow].Cells[2].Value = newfilename;
            Copy_Cells(gvFiles.Rows[workingRow].Cells[7].RowIndex, workingRow);

            if (lstDivs.Text == "0")
                folder.folderitems[workingRow] = ddUrl.Text + "\\" + newfilename;
            else
                folder.folderDivisions[Convert.ToInt32(lstDivs.Text) - 1][workingRow] =
                    ddUrl.Text + "\\" + newfilename;

            DisableRunButtons();
            Add_MultiRunIncrement();
        }
        #endregion WORKER

        private void Add_MultiRunIncrement()
        {
            if (multiRun && workingRow < gvFiles.Rows.Count - 1 && !cancel)
            {
                workingRow++;
                AddCRC();
            }
            else
            {
                workingRow = 0;
                cancel = false;
                multiRun = false;
            }
        }

        private void Check_MultiRunIncrement()
        {
            if (multiRun && workingRow < gvFiles.Rows.Count - 1 && !cancel)
            {
                workingRow++;
                CheckCRC();
            }
            else
            {
                workingRow = 0;
                cancel = false;
                multiRun = false;
            }
        }

        void gvFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (gvFiles.RowCount < 1) return;
            animation.Location = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Location;
            animation.Width = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Width;
            animation.Height = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Height;
        }

        private void EnableRunButtons()
        {
            btnCancel.Enabled = true;
            btnRunFormats.Enabled = false;
            btnRefresh.Enabled = false;
            btnShowDiv.Enabled = false;
            btnCheckCRC.Enabled = false;
            btnAddCRC.Enabled = false;
            btnShowEstimates.Enabled = false;
            btnRemoveChecksum.Enabled = false;
            btnPartFiles.Enabled = false;
            ddUrl.Enabled = false;
            txtFilter.Enabled = false;
        }

        private void DisableRunButtons()
        {
            btnCancel.Enabled = false;
            btnRefresh.Enabled = true;
            btnShowDiv.Enabled = true;
            btnCheckCRC.Enabled = true;
            btnAddCRC.Enabled = true;
            btnShowEstimates.Enabled = true;
            btnRemoveChecksum.Enabled = true;
            btnPartFiles.Enabled = true;
            ddUrl.Enabled = true;
            txtFilter.Enabled = true;
            btnRunFormats.Enabled = showFields;
        }

        private void CheckCRC()
        {
            gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.empty;
            animation.Show();
            Crc32.worker = new BackgroundWorker();
            Crc32.worker.WorkerReportsProgress = true;
            Crc32.worker.WorkerSupportsCancellation = true;
            Crc32.worker.DoWork += new DoWorkEventHandler(worker_ComputeCRC);
            Crc32.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_CheckCRCCompleted);
            EnableRunButtons();
            caller.start_progBar();
            Crc32.worker.RunWorkerAsync(gvFiles.Rows[workingRow].Cells[3].Value);
        }

        private void AddCRC()
        {
            if (!Folder_IO.IsCRC(gvFiles.Rows[workingRow].Cells[2].Value.ToString()))
            {
                gvFiles.Rows[workingRow].Cells[0].Value = LFI.Properties.Resources.empty;
                animation.Show();
                Crc32.worker = new BackgroundWorker();
                Crc32.worker.WorkerReportsProgress = true;
                Crc32.worker.WorkerSupportsCancellation = true;
                Crc32.worker.DoWork += new DoWorkEventHandler(worker_ComputeCRC);
                Crc32.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_AddCRCCompleted);
                EnableRunButtons();
                caller.start_progBar();
                Crc32.worker.RunWorkerAsync(gvFiles.Rows[workingRow].Cells[3].Value);
            }
            else
                Add_MultiRunIncrement();
        }

        private void gvFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvFiles.SelectedCells.Count > 0)
                if (gvFiles.SelectedCells[0].Value != null && !multiRun)
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
            txtFilter.Clear();
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
            ddUrl.Text = Directory.GetParent(ddUrl.Text).FullName;
            open_Folder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel_MultiRun();
        }

        private void btnAddCRC_Click(object sender, EventArgs e)
        {
            if (!Crc32.worker.IsBusy)
            {
                if (radCheckAll.Checked)
                    multiRun = true;
                else
                    workingRow = savedRow;
                AddCRC();
            }
        }

        private void btnCheckCRC_Click(object sender, EventArgs e)
        {
            if (!Crc32.worker.IsBusy)
            {
                if (radCheckAll.Checked)
                    multiRun = true;
                else
                    workingRow = savedRow;
                CheckCRC();
            }
        }

        private void gvFiles_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            cellHover[0] = e.RowIndex;
            cellHover[1] = e.ColumnIndex;
        }

        private void combobox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void gvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex == 2)
            {
                if (Directory.Exists(gvFiles.SelectedCells[3].Value.ToString()))
                {
                    ddUrl.Text = gvFiles.SelectedCells[3].Value.ToString();
                    open_Folder();
                }
                else
                    if (File.Exists(gvFiles.SelectedCells[3].Value.ToString()))
                        Process.Start(gvFiles.SelectedCells[3].Value.ToString());
            }
        }

        private void btnPartFiles_Click(object sender, EventArgs e)
        {
            if (radCheckAll.Checked)
            {
                for (int i = 0; i < gvFiles.Rows.Count; i++)
                {
                    FileInfo file = new FileInfo(gvFiles.Rows[i].Cells[3].Value.ToString());
                    Folder_IO.FixExtension(file);
                    Copy_Cells(Convert.ToInt32(gvFiles.Rows[i].Cells[7].Value), i);
                }
            }
            else
            {
                FileInfo file = new FileInfo(gvFiles.SelectedCells[3].Value.ToString());
                Folder_IO.FixExtension(file);
                Copy_Cells(Convert.ToInt32(gvFiles.SelectedCells[7].Value), gvFiles.SelectedCells[0].RowIndex);
            }
            refresh_Folder();
        }

        private void btnRemoveChecksum_Click(object sender, EventArgs e)
        {
            if (radCheckAll.Checked)
            {
                for (int i = 0; i < gvFiles.Rows.Count; i++)
                {
                    string newfilename = string.Empty;
                    gvFiles.Rows[i].Cells[3].Value =
                        Folder_IO.RemoveCRC(gvFiles.Rows[i].Cells[3].Value.ToString(),
                        out newfilename);
                    dtFilter.Rows[i][0] = newfilename;
                    dtFilter.Rows[i][1] = gvFiles.Rows[i].Cells[3].Value;
                    gvFiles.Rows[i].Cells[2].Value = newfilename;
                    Copy_Cells(Convert.ToInt32(gvFiles.Rows[i].Cells[7].Value), i);
                }
            }
            else
            {
                string newfilename = string.Empty;
                gvFiles.SelectedCells[3].Value =
                    Folder_IO.RemoveCRC(gvFiles.SelectedCells[3].Value.ToString(),
                    out newfilename);
                //
                gvFiles.SelectedCells[2].Value = newfilename;
                Copy_Cells(Convert.ToInt32(gvFiles.SelectedCells[7].Value), gvFiles.SelectedCells[0].RowIndex);
            }
        }

        private void btnRunFormats_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length < 1)
                MessageBox.Show("Rename Error: Title required.\n");
            else
            {
                
                if (radCheckAll.Checked)
                {
                    for (int i = 0; i < gvFiles.Rows.Count; i++)
                    {
                        string newfilename = string.Empty;
                        bool skipped = false;
                        gvFiles.Rows[i].Cells[3].Value =
                            Folder_IO.RenameFile(gvFiles.Rows[i].Cells[3].Value.ToString(),
                            gvFiles.Rows[i].Cells[4].Value.ToString(),
                            txtTitle.Text,
                            gvFiles.Rows[i].Cells[5].Value.ToString(),
                            gvFiles.Rows[i].Cells[6].Value.ToString(),
                            out newfilename, out skipped);
                        gvFiles.Rows[i].Cells[2].Value = newfilename;
                        Copy_Cells(Convert.ToInt32(gvFiles.Rows[i].Cells[7].Value), i);
                        if (skipped)
                            gvFiles.Rows[i].Cells[0].Value = LFI.Properties.Resources.Warning;
                    }
                }
                else
                {
                    string newfilename = string.Empty;
                    bool skipped = false;
                    gvFiles.SelectedCells[3].Value =
                        Folder_IO.RenameFile(gvFiles.SelectedCells[3].Value.ToString(),
                        gvFiles.SelectedCells[4].Value.ToString(),
                        txtTitle.Text,
                        gvFiles.SelectedCells[5].Value.ToString(),
                        gvFiles.SelectedCells[6].Value.ToString(),
                        out newfilename, out skipped);
                    gvFiles.SelectedCells[2].Value = newfilename;
                    Copy_Cells(Convert.ToInt32(gvFiles.SelectedCells[7].Value), gvFiles.SelectedCells[0].RowIndex);
                    
                    if (skipped)
                        gvFiles.SelectedCells[0].Value = LFI.Properties.Resources.Warning;
                }
            }
        }

        private void Copy_Cells(int p_rowindex, int f_rowindex)
        {
            for (int i = 0; i < gvFiles.Columns.Count; i++)
                dtFilter.Rows[p_rowindex][i] = gvFiles.Rows[f_rowindex].Cells[i].Value;
        }

        private void btnShowEstimates_Click(object sender, EventArgs e)
        {
            showFields = !showFields;
            if (showFields) { btnShowEstimates.Text = "Hide Fields";  }
            else { btnShowEstimates.Text = "Show Fields";  }
            btnRunFormats.Enabled = showFields;
            if (showFields) 
                LoadFormatFields();
            gvFiles.Columns[4].Visible = showFields;
            gvFiles.Columns[5].Visible = showFields;
            gvFiles.Columns[6].Visible = showFields;
        }

        private void gvFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gvFiles.IsCurrentCellInEditMode)
            {
                if (e.KeyCode == Keys.Back) btnBack_Click(null, null);
                if (e.KeyCode == Keys.F4) btnRefresh_Click(null, null);

                if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                {
                    Clipboard.SetText(gvFiles.SelectedCells[2].Value.ToString(), TextDataFormat.Text);
                    e.Handled = true;
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            gvFiles.Rows.Clear();
            for (int i = 0; i < dtFilter.Rows.Count; i++)
            {
                if (dtFilter.Rows[i][2].ToString().ToUpper().Contains(txtFilter.Text.ToUpper()) 
                    || txtFilter.Text.Length < 1)
                {
                    if (!Directory.Exists(dtFilter.Rows[i][3].ToString()))
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            Icon.ExtractAssociatedIcon(dtFilter.Rows[i][3].ToString()),
                            dtFilter.Rows[i][2], dtFilter.Rows[i][3], dtFilter.Rows[i][4],
                            dtFilter.Rows[i][5], dtFilter.Rows[i][6], dtFilter.Rows[i][7]);
                    }
                    else
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            LFI.Properties.Resources.folder,
                            dtFilter.Rows[i][2], dtFilter.Rows[i][3], dtFilter.Rows[i][4],
                            dtFilter.Rows[i][5], dtFilter.Rows[i][6], dtFilter.Rows[i][7]);
                    }
                }
            }
            LoadFormatFields();
        }

        private void gvFiles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            gvFiles.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void gvFiles_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            gvFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ddFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadFormatFields();
        }
    }
}
