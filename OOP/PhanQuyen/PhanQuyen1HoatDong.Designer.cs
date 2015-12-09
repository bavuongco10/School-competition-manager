namespace OOP.PhanQuyen1HoatDong{
    partial class PhanQuyen1HoatDong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanQuyen1HoatDong));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlProfile = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgUser = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbnGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lbnNienKhoa = new DevExpress.XtraEditors.LabelControl();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLopChuyenNganh = new System.Windows.Forms.TextBox();
            this.txtLopDaiCuong = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.lbnSDT = new DevExpress.XtraEditors.LabelControl();
            this.lbnEmail = new DevExpress.XtraEditors.LabelControl();
            this.lbnLopChuyenNganh = new DevExpress.XtraEditors.LabelControl();
            this.lbnHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lbnNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.LbnNoiSinh = new DevExpress.XtraEditors.LabelControl();
            this.lbnMaSoSinhVien = new DevExpress.XtraEditors.LabelControl();
            this.lbnLopDaiCuong = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::OOP.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProfile)).BeginInit();
            this.groupControlProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(889, 569);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView
            // 
            this.gridView.Appearance.EvenRow.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.EvenRow.Options.UseFont = true;
            this.gridView.Appearance.OddRow.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.OddRow.Options.UseFont = true;
            this.gridView.GridControl = this.gridControl1;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowHeight = 20;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // groupControlProfile
            // 
            this.groupControlProfile.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlProfile.Controls.Add(this.tableLayoutPanel1);
            this.groupControlProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlProfile.Location = new System.Drawing.Point(889, 0);
            this.groupControlProfile.Name = "groupControlProfile";
            this.groupControlProfile.Size = new System.Drawing.Size(372, 569);
            this.groupControlProfile.TabIndex = 1;
            this.groupControlProfile.Text = "groupControl1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.imgUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imgUser
            // 
            this.imgUser.CurrentImageIndex = 0;
            this.imgUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgUser.Images.Add(((System.Drawing.Image)(resources.GetObject("imgUser.Images"))));
            this.imgUser.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.imgUser.Location = new System.Drawing.Point(3, 3);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(366, 193);
            this.imgUser.TabIndex = 0;
            this.imgUser.Text = "imgUser";
            this.imgUser.UseDisabledStatePainter = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.lbnGioiTinh, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lbnNienKhoa, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtSoDienThoai, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtLopChuyenNganh, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtLopDaiCuong, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtMSSV, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtNoiSinh, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNgaySinh, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbnSDT, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lbnEmail, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lbnLopChuyenNganh, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbnHoTen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbnNgaySinh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LbnNoiSinh, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbnMaSoSinhVien, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbnLopDaiCuong, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtHoTen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNienKhoa, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtGioiTinh, 1, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 202);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 364);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbnGioiTinh
            // 
            this.lbnGioiTinh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnGioiTinh.Location = new System.Drawing.Point(3, 261);
            this.lbnGioiTinh.Name = "lbnGioiTinh";
            this.lbnGioiTinh.Size = new System.Drawing.Size(51, 17);
            this.lbnGioiTinh.TabIndex = 18;
            this.lbnGioiTinh.Text = "Giới Tính";
            // 
            // lbnNienKhoa
            // 
            this.lbnNienKhoa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnNienKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnNienKhoa.Location = new System.Drawing.Point(3, 232);
            this.lbnNienKhoa.Name = "lbnNienKhoa";
            this.lbnNienKhoa.Size = new System.Drawing.Size(57, 16);
            this.lbnNienKhoa.TabIndex = 16;
            this.lbnNienKhoa.Text = "Niên Khoá";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoDienThoai.Location = new System.Drawing.Point(131, 203);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(232, 23);
            this.txtSoDienThoai.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(131, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 23);
            this.txtEmail.TabIndex = 14;
            // 
            // txtLopChuyenNganh
            // 
            this.txtLopChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLopChuyenNganh.Location = new System.Drawing.Point(131, 145);
            this.txtLopChuyenNganh.Name = "txtLopChuyenNganh";
            this.txtLopChuyenNganh.Size = new System.Drawing.Size(232, 23);
            this.txtLopChuyenNganh.TabIndex = 13;
            // 
            // txtLopDaiCuong
            // 
            this.txtLopDaiCuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLopDaiCuong.Location = new System.Drawing.Point(131, 116);
            this.txtLopDaiCuong.Name = "txtLopDaiCuong";
            this.txtLopDaiCuong.Size = new System.Drawing.Size(232, 23);
            this.txtLopDaiCuong.TabIndex = 12;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMSSV.Location = new System.Drawing.Point(131, 87);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(232, 23);
            this.txtMSSV.TabIndex = 11;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiSinh.Location = new System.Drawing.Point(131, 58);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(232, 23);
            this.txtNoiSinh.TabIndex = 10;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNgaySinh.Location = new System.Drawing.Point(131, 29);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(232, 23);
            this.txtNgaySinh.TabIndex = 9;
            // 
            // lbnSDT
            // 
            this.lbnSDT.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnSDT.Location = new System.Drawing.Point(3, 203);
            this.lbnSDT.Name = "lbnSDT";
            this.lbnSDT.Size = new System.Drawing.Size(79, 17);
            this.lbnSDT.TabIndex = 7;
            this.lbnSDT.Text = "Số điện thoại";
            // 
            // lbnEmail
            // 
            this.lbnEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnEmail.Location = new System.Drawing.Point(3, 174);
            this.lbnEmail.Name = "lbnEmail";
            this.lbnEmail.Size = new System.Drawing.Size(31, 16);
            this.lbnEmail.TabIndex = 6;
            this.lbnEmail.Text = "Email";
            // 
            // lbnLopChuyenNganh
            // 
            this.lbnLopChuyenNganh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnLopChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnLopChuyenNganh.Location = new System.Drawing.Point(3, 145);
            this.lbnLopChuyenNganh.Name = "lbnLopChuyenNganh";
            this.lbnLopChuyenNganh.Size = new System.Drawing.Size(119, 17);
            this.lbnLopChuyenNganh.TabIndex = 5;
            this.lbnLopChuyenNganh.Text = "Lớp Chuyên Ngành";
            // 
            // lbnHoTen
            // 
            this.lbnHoTen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnHoTen.Location = new System.Drawing.Point(3, 3);
            this.lbnHoTen.Name = "lbnHoTen";
            this.lbnHoTen.Size = new System.Drawing.Size(63, 17);
            this.lbnHoTen.TabIndex = 0;
            this.lbnHoTen.Text = "Họ và Tên";
            // 
            // lbnNgaySinh
            // 
            this.lbnNgaySinh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnNgaySinh.Location = new System.Drawing.Point(3, 29);
            this.lbnNgaySinh.Name = "lbnNgaySinh";
            this.lbnNgaySinh.Size = new System.Drawing.Size(57, 16);
            this.lbnNgaySinh.TabIndex = 1;
            this.lbnNgaySinh.Text = "Ngày Sinh";
            // 
            // LbnNoiSinh
            // 
            this.LbnNoiSinh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.LbnNoiSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbnNoiSinh.Location = new System.Drawing.Point(3, 58);
            this.LbnNoiSinh.Name = "LbnNoiSinh";
            this.LbnNoiSinh.Size = new System.Drawing.Size(47, 16);
            this.LbnNoiSinh.TabIndex = 2;
            this.LbnNoiSinh.Text = "Nơi Sinh";
            // 
            // lbnMaSoSinhVien
            // 
            this.lbnMaSoSinhVien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnMaSoSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnMaSoSinhVien.Location = new System.Drawing.Point(3, 87);
            this.lbnMaSoSinhVien.Name = "lbnMaSoSinhVien";
            this.lbnMaSoSinhVien.Size = new System.Drawing.Size(34, 16);
            this.lbnMaSoSinhVien.TabIndex = 3;
            this.lbnMaSoSinhVien.Text = "MSSV";
            // 
            // lbnLopDaiCuong
            // 
            this.lbnLopDaiCuong.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbnLopDaiCuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnLopDaiCuong.Location = new System.Drawing.Point(3, 116);
            this.lbnLopDaiCuong.Name = "lbnLopDaiCuong";
            this.lbnLopDaiCuong.Size = new System.Drawing.Size(92, 17);
            this.lbnLopDaiCuong.TabIndex = 4;
            this.lbnLopDaiCuong.Text = "Lớp Đại Cương";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoTen.Font = new System.Drawing.Font("Helvetica Neue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(131, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(232, 20);
            this.txtHoTen.TabIndex = 8;
            this.txtHoTen.Text = "Hello World";
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNienKhoa.Location = new System.Drawing.Point(131, 232);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(232, 23);
            this.txtNienKhoa.TabIndex = 17;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiTinh.Location = new System.Drawing.Point(131, 261);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(232, 23);
            this.txtGioiTinh.TabIndex = 19;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // PhanQuyen1HoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlProfile);
            this.Controls.Add(this.gridControl1);
            this.Name = "PhanQuyen1HoatDong";
            this.Size = new System.Drawing.Size(1261, 569);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProfile)).EndInit();
            this.groupControlProfile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.GroupControl groupControlProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.Controls.ImageSlider imgUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLopChuyenNganh;
        private System.Windows.Forms.TextBox txtLopDaiCuong;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private DevExpress.XtraEditors.LabelControl lbnSDT;
        private DevExpress.XtraEditors.LabelControl lbnEmail;
        private DevExpress.XtraEditors.LabelControl lbnLopChuyenNganh;
        private DevExpress.XtraEditors.LabelControl lbnHoTen;
        private DevExpress.XtraEditors.LabelControl lbnNgaySinh;
        private DevExpress.XtraEditors.LabelControl LbnNoiSinh;
        private DevExpress.XtraEditors.LabelControl lbnMaSoSinhVien;
        private DevExpress.XtraEditors.LabelControl lbnLopDaiCuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevExpress.XtraEditors.LabelControl lbnNienKhoa;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private DevExpress.XtraEditors.LabelControl lbnGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
