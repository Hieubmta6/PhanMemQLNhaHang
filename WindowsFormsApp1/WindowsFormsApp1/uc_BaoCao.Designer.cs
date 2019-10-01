namespace WindowsFormsApp1
{
    partial class uc_BaoCao
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_NhacNhoSinhNhat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_BangKeChungTuTheoMaPhi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BCKQkinhDoanh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BCCPhiTheoBoPhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2000, 17);
            this.panelControl1.TabIndex = 7;
            // 
            // btn_NhacNhoSinhNhat
            // 
            this.btn_NhacNhoSinhNhat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_NhacNhoSinhNhat.Appearance.Options.UseForeColor = true;
            this.btn_NhacNhoSinhNhat.Location = new System.Drawing.Point(710, 28);
            this.btn_NhacNhoSinhNhat.Name = "btn_NhacNhoSinhNhat";
            this.btn_NhacNhoSinhNhat.Size = new System.Drawing.Size(236, 41);
            this.btn_NhacNhoSinhNhat.TabIndex = 1;
            this.btn_NhacNhoSinhNhat.Text = "Nhắc Nhở Sinh Nhật";
            this.btn_NhacNhoSinhNhat.Click += new System.EventHandler(this.btn_NhacNhoSinhNhat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_BangKeChungTuTheoMaPhi);
            this.groupControl1.Controls.Add(this.btn_BCKQkinhDoanh);
            this.groupControl1.Controls.Add(this.btn_NhacNhoSinhNhat);
            this.groupControl1.Controls.Add(this.btn_BCCPhiTheoBoPhan);
            this.groupControl1.Location = new System.Drawing.Point(-2, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1630, 818);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Nhập Liệu";
            // 
            // btn_BangKeChungTuTheoMaPhi
            // 
            this.btn_BangKeChungTuTheoMaPhi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_BangKeChungTuTheoMaPhi.Appearance.Options.UseForeColor = true;
            this.btn_BangKeChungTuTheoMaPhi.Location = new System.Drawing.Point(466, 28);
            this.btn_BangKeChungTuTheoMaPhi.Name = "btn_BangKeChungTuTheoMaPhi";
            this.btn_BangKeChungTuTheoMaPhi.Size = new System.Drawing.Size(238, 41);
            this.btn_BangKeChungTuTheoMaPhi.TabIndex = 6;
            this.btn_BangKeChungTuTheoMaPhi.Text = "Bảng kê chứng từ theo mã phí";
            this.btn_BangKeChungTuTheoMaPhi.Click += new System.EventHandler(this.btn_BangKeChungTuTheoMaPhi_Click);
            // 
            // btn_BCKQkinhDoanh
            // 
            this.btn_BCKQkinhDoanh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_BCKQkinhDoanh.Appearance.Options.UseForeColor = true;
            this.btn_BCKQkinhDoanh.Location = new System.Drawing.Point(247, 28);
            this.btn_BCKQkinhDoanh.Name = "btn_BCKQkinhDoanh";
            this.btn_BCKQkinhDoanh.Size = new System.Drawing.Size(213, 41);
            this.btn_BCKQkinhDoanh.TabIndex = 3;
            this.btn_BCKQkinhDoanh.Text = "Báo Cáo Kết Qủa Kinh Doanh";
            this.btn_BCKQkinhDoanh.Click += new System.EventHandler(this.btn_BCKQkinhDoanh_Click);
            // 
            // btn_BCCPhiTheoBoPhan
            // 
            this.btn_BCCPhiTheoBoPhan.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_BCCPhiTheoBoPhan.Appearance.Options.UseForeColor = true;
            this.btn_BCCPhiTheoBoPhan.Location = new System.Drawing.Point(6, 28);
            this.btn_BCCPhiTheoBoPhan.Name = "btn_BCCPhiTheoBoPhan";
            this.btn_BCCPhiTheoBoPhan.Size = new System.Drawing.Size(235, 41);
            this.btn_BCCPhiTheoBoPhan.TabIndex = 0;
            this.btn_BCCPhiTheoBoPhan.Text = "Báo Cáo Chi Phí Theo Bộ Phận";
            this.btn_BCCPhiTheoBoPhan.Click += new System.EventHandler(this.btn_BCCPhiTheoBoPhan_Click);
            // 
            // uc_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "uc_BaoCao";
            this.Size = new System.Drawing.Size(2000, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_NhacNhoSinhNhat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_BangKeChungTuTheoMaPhi;
        private DevExpress.XtraEditors.SimpleButton btn_BCKQkinhDoanh;
        private DevExpress.XtraEditors.SimpleButton btn_BCCPhiTheoBoPhan;
    }
}
