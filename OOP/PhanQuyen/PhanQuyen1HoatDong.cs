using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace OOP.PhanQuyen1HoatDong
{
    public partial class PhanQuyen1HoatDong : DevExpress.XtraEditors.XtraUserControl
    {
        private HoatDongUEHEntities db;
        private HoatDong _hoatDong;
        public PhanQuyen1HoatDong(HoatDong hoatDong)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            _hoatDong = hoatDong;
            InitControls();InitDatabase();
            InitDataSource();
            SplashScreenManager.CloseForm();
        }

        private void InitControls()
        {
            SetLabelAppearance(lbnHoTen);
            SetLabelAppearance(lbnEmail);
            SetLabelAppearance(lbnLopChuyenNganh);
            SetLabelAppearance(lbnLopDaiCuong);
            SetLabelAppearance(lbnMaSoSinhVien);
            SetLabelAppearance(lbnNgaySinh);
            SetLabelAppearance(lbnSDT);
            SetLabelAppearance(LbnNoiSinh);
            SetLabelAppearance(lbnNienKhoa);
            SetLabelAppearance(lbnGioiTinh);

            SetTextBoxApperance(txtHoTen);
            SetTextBoxApperance(txtEmail);
            SetTextBoxApperance(txtMSSV);
            SetTextBoxApperance(txtLopChuyenNganh);
            SetTextBoxApperance(txtNgaySinh);
            SetTextBoxApperance(txtLopDaiCuong);
            SetTextBoxApperance(txtSoDienThoai);
            SetTextBoxApperance(txtNoiSinh);
            SetTextBoxApperance(txtNienKhoa);
            SetTextBoxApperance(txtGioiTinh);

         
        }

        private static void SetLabelAppearance(LabelControl label)
        {
            label.Appearance.ForeColor = Color.Black;
            label.Appearance.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        }

        private void SetTextBoxApperance(TextBox textBox)
        {
            textBox.ForeColor = Color.Black;
            textBox.BackColor = Color.White;
            textBox.BorderStyle =BorderStyle.None;
            textBox.ReadOnly = true;
            textBox.Font = new System.Drawing.Font("Helvetica Neue", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void InitDataSource()
        {
            var dataSource = db.HoatDongConNguois.Where(o => o.MaHoatDong == _hoatDong.MaHoatDong).Select(o => new
            {
                o.MaConNguoi,
                o.ConNguoi.HoChuLot,
                o.ConNguoi.Ten,
                o.ConNguoi.MaSinhVien,
                o.ConNguoi.GioiTinh,
                o.VaiTro.TenVaiTro,
               
                
            }).ToList();
            gridControl1.DataSource = dataSource;
            gridView.Columns[0].Visible = false;
        }

        private void InitDatabase()
        {
            db = new HoatDongUEHEntities();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            GridControlCellHandle();
        }

        private void GridControlCellHandle()
        {
            var selectedRowIndex = gridView.GetSelectedRows()[0];
            var selectedRowObject = gridView.GetRow(selectedRowIndex).ToString();
            var maConNguoi = int.Parse(selectedRowObject.Split(',')[0].Split('=')[1].Trim());

            ConNguoi conNguoi = db.ConNguois.Where(o => o.MaConNguoi == maConNguoi).FirstOrDefault();
            txtHoTen.Text = conNguoi.HoChuLot + " " + conNguoi.Ten;
            txtNgaySinh.Text = conNguoi.NgaySinh.ToString();
            txtEmail.Text = conNguoi.Email;
            txtGioiTinh.Text = conNguoi.GioiTinh.HasValue ? conNguoi.GioiTinh.Value ? "Nam" : "Nữ" : string.Empty;
            Lop[] lops = db.ConNguoiLops.Where(o => o.MaConNguoi == maConNguoi).Select(o => o.Lop).ToArray();
            foreach (Lop lop in lops)
            {
                if (lop.Loai.HasValue)
                {
                    if (lop.Loai.Value)
                    {
                        txtLopDaiCuong.Text = lop.TenLop;
                    }
                    else
                    {
                        txtLopChuyenNganh.Text = lop.TenLop;
                    }
                }
            }

            txtMSSV.Text = conNguoi.MaSinhVien;
            txtNienKhoa.Text = conNguoi.NienKhoa.TenNienKhoa;
            txtSoDienThoai.Text = conNguoi.SDT;
            txtNoiSinh.Text = conNguoi.NoiSinh;
            imgUser.Images.Clear();

            try
            {
                imgUser.Images.Add(Image.FromStream(new MemoryStream(conNguoi.Picture)));
            }
            catch (Exception)
            {imgUser.Images.Add(
                    Image.FromFile(
                        @"C:\Users\Anomyous\Documents\Visual Studio 2013\Projects\OOP\OOP\resource\default.jpg"));
            }

        }


        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridControlCellHandle();
        }
    }
}
