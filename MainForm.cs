using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"../../data");
            UserControl1 us = new UserControl1();
            mainPanel.Controls.Add(us);
        }
    }
    
}
