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
    public partial class discView : UserControl
    {
        public discView()
        {
            InitializeComponent();
            DataTable info = DB_Handle.GetDataTable("Select * from loc");
            gvDisc.DataSource = info;
            lblDisc.Text = info.TableName;
        }

        private void btbCRC_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    Crc32 crc32 = new Crc32();
                    String hash = String.Empty;
                    using (FileStream fs = File.Open(dlg.FileName, FileMode.Open))
                        foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
