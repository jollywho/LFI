﻿using System;
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
        private Folder_IO folder;
        private string dirname;

        public folderView()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainView mv = new mainView();
            this.Controls.Clear();
            this.Controls.Add(mv);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                folder = new Folder_IO(txtURL.Text);
                countFolders();
                btnDivide.Enabled = true;
                btnClear.Enabled = true;
                dirname = txtURL.Text;
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
            txtURL.Clear();
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
    }
}