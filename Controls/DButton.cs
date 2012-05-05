using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace LFI
{
    public partial class DButton : System.Windows.Forms.Button
    {
        public VLabel vlbl = new VLabel();
        public string Disc = string.Empty;
        public int Page = 0;
        public int Slot = 0;
        discView Caller;

        public DButton(Label copyLabel, Point loc, discView caller) 
        {
            InitializeComponent();

            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Location = loc;
            Size = new System.Drawing.Size(150, 150);
            TabIndex = 94;
            TabStop = false;
            UseVisualStyleBackColor = true;
            Visible = true;

            createVertLabel(copyLabel, "");
            Caller = caller;
        }

        public void load(DataTable dt)
        {
            if (dt.Rows.Count != 0)
                setData(dt.Rows[0][0], dt.Rows[0][1], dt.Rows[0][2]);
            else
                setData(0, 0, 0);
        }

        public void setVisibility(bool vis)
        {
            Visible = vis;
            vlbl.Visible = vis;
        }

        private void setData(object disc, object page, object slot)
        {
            Disc = disc.ToString();
            Page = Convert.ToInt32(page);
            Slot = Convert.ToInt32(slot);
            vlbl.Text = Disc;
        }

        private void createVertLabel( Label copylabel, string text)
        {
            vlbl.Text = text;
            vlbl.Font = copylabel.Font;
            vlbl.ForeColor = copylabel.ForeColor;
            vlbl.Size = new System.Drawing.Size(18, base.Height);
            Point point = Location;
            point.X -= vlbl.Size.Width;
            vlbl.Location = point;
            vlbl.Visible = true;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Caller.popContentPane();

            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"Select discs.disc_id, discs.page_number, discs.slot_number,
                contents.title_id, contents.season, contents.rangeStart,
                contents.rangeEnd, disc_contents.content_id from discs
                INNER JOIN disc_contents ON discs.disc_id = 
                disc_contents.disc_id INNER JOIN contents on
                disc_contents.content_id = contents.content_id WHERE
                discs.disc_id='{0}'", Disc));

            if (temp.Rows.Count > 0)
            {
                Caller.isNewRecord = false;
                Caller.setData(temp.Rows[0][0], temp.Rows[0][1], temp.Rows[0][2]);
                for (int i = 0; i <= temp.Rows.Count - 1; i++)
                {
                    Caller.getContentsGrid().Rows.Add(temp.Rows[i][3], temp.Rows[i][4],
                        temp.Rows[i][5], temp.Rows[i][6], temp.Rows[i][7]);
                }
            }
            else
            {
                Caller.isNewRecord = true;
                Caller.setData(string.Empty, string.Empty, string.Empty);
            }

            Caller.setImagebox(Image_IO.generateDiscImage(Disc, this));
        }

    }
}
