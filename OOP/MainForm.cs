using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace OOP
{
    public partial class MainForm : XtraForm
    {private bool isHide;
        private string _maSinhVien ;
        public MainForm(string maSinhVien)
        {
            InitializeComponent();
            _maSinhVien = maSinhVien;
            InitControl(23, 23, 23);
            groupControlFooter.Hide();
            tileItem1.OnItemClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupControlContent_Paint(object sender, PaintEventArgs e)
        {
        }


        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
        }

        private void InitControl(int x, int y, int z)
        {
            groupControlHeader.BackColor = Color.FromArgb(x, y, z);
            groupControlFooter.BackColor = Color.FromArgb(x, y, z);
            btnMenu.BackColor = Color.FromArgb(x, y, z);
            groupControlNavigator.BackColor = Color.FromArgb(x, y, z);
            GroupControlPersonal.BackColor = Color.FromArgb(x, y, z);
            TileGroupNavigator.BackColor = Color.FromArgb(x, y, z);
            foreach (TileItem control in TileGroupNavigator.Groups[0].Items)
            {
                control.AppearanceItem.Normal.BackColor = Color.FromArgb(x, y, z);
            }

            InitNavigatorItem();
        }

        private void InitNavigatorItem()
        {
            foreach (TileItem control in TileGroupNavigator.Groups[0].Items)
            {
                control.AppearanceItem.Normal.BackColor = Color.FromArgb(23, 23, 23);
                control.AppearanceItem.Hovered.BackColor = Color.FromArgb(46, 46, 46);
                control.AppearanceItem.Pressed.BackColor = Color.FromArgb(9, 81, 138);
                //control.AppearanceItem.Selected.BackColor = Color.FromArgb(9, 81, 138);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (groupControlNavigator.Size.Width == 70)
            {
                isHide = true;
            }
            else
            {
                isHide = false;
            }

            if (isHide)
            {
                //groupControlNavigator.Show();
                groupControlNavigator.Size = new Size(300, 0);
                isHide = false;
            }
            else
            {
                //groupControlNavigator.Hide();
                groupControlNavigator.Size = new Size(70, 0);
                isHide = true;
            }
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var hoatDongCuocThi = new HoatDongCuocThi.HoatDongCuocThi(_maSinhVien);
            InitContent(hoatDongCuocThi);
            SplashScreenManager.CloseForm();
        }
        private void InitContent(Control control)
        {
            for (var i = 0; i < groupControlContent.Controls.Count; i++)
            {
                groupControlContent.Controls.RemoveAt(i);
            }
            groupControlContent.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var quanLyHoatDong = new QuanLyHoatDong.QuanLyHoatDong(_maSinhVien);
            InitContent(quanLyHoatDong);
            SplashScreenManager.CloseForm();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var phanQuyen = new PhanQuyen();
            InitContent(phanQuyen);
            SplashScreenManager.CloseForm();
        }

        private void groupControlContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupControlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var bieudo  = new BieuDo();
            InitContent(bieudo);
            SplashScreenManager.CloseForm();
        }
    }
}