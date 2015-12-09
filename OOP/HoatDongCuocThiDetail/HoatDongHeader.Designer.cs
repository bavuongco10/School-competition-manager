namespace OOP.HoatDongCuocThiDetail
{
    partial class HoatDongHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoatDongHeader));
            this.groupControlContent = new DevExpress.XtraEditors.GroupControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlContent)).BeginInit();
            this.groupControlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlContent
            // 
            this.groupControlContent.Appearance.BackColor = System.Drawing.Color.Black;
            this.groupControlContent.Appearance.Options.UseBackColor = true;
            this.groupControlContent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlContent.Controls.Add(this.btnCreate);
            this.groupControlContent.Controls.Add(this.btnSave);
            this.groupControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlContent.Location = new System.Drawing.Point(0, 0);
            this.groupControlContent.Name = "groupControlContent";
            this.groupControlContent.Size = new System.Drawing.Size(1261, 60);
            this.groupControlContent.TabIndex = 0;
            this.groupControlContent.Text = "groupControl1";
            // 
            // btnCreate
            // 
            this.btnCreate.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Appearance.Options.UseBackColor = true;
            this.btnCreate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCreate.Location = new System.Drawing.Point(1019, 0);
            this.btnCreate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 60);
            this.btnCreate.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(1140, 0);
            this.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 60);
            this.btnSave.TabIndex = 0;
            // 
            // HoatDongHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlContent);
            this.Name = "HoatDongHeader";
            this.Size = new System.Drawing.Size(1261, 60);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlContent)).EndInit();
            this.groupControlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.GroupControl groupControlContent;
        public DevExpress.XtraEditors.SimpleButton btnCreate;
        public DevExpress.XtraEditors.SimpleButton btnSave;

    }
}
