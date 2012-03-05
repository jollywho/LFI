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
        mainView caller;

        public mainView Caller
        {
            get { return caller; }
            set { caller = value; }
        }

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

        private void gvDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                caller.Show();
                this.Parent.Controls.Remove(this);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            caller.Show();
            this.Parent.Controls.Remove(this);
        }
    }
}
