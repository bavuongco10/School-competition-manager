namespace OOP
{
    partial class TrackbarWithLabel
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
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbnMax = new System.Windows.Forms.Label();
            this.lbnMin = new System.Windows.Forms.Label();
            this.lbnCurrentValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.LargeChange = 1000;
            this.trackBar.Location = new System.Drawing.Point(0, 0);
            this.trackBar.Maximum = 10000;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(285, 60);
            this.trackBar.SmallChange = 100;
            this.trackBar.TabIndex = 0;
            this.trackBar.TickFrequency = 1000;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.lbnCurrentValue);
            this.groupControl1.Controls.Add(this.lbnMax);
            this.groupControl1.Controls.Add(this.lbnMin);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(285, 22);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // lbnMax
            // 
            this.lbnMax.AutoSize = true;
            this.lbnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbnMax.Location = new System.Drawing.Point(285, 0);
            this.lbnMax.Name = "lbnMax";
            this.lbnMax.Size = new System.Drawing.Size(0, 17);
            this.lbnMax.TabIndex = 1;
            this.lbnMax.TextChanged += new System.EventHandler(this.lbnMax_TextChanged);
            // 
            // lbnMin
            // 
            this.lbnMin.AutoSize = true;
            this.lbnMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbnMin.Location = new System.Drawing.Point(0, 0);
            this.lbnMin.Name = "lbnMin";
            this.lbnMin.Size = new System.Drawing.Size(0, 17);
            this.lbnMin.TabIndex = 0;
            this.lbnMin.TextChanged += new System.EventHandler(this.lbnMin_TextChanged);
            this.lbnMin.Click += new System.EventHandler(this.lbnMin_Click);
            // 
            // lbnCurrentValue
            // 
            this.lbnCurrentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnCurrentValue.Location = new System.Drawing.Point(0, 0);
            this.lbnCurrentValue.Name = "lbnCurrentValue";
            this.lbnCurrentValue.Size = new System.Drawing.Size(285, 22);
            this.lbnCurrentValue.TabIndex = 2;
            this.lbnCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrackbarWithLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.trackBar);
            this.Name = "TrackbarWithLabel";
            this.Size = new System.Drawing.Size(285, 60);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        public System.Windows.Forms.Label lbnMax;
        public System.Windows.Forms.Label lbnMin;
        public System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lbnCurrentValue;
    }
}
