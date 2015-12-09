namespace OOP
{
    partial class Filter
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
            this.accordionControlFilter = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.clbNhomHoatDong = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.accordionContentContainer2 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.clbDonVi = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.accordionContentContainer4 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.radioHocKi = new DevExpress.XtraEditors.RadioGroup();
            this.accordionContentContainer5 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.trackbarSL = new OOP.TrackbarWithLabel();
            this.accordionControlElementFilter = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceNhomHoatDong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDonVI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHocKi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceSL = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.winExplorerViewFilter = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.rangeTrackBarControl2 = new DevExpress.XtraEditors.RangeTrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControlFilter)).BeginInit();
            this.accordionControlFilter.SuspendLayout();
            this.accordionContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbNhomHoatDong)).BeginInit();
            this.accordionContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbDonVi)).BeginInit();
            this.accordionContentContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioHocKi.Properties)).BeginInit();
            this.accordionContentContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerViewFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControlFilter
            // 
            this.accordionControlFilter.Controls.Add(this.accordionContentContainer1);
            this.accordionControlFilter.Controls.Add(this.accordionContentContainer2);
            this.accordionControlFilter.Controls.Add(this.accordionContentContainer4);
            this.accordionControlFilter.Controls.Add(this.accordionContentContainer5);
            this.accordionControlFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControlFilter.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementFilter});
            this.accordionControlFilter.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.accordionControlFilter.Location = new System.Drawing.Point(1076, 0);
            this.accordionControlFilter.Name = "accordionControlFilter";
            this.accordionControlFilter.Size = new System.Drawing.Size(424, 1000);
            this.accordionControlFilter.TabIndex = 0;
            this.accordionControlFilter.Text = "accordionControl1";
            this.accordionControlFilter.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.accordionContentContainer1.Appearance.Options.UseBackColor = true;
            this.accordionContentContainer1.Controls.Add(this.clbNhomHoatDong);
            this.accordionContentContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Padding = new System.Windows.Forms.Padding(-1);
            this.accordionContentContainer1.Size = new System.Drawing.Size(403, 170);
            this.accordionContentContainer1.TabIndex = 1;
            // 
            // clbNhomHoatDong
            // 
            this.clbNhomHoatDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbNhomHoatDong.Location = new System.Drawing.Point(25, 4);
            this.clbNhomHoatDong.Name = "clbNhomHoatDong";
            this.clbNhomHoatDong.Size = new System.Drawing.Size(366, 150);
            this.clbNhomHoatDong.TabIndex = 0;
            this.clbNhomHoatDong.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbNhomHoatDong_ItemCheck);
            this.clbNhomHoatDong.SelectedIndexChanged += new System.EventHandler(this.clbNhomHoatDong_SelectedIndexChanged);
            // 
            // accordionContentContainer2
            // 
            this.accordionContentContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.accordionContentContainer2.Appearance.Options.UseBackColor = true;
            this.accordionContentContainer2.Controls.Add(this.clbDonVi);
            this.accordionContentContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.accordionContentContainer2.Name = "accordionContentContainer2";
            this.accordionContentContainer2.Padding = new System.Windows.Forms.Padding(-1);
            this.accordionContentContainer2.Size = new System.Drawing.Size(403, 206);
            this.accordionContentContainer2.TabIndex = 2;
            // 
            // clbDonVi
            // 
            this.clbDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbDonVi.Location = new System.Drawing.Point(25, 4);
            this.clbDonVi.Name = "clbDonVi";
            this.clbDonVi.Size = new System.Drawing.Size(366, 186);
            this.clbDonVi.TabIndex = 0;
            this.clbDonVi.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbDonVi_ItemCheck);
            // 
            // accordionContentContainer4
            // 
            this.accordionContentContainer4.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.accordionContentContainer4.Appearance.Options.UseBackColor = true;
            this.accordionContentContainer4.Controls.Add(this.radioHocKi);
            this.accordionContentContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.accordionContentContainer4.Name = "accordionContentContainer4";
            this.accordionContentContainer4.Padding = new System.Windows.Forms.Padding(-1);
            this.accordionContentContainer4.Size = new System.Drawing.Size(403, 76);
            this.accordionContentContainer4.TabIndex = 5;
            // 
            // radioHocKi
            // 
            this.radioHocKi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioHocKi.Location = new System.Drawing.Point(25, 4);
            this.radioHocKi.Name = "radioHocKi";
            this.radioHocKi.Size = new System.Drawing.Size(366, 56);
            this.radioHocKi.TabIndex = 0;
            this.radioHocKi.SelectedIndexChanged += new System.EventHandler(this.radioHocKi_SelectedIndexChanged);
            // 
            // accordionContentContainer5
            // 
            this.accordionContentContainer5.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.accordionContentContainer5.Appearance.Options.UseBackColor = true;
            this.accordionContentContainer5.Controls.Add(this.trackbarSL);
            this.accordionContentContainer5.Margin = new System.Windows.Forms.Padding(4);
            this.accordionContentContainer5.Name = "accordionContentContainer5";
            this.accordionContentContainer5.Padding = new System.Windows.Forms.Padding(-1);
            this.accordionContentContainer5.Size = new System.Drawing.Size(403, 79);
            this.accordionContentContainer5.TabIndex = 6;
            // 
            // trackbarSL
            // 
            this.trackbarSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarSL.Location = new System.Drawing.Point(25, 4);
            this.trackbarSL.Name = "trackbarSL";
            this.trackbarSL.Size = new System.Drawing.Size(366, 59);
            this.trackbarSL.TabIndex = 0;
            // 
            // accordionControlElementFilter
            // 
            this.accordionControlElementFilter.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceNhomHoatDong,
            this.aceDonVI,
            this.aceHocKi,
            this.aceSL});
            this.accordionControlElementFilter.Expanded = true;
            this.accordionControlElementFilter.Text = "Filter";
            // 
            // aceNhomHoatDong
            // 
            this.aceNhomHoatDong.ContentContainer = this.accordionContentContainer1;
            this.aceNhomHoatDong.Expanded = true;
            this.aceNhomHoatDong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceNhomHoatDong.Text = "Nhóm Hoạt Động";
            // 
            // aceDonVI
            // 
            this.aceDonVI.ContentContainer = this.accordionContentContainer2;
            this.aceDonVI.Expanded = true;
            this.aceDonVI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDonVI.Text = "Đơn Vị";
            // 
            // aceHocKi
            // 
            this.aceHocKi.ContentContainer = this.accordionContentContainer4;
            this.aceHocKi.Expanded = true;
            this.aceHocKi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHocKi.Text = "HocKi";
            // 
            // aceSL
            // 
            this.aceSL.ContentContainer = this.accordionContentContainer5;
            this.aceSL.Expanded = true;
            this.aceSL.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceSL.Text = "Số Lượng tham gia";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(1063, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 1000);
            this.labelControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.winExplorerViewFilter;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1063, 1000);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerViewFilter});
            // 
            // winExplorerViewFilter
            // 
            this.winExplorerViewFilter.Appearance.FilterPanel.BackColor = System.Drawing.Color.White;
            this.winExplorerViewFilter.Appearance.FilterPanel.Options.UseBackColor = true;
            this.winExplorerViewFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerViewFilter.GridControl = this.gridControl1;
            this.winExplorerViewFilter.Name = "winExplorerViewFilter";
            this.winExplorerViewFilter.OptionsFind.AlwaysVisible = true;
            this.winExplorerViewFilter.OptionsFind.FindDelay = 500;
            this.winExplorerViewFilter.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
            this.winExplorerViewFilter.OptionsViewStyles.Content.ItemWidth = 1051;
            this.winExplorerViewFilter.OptionsViewStyles.Content.ShowDescription = DevExpress.Utils.DefaultBoolean.True;
            this.winExplorerViewFilter.ItemClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemClickEventHandler(this.winExplorerViewFilter_ItemClick);
            // 
            // rangeTrackBarControl2
            // 
            this.rangeTrackBarControl2.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(0, 0);
            this.rangeTrackBarControl2.Location = new System.Drawing.Point(79, 26);
            this.rangeTrackBarControl2.Name = "rangeTrackBarControl2";
            this.rangeTrackBarControl2.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.rangeTrackBarControl2.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rangeTrackBarControl2.Size = new System.Drawing.Size(104, 56);
            this.rangeTrackBarControl2.TabIndex = 0;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.accordionControlFilter);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControlFilter)).EndInit();
            this.accordionControlFilter.ResumeLayout(false);
            this.accordionContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbNhomHoatDong)).EndInit();
            this.accordionContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbDonVi)).EndInit();
            this.accordionContentContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioHocKi.Properties)).EndInit();
            this.accordionContentContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerViewFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControlFilter;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerViewFilter;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceNhomHoatDong;
        private DevExpress.XtraEditors.CheckedListBoxControl clbNhomHoatDong;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer2;
        private DevExpress.XtraEditors.CheckedListBoxControl clbDonVi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDonVI;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer4;
        private DevExpress.XtraEditors.RadioGroup radioHocKi;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHocKi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSL;
        private DevExpress.XtraEditors.RangeTrackBarControl rangeTrackBarControl2;
        private TrackbarWithLabel trackbarSL;
    }
}
