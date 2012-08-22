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
    public partial class contentsPane : UserControl
    {
        public bool active = false;
        public contentsPane()
        {
            InitializeComponent();
        }

        public void Disable()
        {
            active = false;
            this.Hide();
        }

        public void Enable()
        {
            active = true;
            this.Show();
        }

        public void load_data(string sel)
        {
            gvDisc.Rows.Clear();
            try
            {
                DataTable temp = DB_Handle.GetDataTable(string.Format(
                    @"Select disc_contents.location_id, disc_contents.disc_id, discs.page_number,
                    discs.slot_number, contents.season, contents.rangeStart,
                    contents.rangeEnd from discs INNER JOIN disc_contents
                    ON discs.disc_id = disc_contents.disc_id INNER JOIN 
                    contents ON disc_contents.content_id = contents.content_id
                    WHERE contents.title_id={0}",
                    "\"" + sel + "\""));

                if (temp.Rows.Count > 0)
                {
                    for (int i = 0; i <= temp.Rows.Count - 1; i++)
                    {
                        gvDisc.Rows.Add(temp.Rows[i][0],
                            temp.Rows[i][1], temp.Rows[i][2], temp.Rows[i][3],
                            temp.Rows[i][4], temp.Rows[i][5], temp.Rows[i][6]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Error");
            }
        }
    }
}
