﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
