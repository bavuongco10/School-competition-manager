using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OOP.HoatDongCuocThi
{
    public partial class HoatDongCuocThi : XtraUserControl
    {
        private string _maSinhVien;
        public HoatDongCuocThi(string maSinhVien)
        {
            InitializeComponent();
            _maSinhVien = maSinhVien;
            tileItem1.OnItemClick();
        }


        private void groupControlContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            DisposeControl();
            var home = new HoatDongCuocThiHome();
            groupControlContent.Controls.Add(home);
            home.Dock = DockStyle.Fill;

            home.HoatDongDetailInvoke += HoatDongDetailInvoke;
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            DisposeControl();
            var filter = new Filter();
            groupControlContent.Controls.Add(filter);
            filter.Dock = DockStyle.Fill;

            filter.HoatDongDetailInvoke += HoatDongDetailInvoke;
        }

        private void HoatDongDetailInvoke(object sender, EventArgs eventArgs)
        {
            DisposeControl();
            var detail = new HoatDongDetail(sender as HoatDong, false,_maSinhVien);
            groupControlContent.Controls.Add(detail);
            detail.Dock = DockStyle.Fill;
        }

        private void DisposeControl()
        {
            for (var i = 0; i < groupControlContent.Controls.Count; i++)
            {
                groupControlContent.Controls.RemoveAt(i);
            }
        }
    }
}