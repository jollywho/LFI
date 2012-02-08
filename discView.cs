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
        static public bool active = false;

        public discView(string sel_title)
        {
            InitializeComponent();
            DataTable info = DB_Handle.GetDataTable(string.Format(
                @"Select discs.disc_id AS 'Disc', disc_titles.range AS 'Range', 
                discs.page_number AS 'Page Number', discs.location_id AS 'Location'
                FROM discs natural join disc_titles WHERE title_id='{0}'
                ORDER BY discs.disc_id ASC, disc_titles.range ASC",
                sel_title));
            gvDisc.DataSource = info;
            lblDisc.Text = sel_title;
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

        private void discView_ControlAdded(object sender, ControlEventArgs e)
        {
            active = true;
        }

        private void discView_ControlRemoved(object sender, ControlEventArgs e)
        {
            active = false;
        }

        private void gvDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                mainView mv = new mainView();
                this.Parent.Controls.Add(mv);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
