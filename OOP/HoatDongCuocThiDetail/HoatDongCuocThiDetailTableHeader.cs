using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace OOP
{
    public partial class HoatDongCuocThiDetailTableHeader : XtraUserControl
    {
        private HoatDongUEHEntities _database = new HoatDongUEHEntities();
        private readonly bool _editable;
        private readonly HoatDong _hoatDong;
        private string _maSinhVien;
        public HoatDongCuocThiDetailTableHeader(HoatDong hoatDong, bool editable,string maSinhVien)
        {
            _maSinhVien = maSinhVien;
            _editable = editable;
            InitializeComponent();
            _hoatDong = hoatDong;
            SetBackColor(Color.FromArgb(15, 44, 85));
            var alreadyBuy =
                _database.HoatDongConNguois.Any(
                    o => o.ConNguoi.MaSinhVien == maSinhVien && o.MaHoatDong == hoatDong.MaHoatDong);
            if (alreadyBuy || editable)
            {
                btnAccepted.Enabled = false;
            }
            InitControls();

            if (!btnAccepted.Enabled)
            {
                btnAccepted.Text = "Đã mua";
            }
        }

        private void SetBackColor(Color color)
        {
            BackColor = color;
            imageSlider.BackColor = color;
            groupControl1.BackColor = color;
            groupControl2.BackColor = color;
            txtTenHoatDong.Properties.AppearanceReadOnly.BackColor = color;
            txtDonVi.Properties.AppearanceReadOnly.BackColor = color;
            txtTenNhomHoatDong.Properties.AppearanceReadOnly.BackColor = color;
            txtPrice.Properties.AppearanceReadOnly.BackColor = color;

            txtTenHoatDong.Properties.Appearance.BackColor = color;
            txtDonVi.Properties.Appearance.BackColor = color;
            txtTenNhomHoatDong.Properties.Appearance.BackColor = color;
            txtPrice.Properties.Appearance.BackColor = color;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void InitControls()
        {
            try
            {
                txtTenHoatDong.Properties.ReadOnly = !_editable;
                txtTenNhomHoatDong.Properties.ReadOnly = !_editable;
                txtDonVi.Properties.ReadOnly = !_editable;
                txtPrice.Properties.ReadOnly = !_editable;

                txtTenHoatDong.Text = _hoatDong.TenHoatDong;
                txtDonVi.Text = _hoatDong.DonVi.TenDonVi;
                txtTenNhomHoatDong.Text = _hoatDong.NhomHoatDong.TenNhomHoatDong;
                rating.Rating = (decimal) _hoatDong.DiemDanhGia.Value;
                lbnRatingCount.Text = lbnRatingCount.Text.Replace("00", _hoatDong.SLSV.ToString());
                txtPrice.Text = string.Format("{0:C2}", _hoatDong.GiaVe);
                imageSlider.Images.Add(Image.FromStream(new MemoryStream(_hoatDong.Picture)));
            }
            catch (Exception)
            {
                }
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(_hoatDong.MaHoatDong);
            var dialogResult = XtraMessageBox.Show("Yes or Not?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    btnAccepted.Text = "Đã mua";
                    btnAccepted.Enabled = false;
                    _database.HoatDongConNguois.Add(new HoatDongConNguoi()
                    {
                        MaHoatDong = _hoatDong.MaHoatDong,
                        MaConNguoi = _database.ConNguois.FirstOrDefault(o => o.MaSinhVien == _maSinhVien).MaConNguoi,
                        MaVaiTro = 5
                    });
                    _database.SaveChanges();
                    SplashScreenManager.ShowForm(typeof (WaitForm1));
                    ticket.ShowDialog();
                    SplashScreenManager.CloseForm();
                }
                catch (Exception)
                {
                    
                }
            }
        }
    }
}