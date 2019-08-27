namespace WindowsFormsApp1
{
    partial class uc_CongNo
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LB_CNPTraChoTCNCC = new DevExpress.XtraEditors.LabelControl();
            this.lb_CNPTraCMotNCC = new DevExpress.XtraEditors.LabelControl();
            this.lb_CNPTraTheoChungTu = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lb_CNPTCuaMotKH = new DevExpress.XtraEditors.LabelControl();
            this.lb_CNPhaiThuTheoChungTu = new DevExpress.XtraEditors.LabelControl();
            this.lb_CNPhaiThuTheoNhomKH = new DevExpress.XtraEditors.LabelControl();
            this.lb_CNPhaiThuChoTatCaKH = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lb_CNPTCuaMotKH);
            this.groupControl1.Controls.Add(this.lb_CNPhaiThuTheoChungTu);
            this.groupControl1.Controls.Add(this.lb_CNPhaiThuTheoNhomKH);
            this.groupControl1.Controls.Add(this.lb_CNPhaiThuChoTatCaKH);
            this.groupControl1.Location = new System.Drawing.Point(-2, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(781, 637);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Nhập Liệu";
            // 
            // LB_CNPTraChoTCNCC
            // 
            this.LB_CNPTraChoTCNCC.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CNPTraChoTCNCC.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.LB_CNPTraChoTCNCC.Appearance.Options.UseFont = true;
            this.LB_CNPTraChoTCNCC.Appearance.Options.UseForeColor = true;
            this.LB_CNPTraChoTCNCC.Location = new System.Drawing.Point(5, 45);
            this.LB_CNPTraChoTCNCC.Name = "LB_CNPTraChoTCNCC";
            this.LB_CNPTraChoTCNCC.Size = new System.Drawing.Size(485, 40);
            this.LB_CNPTraChoTCNCC.TabIndex = 0;
            this.LB_CNPTraChoTCNCC.Text = "Công nợ phải trả cho tất cho NCC";
            // 
            // lb_CNPTraCMotNCC
            // 
            this.lb_CNPTraCMotNCC.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CNPTraCMotNCC.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lb_CNPTraCMotNCC.Appearance.Options.UseFont = true;
            this.lb_CNPTraCMotNCC.Appearance.Options.UseForeColor = true;
            this.lb_CNPTraCMotNCC.Location = new System.Drawing.Point(5, 115);
            this.lb_CNPTraCMotNCC.Name = "lb_CNPTraCMotNCC";
            this.lb_CNPTraCMotNCC.Size = new System.Drawing.Size(572, 40);
            this.lb_CNPTraCMotNCC.TabIndex = 1;
            this.lb_CNPTraCMotNCC.Text = "Công nợ phải trả cho một nhà cung cấp";
            // 
            // lb_CNPTraTheoChungTu
            // 
            this.lb_CNPTraTheoChungTu.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CNPTraTheoChungTu.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lb_CNPTraTheoChungTu.Appearance.Options.UseFont = true;
            this.lb_CNPTraTheoChungTu.Appearance.Options.UseForeColor = true;
            this.lb_CNPTraTheoChungTu.Location = new System.Drawing.Point(5, 184);
            this.lb_CNPTraTheoChungTu.Name = "lb_CNPTraTheoChungTu";
            this.lb_CNPTraTheoChungTu.Size = new System.Drawing.Size(456, 40);
            this.lb_CNPTraTheoChungTu.TabIndex = 2;
            this.lb_CNPTraTheoChungTu.Text = "Công nợ phải trả theo chứng từ";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lb_CNPTraTheoChungTu);
            this.groupControl3.Controls.Add(this.lb_CNPTraCMotNCC);
            this.groupControl3.Controls.Add(this.LB_CNPTraChoTCNCC);
            this.groupControl3.Location = new System.Drawing.Point(785, 26);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1058, 637);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Danh mục khác";
            // 
            // lb_CNPTCuaMotKH
            // 
            this.lb_CNPTCuaMotKH.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CNPTCuaMotKH.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lb_CNPTCuaMotKH.Appearance.Options.UseFont = true;
            this.lb_CNPTCuaMotKH.Appearance.Options.UseForeColor = true;
            this.lb_CNPTCuaMotKH.Location = new System.Drawing.Point(30, 260);
            this.lb_CNPTCuaMotKH.Name = "lb_CNPTCuaMotKH";
            this.lb_CNPTCuaMotKH.Size = new System.Drawing.Size(551, 40);
            this.lb_CNPTCuaMotKH.TabIndex = 9;
            this.lb_CNPTCuaMotKH.Text = "Công nợ phải thu của một khách hàng";
            // 
            // lb_CNPhaiThuTheoChungTu
            // 
            this.lb_CNPhaiThuTheoChungTu.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CNPhaiThuTheoChungTu.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lb_CNPhaiThuTheoChungTu.Appearance.Options.UseFont = true;
            this.lb_CNPhaiThuTheoChungTu.Appearance.Options.UseForeColor = true;
            this.lb_CNPhaiThuTheoChungTu.Location = new System.Drawing.Point(30, 184);
            this.lb_CNPhaiThuTheoChungTu.Name = "lb_CNPhaiThuTheoChungTu";
            this.lb_CNPhaiThuTheoChungTu.Size = new System.Drawing.Size(463, 40);
            this.lb_CNPhaiThuTheoChungTu.TabIndex = 8;
            this.lb_CNPhaiThuTheoChungTu.Text = "Công nợ phải thu theo chứng từ";
            // 
            // lb_CNPhaiThuTheoNhomKH
            // 
            this.lb_CNPhaiThuTheoNhomKH.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CNPhaiThuTheoNhomKH.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lb_CNPhaiThuTheoNhomKH.Appearance.Options.UseFont = true;
            this.lb_CNPhaiThuTheoNhomKH.Appearance.Options.UseForeColor = true;
            this.lb_CNPhaiThuTheoNhomKH.Location = new System.Drawing.Point(30, 115);
            this.lb_CNPhaiThuTheoNhomKH.Name = "lb_CNPhaiThuTheoNhomKH";
            this.lb_CNPhaiThuTheoNhomKH.Size = new System.Drawing.Size(590, 40);
            this.lb_CNPhaiThuTheoNhomKH.TabIndex = 7;
            this.lb_CNPhaiThuTheoNhomKH.Text = "Công nợ phải thu theo nhóm khách hàng";
            // 
            // lb_CNPhaiThuChoTatCaKH
            // 
            this.lb_CNPhaiThuChoTatCaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CNPhaiThuChoTatCaKH.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lb_CNPhaiThuChoTatCaKH.Appearance.Options.UseFont = true;
            this.lb_CNPhaiThuChoTatCaKH.Appearance.Options.UseForeColor = true;
            this.lb_CNPhaiThuChoTatCaKH.Location = new System.Drawing.Point(30, 45);
            this.lb_CNPhaiThuChoTatCaKH.Name = "lb_CNPhaiThuChoTatCaKH";
            this.lb_CNPhaiThuChoTatCaKH.Size = new System.Drawing.Size(606, 40);
            this.lb_CNPhaiThuChoTatCaKH.TabIndex = 6;
            this.lb_CNPhaiThuChoTatCaKH.Text = "Công nợ phải thu cho tất cả khách hàng...";
            // 
            // uc_CongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "uc_CongNo";
            this.Size = new System.Drawing.Size(2000, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lb_CNPTCuaMotKH;
        private DevExpress.XtraEditors.LabelControl lb_CNPhaiThuTheoChungTu;
        private DevExpress.XtraEditors.LabelControl lb_CNPhaiThuTheoNhomKH;
        private DevExpress.XtraEditors.LabelControl lb_CNPhaiThuChoTatCaKH;
        private DevExpress.XtraEditors.LabelControl LB_CNPTraChoTCNCC;
        private DevExpress.XtraEditors.LabelControl lb_CNPTraCMotNCC;
        private DevExpress.XtraEditors.LabelControl lb_CNPTraTheoChungTu;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}
