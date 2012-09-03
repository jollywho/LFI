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
        int editRow = 0;
        int dragRow = -1;
        int dragFromMouseIndex = 0;
        int insertRow = 0;
        Rectangle dragFromMouse;
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

            animation.Image = LFI.Properties.Resources.progress;
            animation.Width = 16;
            animation.Height = 16;
            animation.BackColor = Color.Transparent;
            animation.Hide();
            gvFiles.Controls.Add(animation);

            Dictionary<EPFORMAT, string> choices = new Dictionary<EPFORMAT, string>();
            choices.Add(EPFORMAT.REG_NUM, "{##}");
            choices.Add(EPFORMAT.ALL_NUM, "{##}{##}");
            choices.Add(EPFORMAT.NUM_X_NUM, "{##}x{##}");
            choices.Add(EPFORMAT.S_NUM_E_NUM, "S{##}E{##}");
            ddFormat.DataSource = new BindingSource(choices, null);
            ddFormat.DisplayMember = "Value";
            ddFormat.ValueMember = "Key";
            choices.Remove(EPFORMAT.ALL_NUM);
            ddFormat_Use.DataSource = new BindingSource(choices, null);
            ddFormat_Use.DisplayMember = "Value";
            ddFormat_Use.ValueMember = "Key";
            toolStrip1.Renderer = new TSystemRenderer();
            gvFiles.AlternatingRowsDefaultCellStyle = null;
            for (int i = 0; i < gvFiles.Columns.Count; i++)
                dtFilter.Columns.Add("Col_" + i.ToString());

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
            Console.WriteLine("OPEN");
            try
            {
                folder = new Folder_IO(ddUrl.Text);
                fileWatcher.Path = ddUrl.Text;
                countFolders();
                btnShowDiv.Enabled = true;
                btnDivide.Enabled = false;
                dirname = ddUrl.Text;
                lstDivs_Click(null, null);
                txtFilter.Enabled = true;
                dragRow = -1; savedRow = 0;
                if (showFields) LoadFormatFields();
            }
            catch (Exception ex)
            {
                BetterDialog.ShowDialog("", "Error : " + ex.Message, "", "", "OK", null, BetterDialog.ImageStyle.Icon);
            }
        }

        /// <summary>
        /// Refresh gridview and reselect rowindex.
        /// </summary>
        private void refresh_Folder()
        {
            if (gvFiles.Rows.Count > 1)
            {
                refreshRow = gvFiles.SelectedCells[0].RowIndex + insertRow;
                refreshRow = refreshRow < 0 ? 0 : refreshRow;
                refreshIndex = gvFiles.FirstDisplayedScrollingRowIndex;
            }
            else if (gvFiles.IsCurrentCellInEditMode)
                refreshRow = editRow;
            else
                refreshRow = 0;
   
            open_Folder();
            
            if (txtFilter.Text.Length >= 1)
                txtFilter_TextChanged(null, null);
            if (gvFiles.Rows.Count < 1) return;

            gvFiles.Rows[refreshRow].Cells[2].Selected = true;
            gvFiles.FirstDisplayedScrollingRowIndex = refreshIndex;
            insertRow = 0; 
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
                txtFilter.Clear();
                txtFilter.Enabled = false;
                countFolders();
                btnDivide.Enabled = true;
                lstDivs_Click(sender, e);
            }
        }

        /// <summary>
        /// Clear gridview and load with files from selected division.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstDivs_Click(object sender, EventArgs e)
        {
            if (!Crc32.worker.IsBusy)
            {
                gvFiles.DataSource = null;
                gvFiles.Rows.Clear();
                dtFilter.Clear();
                if (folder.GetItemCount() > 0)
                {
                    int sel = Convert.ToInt32(lstDivs.Text); //division selection

                    if (lstDivs.Text == "0")
                    {
                        LoadGridView(sel);
                    }
                    else
                    {
                        LoadGridView_WithDivisions(sel);
                    }
                    gvFiles.Focus();
                }
            }
        }

        /// <summary>
        /// Load files into gridview with default images.
        /// Does not copy to a filter table.
        /// </summary>
        /// <param name="sel">The selected division number.</param>
        private void LoadGridView_WithDivisions(int sel)
        {
            caller.SetLabelSize(folder.Get_Folder_Size(sel, false));
            caller.SetLabelItemCount(folder.folderitems.Count);
            for (int i = 0; i <= folder.folderDivisions[sel - 1].Count - 1; i++)
            {
                gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                    NativeMethods.GetSmallIcon(folder.filenames[i]),
                    Path.GetFileName(folder.folderDivisions[sel - 1][i]),
                    folder.folderDivisions[sel - 1][i]
                );
            }
        }
        
        /// <summary>
        /// Load all folders and files into gridview with default images.
        /// Copies data to a filter table except for image columns.
        /// </summary>
        /// <remarks>
        /// Stores simple rowID in final column for key-access when updating filter.
        /// </remarks>
        /// <param name="sel">The selected division number.</param>
        private void LoadGridView(int sel)
        {
            int row = 0;
            caller.SetLabelSize(folder.Get_Folder_Size(sel, true));
            caller.SetLabelItemCount(folder.folderitems.Count);
            for (int i = 0; i <= folder.subdiritems.Count - 1; i++, row++)
            {
                gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                   LFI.Properties.Resources.folder,
                   Path.GetFileName(folder.subdiritems[i]), folder.subdiritems[i], null, null, null, null, row.ToString());
                dtFilter.Rows.Add(null, null, Path.GetFileName(folder.subdiritems[i]), folder.subdiritems[i], null, null, null, null, row.ToString());
            }
            for (int i = 0; i <= folder.folderitems.Count - 1; i++, row++)
            {
                gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                    NativeMethods.GetSmallIcon(folder.filenames[i]),
                    Path.GetFileName(folder.folderitems[i]),
                    folder.filenames[i], null, null, null, null, row.ToString());
                dtFilter.Rows.Add(null, null, Path.GetFileName(folder.folderitems[i]), folder.filenames[i], null, null, null, null, row.ToString());
            }
        }

        private void LoadFormatFields()
        {
            if (!showFields || multiRun)
            {
                Console.WriteLine("----DENIED");
                return;
            }
            Console.WriteLine("----FORMATS");
            for (int i = 0; i < gvFiles.RowCount; i++)
            {
                if (!Directory.Exists(gvFiles.Rows[i].Cells[3].Value.ToString()))
                {
                    FileNameFormat fn = new FileNameFormat(gvFiles.Rows[i].Cells[2].Value.ToString(), (EPFORMAT)ddFormat.SelectedValue);
                    gvFiles.Rows[i].Cells[4].Value = fn.EstimateGroup();
                    gvFiles.Rows[i].Cells[5].Value = fn.EstimateSeason();
                    gvFiles.Rows[i].Cells[6].Value = fn.EstimateEpisode();
                    gvFiles.Rows[i].Cells[7].Value = fn.EstimateCRC();
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

           // if (lstDivs.Text == "0")
           //     folder.folderitems[workingRow] = ddUrl.Text + "\\" + newfilename;
           // else
           //     folder.folderDivisions[Convert.ToInt32(lstDivs.Text) - 1][workingRow] =
           //         ddUrl.Text + "\\" + newfilename;

            DisableRunButtons();
            Add_MultiRunIncrement();
        }
        
        private void Add_MultiRunIncrement()
        {
            if (multiRun && workingRow < gvFiles.Rows.Count - 1 && !cancel)
            {
                fileWatcher.EnableRaisingEvents = false;
                workingRow++;
                AddCRC();
                fileWatcher.EnableRaisingEvents = true;
                LoadFormatFields();
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

        private void EnableRunButtons()
        {
            btnCancel.Enabled = true;
            btnRunFormats.Enabled = false;
            btnShowDiv.Enabled = false;
            btnCheckCRC.Enabled = false;
            btnAddCRC.Enabled = false;
            btnShowEstimates.Enabled = false;
            btnRemoveCRC.Enabled = false;
            btnPartFiles.Enabled = false;
            btnMarkFiles.Enabled = false;
            lstDivs.Enabled = false;
            ddUrl.Enabled = false;
            txtFilter.Enabled = false;
        }

        private void DisableRunButtons()
        {
            btnCancel.Enabled = false;
            btnShowDiv.Enabled = true;
            btnCheckCRC.Enabled = true;
            btnAddCRC.Enabled = true;
            btnShowEstimates.Enabled = true;
            btnRemoveCRC.Enabled = true;
            btnPartFiles.Enabled = true;
            btnMarkFiles.Enabled = true;
            lstDivs.Enabled = true;
            ddUrl.Enabled = true;
            txtFilter.Enabled = true;
            btnRunFormats.Enabled = showFields;
        }

        private void CheckCRC()
        {
            string fullfilename = gvFiles.Rows[workingRow].Cells[3].Value.ToString();
            if (!Directory.Exists(fullfilename))
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
            else
                Add_MultiRunIncrement();
        }

        private void AddCRC()
        {
            string fullfilename = gvFiles.Rows[workingRow].Cells[3].Value.ToString();
            if (!Folder_IO.IsCRC(fullfilename) && !Directory.Exists(fullfilename))
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
        #endregion WORKER

        void gvFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (gvFiles.RowCount < 1) return;
            animation.Location = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Location;
            animation.Width = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Width;
            animation.Height = gvFiles.GetCellDisplayRectangle(0, workingRow, true).Height;
        }

        /// <summary>
        /// Sets savedRow to selected rowindex of gridview.
        /// Sets LabelItemSize to selected row's item file size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gvFiles.SelectedCells.Count > 0)
            {
                if (gvFiles.SelectedCells[0].Value != null && !multiRun)
                {
                    if (!multiRun)
                        savedRow = gvFiles.SelectedCells[0].RowIndex;
                    caller.SetLabelItemSize(Folder_IO.Get_Item_Size(gvFiles.SelectedCells[3].Value.ToString()));
                }
            }
            else
                caller.SetLabelItemSize(" ");
        }

        /// <summary>
        /// Commit shown divisions and move files into divisioned subdirectories.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void ddUrl_ChangeText(string url)
        {
            ddUrl.ComboBox.SelectedValueChanged -= new EventHandler(ddUrl_SelectedValueChanged);
            ddUrl.ComboBox.Text = url;
            ddUrl.ComboBox.SelectedValueChanged += new EventHandler(ddUrl_SelectedValueChanged);
        }

        private void ddUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                open_Folder();
            }
            
        }

        /// <summary>
        /// Move up one directory and refresh.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            ddUrl_ChangeText(Directory.GetParent(ddUrl.Text).FullName);
            txtFilter.Clear();
            open_Folder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel_MultiRun();
        }

        /// <summary>
        /// Flag worker to start adding CRC.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Flag worker to start checking CRC.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Disable mousewheel for given dropdown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combobox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        /// <summary>
        /// Loads a folder into the gridview or launches a file with its default application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex == 2)
            {
                if (Directory.Exists(gvFiles.SelectedCells[3].Value.ToString()))
                {
                    ddUrl_ChangeText(gvFiles.SelectedCells[3].Value.ToString());
                    txtFilter.Clear();
                    open_Folder();
                }
                else
                    if (File.Exists(gvFiles.SelectedCells[3].Value.ToString()))
                        Process.Start(gvFiles.SelectedCells[3].Value.ToString());
            }
        }

        /// <summary>
        /// Remove part file extension from selected or all files.
        /// </summary>
        /// <remarks>
        /// Updated fields are saved to the filter table.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPartFiles_Click(object sender, EventArgs e)
        {
            if (radCheckAll.Checked)
            {
                for (int i = 0; i < gvFiles.Rows.Count; i++)
                {
                    FileInfo file = new FileInfo(gvFiles.Rows[i].Cells[3].Value.ToString());
                    Folder_IO.FixExtension(file);
                    Copy_Cells(Convert.ToInt32(gvFiles.Rows[i].Cells[8].Value), i);
                }
            }
            else
            {
                FileInfo file = new FileInfo(gvFiles.SelectedCells[3].Value.ToString());
                Folder_IO.FixExtension(file);
                Copy_Cells(Convert.ToInt32(gvFiles.SelectedCells[8].Value), gvFiles.SelectedCells[0].RowIndex);
            }
        }
        
        /// <summary>
        /// Remove checksum from selected or all files.
        /// </summary>
        /// <remarks>
        /// Updated fields are saved to the filter table.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveCRC_Click(object sender, EventArgs e)
        {
            if (radCheckAll.Checked)
            {
                fileWatcher.EnableRaisingEvents = false;
                for (int i = 0; i < gvFiles.Rows.Count; i++)
                {
                    string newfilename = string.Empty;
                    gvFiles.Rows[i].Cells[3].Value =
                        Folder_IO.RemoveCRC(gvFiles.Rows[i].Cells[3].Value.ToString(),
                        out newfilename);
                    dtFilter.Rows[i][0] = newfilename;
                    dtFilter.Rows[i][1] = gvFiles.Rows[i].Cells[3].Value;
                    gvFiles.Rows[i].Cells[2].Value = newfilename;
                    Copy_Cells(Convert.ToInt32(gvFiles.Rows[i].Cells[8].Value), i);
                }
                fileWatcher.EnableRaisingEvents = true;
                LoadFormatFields();
            }
            else
            {
                string newfilename = string.Empty;
                gvFiles.SelectedCells[3].Value =
                    Folder_IO.RemoveCRC(gvFiles.SelectedCells[3].Value.ToString(),
                    out newfilename);
                //
                gvFiles.SelectedCells[2].Value = newfilename;
                Copy_Cells(Convert.ToInt32(gvFiles.SelectedCells[8].Value), gvFiles.SelectedCells[0].RowIndex);
            }
        }

        /// <summary>
        /// Update filenames from selected or all files using gridview row data and txtTitle.
        /// </summary>
        /// <remarks>
        /// Updated fields are saved to the filter table.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunFormats_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length < 1)
                MessageBox.Show("Rename Error: Title required.\n");
            else
            {
                if (radCheckAll.Checked)
                {
                    fileWatcher.EnableRaisingEvents = false;
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
                            gvFiles.Rows[i].Cells[7].Value.ToString(),
                            (EPFORMAT)ddFormat_Use.SelectedValue,
                            out newfilename, out skipped);
                        gvFiles.Rows[i].Cells[2].Value = newfilename;
                        Copy_Cells(Convert.ToInt32(gvFiles.Rows[i].Cells[8].Value), i);
                        if (skipped)
                            gvFiles.Rows[i].Cells[0].Value = LFI.Properties.Resources.Warning;
                    }
                    fileWatcher.EnableRaisingEvents = true;
                    LoadFormatFields();
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
                        gvFiles.SelectedCells[7].Value.ToString(),
                        (EPFORMAT)ddFormat_Use.SelectedValue,
                        out newfilename, out skipped);
                    gvFiles.SelectedCells[2].Value = newfilename;
                    Copy_Cells(Convert.ToInt32(gvFiles.SelectedCells[8].Value), gvFiles.SelectedCells[0].RowIndex);
                    
                    if (skipped)
                        gvFiles.SelectedCells[0].Value = LFI.Properties.Resources.Warning;
                }
            }
        }

        /// <summary>
        /// Copy contents of rowindex to filter table.
        /// </summary>
        /// <param name="p_rowindex"></param>
        /// <param name="f_rowindex"></param>
        private void Copy_Cells(int p_rowindex, int f_rowindex)
        {
            for (int i = 0; i < gvFiles.Columns.Count; i++)
                dtFilter.Rows[p_rowindex][i] = gvFiles.Rows[f_rowindex].Cells[i].Value;
        }

        /// <summary>
        /// Shows or hides estimates fields on gridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            gvFiles.Columns[7].Visible = showFields;
        }

        private void gvFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gvFiles.IsCurrentCellInEditMode)
            {
                if (e.KeyCode == Keys.Back) btnBack_Click(null, null);
                if (e.KeyCode == Keys.F5) refresh_Folder();
                if (e.KeyCode == Keys.Delete) Folder_IO.DeleteFile(gvFiles.SelectedCells[3].Value.ToString());

                //Prevent fullrow copy and use only the filename.
                if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                {
                    Clipboard.SetText(gvFiles.SelectedCells[2].Value.ToString(), TextDataFormat.Text);
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Add to gridview any filename that contains txtFilter from the filter table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            gvFiles.Rows.Clear();
            dragFromMouseIndex = -1;
            savedRow = 0;
            for (int i = 0; i < dtFilter.Rows.Count; i++)
            {
                if (dtFilter.Rows[i][2].ToString().ToUpper().Contains(txtFilter.Text.ToUpper()) 
                    || txtFilter.Text.Length < 1)
                {
                    if (!Directory.Exists(dtFilter.Rows[i][3].ToString()))
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            NativeMethods.GetSmallIcon(dtFilter.Rows[i][3].ToString()),
                            dtFilter.Rows[i][2], dtFilter.Rows[i][3], dtFilter.Rows[i][4],
                            dtFilter.Rows[i][5], dtFilter.Rows[i][6], dtFilter.Rows[i][7],
                            dtFilter.Rows[i][8]);
                    }
                    else
                    {
                        gvFiles.Rows.Add(LFI.Properties.Resources.empty,
                            LFI.Properties.Resources.folder,
                            dtFilter.Rows[i][2], dtFilter.Rows[i][3], dtFilter.Rows[i][4],
                            dtFilter.Rows[i][5], dtFilter.Rows[i][6], dtFilter.Rows[i][7],
                            dtFilter.Rows[i][8]);
                    }
                }
            }
            if (showFields)
                btnShowEstimates.PerformClick();
        }

        private void gvFiles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editRow = e.RowIndex;
            //gvFiles.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void gvFiles_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            gvFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ddFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadFormatFields();
        }

        private void fileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            if (multiRun) return;
            insertRow = 1;
            refresh_Folder();
        }
        
        private void fileWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (multiRun) return;
            refresh_Folder();
            Console.WriteLine(e.FullPath + ": " + e.ChangeType);
        }

        private void fileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (multiRun) return;
            insertRow = -1;
            refresh_Folder();
            Console.WriteLine(e.FullPath + ": " + e.ChangeType);
        }

        private void gvFiles_DragDrop(object sender, DragEventArgs e)
        {
            if (dragRow == -1) return;
            string files = (string)e.Data.GetData(DataFormats.Text);
            Console.WriteLine(files);
            Point p = gvFiles.PointToClient(new Point(e.X, e.Y));
            int row = gvFiles.HitTest(p.X, p.Y).RowIndex;
            gvFiles.AllowDrop = false;
            gvFiles.Rows[dragRow].Selected = true;
            Folder_IO.MoveFileTo(files, gvFiles.Rows[dragRow].Cells[3].Value.ToString());
        }

        private void gvFiles_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragRow == -1) return;
            if (Directory.Exists(gvFiles.Rows[dragRow].Cells[3].Value.ToString()))
                gvFiles.Rows[dragRow].Cells[1].Value = LFI.Properties.Resources.folder;
        }

        private void gvFiles_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            int oldrow = dragRow;
            Point p = gvFiles.PointToClient(new Point(e.X, e.Y));
            dragRow = gvFiles.HitTest(p.X, p.Y).RowIndex;
            if (dragRow == -1 || oldrow == -1) return;
            if (dragRow != oldrow)
            {
                if (Directory.Exists(gvFiles.Rows[dragRow].Cells[3].Value.ToString()))
                    gvFiles.Rows[dragRow].Cells[1].Value = LFI.Properties.Resources.folder_open;
                if (Directory.Exists(gvFiles.Rows[oldrow].Cells[3].Value.ToString()))
                    gvFiles.Rows[oldrow].Cells[1].Value = LFI.Properties.Resources.folder;
            }
        }

        private void gvFiles_MouseMove(object sender, MouseEventArgs e)
        {
            if (gvFiles.SelectedRows.Count < 1 || dragFromMouseIndex == -1) return;
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;
            gvFiles.Rows[dragFromMouseIndex].Selected = true;
            gvFiles.AllowDrop = true;

            // If the mouse moves outside the rectangle, start the drag.
            if (dragFromMouse != Rectangle.Empty &&
                !dragFromMouse.Contains(e.X, e.Y))
            {
                gvFiles.DoDragDrop(gvFiles.SelectedCells[3].Value, DragDropEffects.Move);
            } 
        }

        private void gvFiles_MouseDown(object sender, MouseEventArgs e)
        {
            dragFromMouseIndex = gvFiles.HitTest(e.X, e.Y).RowIndex;
            if (dragFromMouseIndex != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragFromMouse = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                    e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                dragFromMouse = Rectangle.Empty;
        }

        private void btnMarkFiles_Click(object sender, EventArgs e)
        {
            FileMarkerDialog.ShowDialog(ddUrl.Text,
                new FileNameFormat(gvFiles.SelectedCells[2].Value.ToString(),
                    (EPFORMAT)ddFormat.SelectedValue));
        }
    }
}
