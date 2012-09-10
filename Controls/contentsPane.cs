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
        private MainForm caller;
        public bool active = false;
        public contentsPane(MainForm main)
        {
            caller = main;
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
                    @"Select 
                        disc_contents.location_id, 
                        disc_contents.disc_id, 
                        discs.page_number,
                        discs.slot_number, 
                        contents.season, 
                        contents.rangeStart,
                        contents.rangeEnd 
                    FROM contents 
                    INNER JOIN disc_contents ON contents.content_id = disc_contents.content_id
                    INNER JOIN discs ON discs.disc_id = disc_contents.disc_id 
                    WHERE contents.title_id={0} AND discs.location_id=disc_contents.location_id",
                    "\"" + sel + "\""));

                if (temp.Rows.Count > 0)
                {
                    for (int i = 0; i <= temp.Rows.Count - 1; i++)
                    {
                        for (int k=0; k<= temp.Columns.Count - 1; k++)
                            Console.WriteLine(temp.Rows[i][k].ToString());
                        gvDisc.Rows.Add(temp.Rows[i][0],
                            temp.Rows[i][1], temp.Rows[i][2], temp.Rows[i][3],
                            temp.Rows[i][4], temp.Rows[i][5], temp.Rows[i][6]);
                    }
                }
            }
            catch (Exception ex)
            {
                BetterDialog.ShowDialog("DB Error", ex.Message, "", "", "OK", null, BetterDialog.ImageStyle.Icon);
            }
        }

        private void gvDisc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string location = gvDisc.SelectedRows[0].Cells[0].Value.ToString();
            string disc = gvDisc.SelectedRows[0].Cells[1].Value.ToString();
            string page = gvDisc.SelectedRows[0].Cells[2].Value.ToString();
            caller.OpenDiscViewAt(location, page, disc);
        }
    }
}
