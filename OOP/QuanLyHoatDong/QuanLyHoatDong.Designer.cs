namespace OOP.QuanLyHoatDong
{
    partial class QuanLyHoatDong
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
            this.groupControlContent = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlContent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlContent
            // 
            this.groupControlContent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlContent.Location = new System.Drawing.Point(0, 0);
            this.groupControlContent.Name = "groupControlContent";
            this.groupControlContent.Size = new System.Drawing.Size(1261, 569);
            this.groupControlContent.TabIndex = 0;
            this.groupControlContent.Text = "groupControl1";
            // 
            // QuanLyHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlContent);
            this.Name = "QuanLyHoatDong";
            this.Size = new System.Drawing.Size(1261, 569);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlContent;
    }
}
