namespace OOP
{
    partial class DescriptionWithLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescriptionWithLabel));
            this.lbnLabel = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtContent = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnLabel
            // 
            this.lbnLabel.Appearance.Font = new System.Drawing.Font("Helvetica Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbnLabel.Location = new System.Drawing.Point(0, 0);
            this.lbnLabel.Name = "lbnLabel";
            this.lbnLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbnLabel.Size = new System.Drawing.Size(299, 43);
            this.lbnLabel.TabIndex = 0;
            this.lbnLabel.Text = "Giới thiệu về hoạt động";
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.txtContent);
            this.groupControl2.Controls.Add(this.lbnLabel);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(20, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1185, 400);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "groupControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(20, 400);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContent.EditValue = resources.GetString("txtContent.EditValue");
            this.txtContent.Location = new System.Drawing.Point(0, 43);
            this.txtContent.Name = "txtContent";
            this.txtContent.Properties.AllowMouseWheel = false;
            this.txtContent.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtContent.Properties.Appearance.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Properties.Appearance.Options.UseBackColor = true;
            this.txtContent.Properties.Appearance.Options.UseFont = true;
            this.txtContent.Properties.Appearance.Options.UseForeColor = true;
            this.txtContent.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Helvetica Neue", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.txtContent.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtContent.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtContent.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtContent.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.Transparent;
            this.txtContent.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtContent.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.txtContent.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtContent.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtContent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtContent.Properties.ReadOnly = true;
            this.txtContent.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.Size = new System.Drawing.Size(1185, 92);
            this.txtContent.TabIndex = 11;
            // 
            // DescriptionWithLabel
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DescriptionWithLabel";
            this.Size = new System.Drawing.Size(1205, 400);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lbnLabel;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.MemoEdit txtContent;






    }
}
