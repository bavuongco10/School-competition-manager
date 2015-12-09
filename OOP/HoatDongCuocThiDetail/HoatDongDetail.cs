using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OOP.CustomControl;

namespace OOP
{
    public partial class HoatDongDetail : XtraUserControl
    {
        private string _maSinhVien;
        private bool _editable;
        private HoatDong _hoatDong;
        private DescriptionWithLabel benefits;
        private DescriptionWithLabel description;
        private HoatDongCuocThiDetailTableHeader header;
        private DescriptionWithLabel requirements;
        private DescriptionWithLabel targets;
        private HoatDongUEHEntities database;

        public HoatDongDetail(HoatDong hoatDong, bool editable,string maSinhVien)
        {
            InitDatabase();
            InitializeComponent();
            _editable = editable;
            HoatDong getHoatDong= database.HoatDongs.FirstOrDefault(o => o.MaHoatDong == hoatDong.MaHoatDong);
            _maSinhVien = maSinhVien;_hoatDong = getHoatDong;
            InitControl();
            InitSaveButton();
            InitHeader();
            
            
            InitEvent();
        }

        private void InitDatabase()
        {
            
            database = new HoatDongUEHEntities();
        }

        private void InitEvent()
        {
            hoatDongHeader.btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var hoatDong = _hoatDong;
            hoatDong.TenHoatDong = header.txtTenHoatDong.Text;
            //NhomHoatDong nhomHoatDong= new NhomHoatDong
            //{
            //    MaNhomHoatDong = _hoatDong.MaHoatDong,
            //    TenNhomHoatDong = header.txtTenNhomHoatDong.Text
            //};
            //DonVi donVi= new DonVi
            //{
            //    MaDonVi = _hoatDong.MaDonVi.Value,
            //    TenDonVi = header.txtDonVi.Text
            //};
            hoatDong.NhomHoatDong.TenNhomHoatDong = header.txtTenNhomHoatDong.Text;
            hoatDong.DonVi.TenDonVi = header.txtDonVi.Text;
            decimal tmpvalue;
            decimal? giaVe = decimal.TryParse((string)header.txtPrice.Text, out tmpvalue) ?
                              tmpvalue : (decimal?)null;
            hoatDong.GiaVe = giaVe;
            hoatDong.Description = description.txtContent.Text;
            hoatDong.Benefits = benefits.txtContent.Text;
            hoatDong.Targets = targets.txtContent.Text;
            hoatDong.Requirements = requirements.txtContent.Text;
            var result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                database.HoatDongs.AddOrUpdate(hoatDong);
                database.SaveChanges();
                MessageBox.Show("Done!", "Warning");
            }
        }

        private void InitHeader()
        {
            if (!_editable)
            {
                groupControlHeader.Hide();
            }
        }

        private void InitSaveButton()
        {
        }

        private void InitControl()
        {
            header = new HoatDongCuocThiDetailTableHeader(_hoatDong, _editable,_maSinhVien) {Size = new Size(0, 550)};
            tableLayoutPanel1.Controls.Add(header, 0, 0);
            header.Dock = DockStyle.Fill;

            var rating = new RatingTableRow();
            rating.Size = new Size(0, 150);

            tableLayoutPanel1.Controls.Add(rating, 0, 1);rating.Dock = DockStyle.Fill;

            ;
            description = new DescriptionWithLabel();
            description.lbnLabel.Text = "Giới thiệu về hoạt động";
            description.txtContent.Text = _hoatDong.Description;
            var descriptionHeight = description.txtContent.Size.Height;
            description.Size = new Size(0, descriptionHeight + 50);
            tableLayoutPanel1.Controls.Add(description, 0, 2);
            description.Dock = DockStyle.Fill;
            description.txtContent.Properties.ReadOnly = !_editable;
            description.txtContent.Properties.Appearance.BackColor = Color.Gainsboro;


            requirements = new DescriptionWithLabel();
            requirements.lbnLabel.Text = "Những điều bạn nên chuẩn bị trước khi tham gia";
            requirements.txtContent.Text = _hoatDong.Requirements;
            var requirementsHeight = requirements.txtContent.Size.Height;
            requirements.Size = new Size(0, requirementsHeight + 50);
            tableLayoutPanel1.Controls.Add(requirements, 0, 3);
            requirements.Dock = DockStyle.Fill;
            requirements.txtContent.Properties.Appearance.BackColor = Color.Gainsboro;
            requirements.txtContent.Properties.ReadOnly = !_editable;


            benefits = new DescriptionWithLabel();
            benefits.lbnLabel.Text = "Những điều bạn sẽ nhận được khi tham gia";
            benefits.txtContent.Text = _hoatDong.Benefits;
            var bebefitsHeight = benefits.txtContent.Size.Height;
            requirements.Size = new Size(0, bebefitsHeight + 50);
            tableLayoutPanel1.Controls.Add(benefits, 0, 4);
            benefits.Dock = DockStyle.Fill;
            benefits.txtContent.Properties.ReadOnly = !_editable;
            benefits.txtContent.Properties.Appearance.BackColor = Color.Gainsboro;


            targets = new DescriptionWithLabel();
            targets.lbnLabel.Text = "Những đối tượng nên tham gia";
            targets.txtContent.Text = _hoatDong.Targets;
            var targetsHeight = targets.txtContent.Size.Height;
            requirements.Size = new Size(0, targetsHeight + 50);
            tableLayoutPanel1.Controls.Add(targets, 0, 5);
            targets.Dock = DockStyle.Fill;
            targets.txtContent.Properties.ReadOnly = !_editable;
            targets.txtContent.Properties.Appearance.BackColor = Color.Gainsboro;
        }

        private void xtraScrollableControl1_Click(object sender, EventArgs e)
        {
        }
    }
}