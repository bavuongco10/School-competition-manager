using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OOP.QuanLyHoatDong
{
    public partial class QuanLyHoatDong : XtraUserControl
    {
        protected Filter filter;
        private string _maSinhVien;
        public QuanLyHoatDong(string maSinhVien)
        {
            InitializeComponent();
            _maSinhVien = maSinhVien;
            InitControls();
            InitEvents();
        }

        protected QuanLyHoatDong()
        {
            InitializeComponent();InitControls();
            InitEvents();
         }

        public virtual void InitEvents()
        {
            filter.HoatDongDetailInvoke += HoatDongDetailInvoke;
        }


        private void InitControls()
        {
            filter = new Filter();
            groupControlContent.Controls.Add(filter);
            filter.Dock = DockStyle.Fill;
            
        }

        private void HoatDongDetailInvoke(object sender, EventArgs eventArgs)
        {
            DisposeControl();
            var detail = new HoatDongDetail(sender as HoatDong, true, _maSinhVien);
            DockControl(detail);
        }

        public virtual void DockControl(Control detail)
        {
            groupControlContent.Controls.Add(detail);
            detail.Dock = DockStyle.Fill;
        }

        protected virtual void DisposeControl()
        {
            for (var i = 0; i < groupControlContent.Controls.Count; i++)
            {
                groupControlContent.Controls.RemoveAt(i);
            }
        }
    }
}