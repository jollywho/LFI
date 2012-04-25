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
    public partial class discPane : UserControl
    {
        public bool active = false;
        public discPane()
        {
            InitializeComponent();
        }

        public void disable()
        {
            active = false;
            this.Hide();
        }

        public void enable()
        {
            active = true;
            this.Show();
        }

        public void load_data(string sel)
        {
            try
            {
                DataTable info = DB_Handle.GetDataTable(string.Format(
                    @"Select discs.disc_id AS 'Disc', disc_contents.range AS 'Range', 
                discs.page_number AS 'Page Number', discs.location_id AS 'Location',
                disc_contents.season AS 'Season'
                FROM discs natural join disc_contents WHERE title_id='{0}'
                ORDER BY discs.disc_id ASC, disc_contents.range ASC",
                sel));
                gvDisc.DataSource = info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Error");
            }
        }

        /*
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
         * */
    }
}
