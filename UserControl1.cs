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
    public partial class UserControl1 : UserControl
    {
        DataTable dt;

        public UserControl1()
        {
            InitializeComponent();
            dt = DB_Handle.GetDataTable("SELECT * FROM main ORDER BY title");
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i][0]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTitle.Text = dt.Rows[listBox1.SelectedIndex][0].ToString();
            txtEpisode.Text = dt.Rows[listBox1.SelectedIndex][1].ToString();
            txtCategory.Text = dt.Rows[listBox1.SelectedIndex][2].ToString();
            txtYear.Text = dt.Rows[listBox1.SelectedIndex][3].ToString();
            txtStatus.Text = dt.Rows[listBox1.SelectedIndex][4].ToString();
            
        }

    }
}
