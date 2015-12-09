namespace OOP
{
    partial class HoatDongDetail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
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
            this.groupControlHeader = new DevExpress.XtraEditors.GroupControl();
            this.hoatDongHeader = new OOP.HoatDongCuocThiDetail.HoatDongHeader();
            this.groupControlContent = new DevExpress.XtraEditors.GroupControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHeader)).BeginInit();
            this.groupControlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlContent)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlHeader
            // 
            this.groupControlHeader.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControlHeader.Appearance.Options.UseBackColor = true;
            this.groupControlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlHeader.Controls.Add(this.hoatDongHeader);
            this.groupControlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlHeader.Location = new System.Drawing.Point(0, 0);
            this.groupControlHeader.Name = "groupControlHeader";
            this.groupControlHeader.Size = new System.Drawing.Size(1261, 60);
            this.groupControlHeader.TabIndex = 1;
            this.groupControlHeader.Text = "groupControl1";
            // 
            // hoatDongHeader
            // 
            this.hoatDongHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoatDongHeader.Location = new System.Drawing.Point(0, 0);
            this.hoatDongHeader.Name = "hoatDongHeader";
            this.hoatDongHeader.Size = new System.Drawing.Size(1261, 60);
            this.hoatDongHeader.TabIndex = 0;
            // 
            // groupControlContent
            // 
            this.groupControlContent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlContent.Location = new System.Drawing.Point(0, 60);
            this.groupControlContent.Name = "groupControlContent";
            this.groupControlContent.Size = new System.Drawing.Size(1261, 509);
            this.groupControlContent.TabIndex = 2;
            this.groupControlContent.Text = "groupControl1";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.AllowTouchScroll = true;
            this.xtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraScrollableControl1.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl1.Controls.Add(this.tableLayoutPanel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 60);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1261, 509);
            this.xtraScrollableControl1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1261, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HoatDongDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.groupControlContent);
            this.Controls.Add(this.groupControlHeader);
            this.Name = "HoatDongDetail";
            this.Size = new System.Drawing.Size(1261, 569);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHeader)).EndInit();
            this.groupControlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlContent)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlHeader;
        private DevExpress.XtraEditors.GroupControl groupControlContent;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HoatDongCuocThiDetail.HoatDongHeader hoatDongHeader;




    }
}
