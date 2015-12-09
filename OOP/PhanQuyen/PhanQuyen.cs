using System;
using System.Windows.Forms;

namespace OOP
{
    public partial class PhanQuyen : QuanLyHoatDong.QuanLyHoatDong
    {
        public PhanQuyen() : base()
        {
            InitializeComponent();
            InitEvents();
        }


        public override void InitEvents()
        {
            filter.HoatDongDetailInvoke += HoatDongDetailInvoke;
        }

        private void HoatDongDetailInvoke(object sender, EventArgs eventArgs)
        {
            DisposeControl();
            var phanQuyenHoatDong = new PhanQuyen1HoatDong.PhanQuyen1HoatDong(sender as HoatDong);
            DockControl(phanQuyenHoatDong);
        }

        protected override void DisposeControl()
        {
            base.DisposeControl();
        }

        public override void DockControl(Control detail)
        {
            base.DockControl(detail);
        }
    }
}