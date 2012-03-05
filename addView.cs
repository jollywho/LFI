using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class addView : UserControl
    {
        public addView()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainView mv = new mainView();
            this.Controls.Clear();
            this.Controls.Add(mv);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lstContents.Items.Add(txtInsTitle.Text + ", " + txtInsRangeStart.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstContents.Items.Count > 0)
                lstContents.Items.RemoveAt(lstContents.SelectedIndex);
        }
    }
}
