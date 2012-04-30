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
                    @"Select * from discs natural join disc_contents where
                    title_id='{0}' order by title_id", sel));

                if (temp.Rows.Count > 0)
                {
                    for (int i = 0; i <= temp.Rows.Count - 1; i++)
                    {
                        gvDisc.Rows.Add(temp.Rows[i][3],
                            temp.Rows[i][0], temp.Rows[i][1], temp.Rows[i][2],
                            temp.Rows[i][5], temp.Rows[i][6], temp.Rows[i][7]);
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
