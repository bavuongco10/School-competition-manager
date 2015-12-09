using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;

namespace OOP
{
    public partial class HoatDongCuocThiHome : XtraUserControl
    {
        public HoatDongCuocThiHot HoatDongCuocThiHot;
        public HoatDongCuocThiOnGoing HoatDongCuocThiOnGoing;
        public EventHandler HoatDongDetailInvoke;
        public HoatDongCuocThiHome()
        {
            InitializeComponent();

            tableLayoutPanel1.AutoSize = true;

            var hotLabel = SetLabel("Hoạt động - Cuộc thi đang HOT", true);
            HoatDongCuocThiHot = new HoatDongCuocThiHot();
            HoatDongCuocThiHot.tileView1.ItemClick += TileView1OnItemClick;

            var onGoingLabel = SetLabel("Hoạt động - Cuộc thi đang diễn ra");

            HoatDongCuocThiOnGoing = new HoatDongCuocThiOnGoing();
            HoatDongCuocThiOnGoing.tileView1.ItemClick += TileView1OnItemClick;

            var button4 = new Button
            {
                Size = new Size(1, 800)
            };
            button4.Text = button4.Size.Height.ToString();


            tableLayoutPanel1.Controls.Add(hotLabel, 0, 0);
            hotLabel.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(HoatDongCuocThiHot, 0, 1);
            HoatDongCuocThiHot.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(onGoingLabel, 0, 2);
            onGoingLabel.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(HoatDongCuocThiOnGoing, 0, 3);
            HoatDongCuocThiOnGoing.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(button4, 0, 4);
            button4.Dock = DockStyle.Fill;
        }

        private void TileView1OnItemClick(object sender, TileViewItemClickEventArgs e)
        {
            var maHoatDong = HoatDongCuocThiHot.tileView1.GetRowCellValue(e.Item.RowHandle,"MaHoatDong").ToString();
            var hoatDong = new HoatDong() { MaHoatDong = int.Parse(maHoatDong)};
            HoatDongDetailInvoke(hoatDong, EventArgs.Empty);
        }

        private static LabelAndText70 SetLabel(string description, bool more = false)
        {
            var label = new LabelAndText70();
            if (more)
            {
                label.lbnMore.Hide();
            }
            label.lbnDescription.Text = description;
            label.Size = new Size(1, 70);
            return label;
        }

        private void xtraScrollableControl1_Click(object sender, EventArgs e)
        {
        }
    }
}