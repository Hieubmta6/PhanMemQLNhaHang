namespace WindowsFormsApp1
{
    partial class frm_ThongTinKho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongTinKho));
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_InAn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoMacDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chitunganquy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienNganQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chidennganquy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoChiTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lydo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckb_Khomacdinh = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Khomacdinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them.Location = new System.Drawing.Point(278, 25);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(82, 29);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sua.ImageOptions.SvgImage")));
            this.btn_Sua.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua.Location = new System.Drawing.Point(380, 25);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(82, 29);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_InAn
            // 
            this.btn_InAn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InAn.ImageOptions.Image")));
            this.btn_InAn.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_InAn.Location = new System.Drawing.Point(556, 25);
            this.btn_InAn.Name = "btn_InAn";
            this.btn_InAn.Size = new System.Drawing.Size(102, 29);
            this.btn_InAn.TabIndex = 15;
            this.btn_InAn.Text = "Đóng";
            // 
            // btn_Export
            // 
            this.btn_Export.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Export.ImageOptions.SvgImage")));
            this.btn_Export.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Export.Location = new System.Drawing.Point(468, 25);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(82, 29);
            this.btn_Export.TabIndex = 14;
            this.btn_Export.Text = "Xóa";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 185);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.gridControl1.Size = new System.Drawing.Size(671, 387);
            this.gridControl1.TabIndex = 81;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKho,
            this.TenKho,
            this.KhoMacDinh});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // MaKho
            // 
            this.MaKho.Caption = "Mã Kho";
            this.MaKho.FieldName = "MaKho";
            this.MaKho.MinWidth = 25;
            this.MaKho.Name = "MaKho";
            this.MaKho.Visible = true;
            this.MaKho.VisibleIndex = 0;
            this.MaKho.Width = 94;
            // 
            // TenKho
            // 
            this.TenKho.Caption = "Tên kho";
            this.TenKho.FieldName = "TenKho_V";
            this.TenKho.MinWidth = 25;
            this.TenKho.Name = "TenKho";
            this.TenKho.Visible = true;
            this.TenKho.VisibleIndex = 1;
            this.TenKho.Width = 94;
            // 
            // KhoMacDinh
            // 
            this.KhoMacDinh.Caption = "Kho Mặc Định";
            this.KhoMacDinh.ColumnEdit = this.repositoryItemCheckEdit3;
            this.KhoMacDinh.FieldName = "KhoMacDinh";
            this.KhoMacDinh.MinWidth = 25;
            this.KhoMacDinh.Name = "KhoMacDinh";
            this.KhoMacDinh.Visible = true;
            this.KhoMacDinh.VisibleIndex = 2;
            this.KhoMacDinh.Width = 94;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.STT.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.STT.MinWidth = 22;
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 82;
            // 
            // MaPhieu
            // 
            this.MaPhieu.Caption = "Mã Phiếu";
            this.MaPhieu.MinWidth = 22;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Visible = true;
            this.MaPhieu.VisibleIndex = 1;
            this.MaPhieu.Width = 82;
            // 
            // NgLap
            // 
            this.NgLap.Caption = "Ngày Lập";
            this.NgLap.MinWidth = 22;
            this.NgLap.Name = "NgLap";
            this.NgLap.Visible = true;
            this.NgLap.VisibleIndex = 2;
            this.NgLap.Width = 82;
            // 
            // NgayHT
            // 
            this.NgayHT.Caption = "Ngày HT";
            this.NgayHT.MinWidth = 22;
            this.NgayHT.Name = "NgayHT";
            this.NgayHT.Visible = true;
            this.NgayHT.VisibleIndex = 3;
            this.NgayHT.Width = 82;
            // 
            // NhanVien
            // 
            this.NhanVien.Caption = "Nhân Viên";
            this.NhanVien.MinWidth = 22;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Visible = true;
            this.NhanVien.VisibleIndex = 4;
            this.NhanVien.Width = 82;
            // 
            // chitunganquy
            // 
            this.chitunganquy.Caption = "Chi Từ Ngân Qũy";
            this.chitunganquy.MinWidth = 22;
            this.chitunganquy.Name = "chitunganquy";
            this.chitunganquy.Visible = true;
            this.chitunganquy.VisibleIndex = 5;
            this.chitunganquy.Width = 82;
            // 
            // TienNganQuy
            // 
            this.TienNganQuy.Caption = "Tiền Ngân Qũy";
            this.TienNganQuy.MinWidth = 25;
            this.TienNganQuy.Name = "TienNganQuy";
            this.TienNganQuy.Visible = true;
            this.TienNganQuy.VisibleIndex = 6;
            this.TienNganQuy.Width = 94;
            // 
            // chidennganquy
            // 
            this.chidennganquy.Caption = "Chi Đến Ngân Qũy";
            this.chidennganquy.MinWidth = 25;
            this.chidennganquy.Name = "chidennganquy";
            this.chidennganquy.Visible = true;
            this.chidennganquy.VisibleIndex = 7;
            this.chidennganquy.Width = 94;
            // 
            // SoChiTien
            // 
            this.SoChiTien.Caption = "SoChiTien";
            this.SoChiTien.MinWidth = 25;
            this.SoChiTien.Name = "SoChiTien";
            this.SoChiTien.Visible = true;
            this.SoChiTien.VisibleIndex = 8;
            this.SoChiTien.Width = 94;
            // 
            // lydo
            // 
            this.lydo.Caption = "Lý Do";
            this.lydo.MinWidth = 25;
            this.lydo.Name = "lydo";
            this.lydo.Visible = true;
            this.lydo.VisibleIndex = 9;
            this.lydo.Width = 94;
            // 
            // ckb_Khomacdinh
            // 
            this.ckb_Khomacdinh.Location = new System.Drawing.Point(438, 113);
            this.ckb_Khomacdinh.Name = "ckb_Khomacdinh";
            this.ckb_Khomacdinh.Properties.Caption = "Kho mặc định";
            this.ckb_Khomacdinh.Size = new System.Drawing.Size(125, 21);
            this.ckb_Khomacdinh.TabIndex = 86;
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(152, 114);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(174, 22);
            this.txtTenKho.TabIndex = 85;
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(153, 86);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(173, 22);
            this.txtMaKho.TabIndex = 84;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(62, 117);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 16);
            this.labelControl8.TabIndex = 83;
            this.labelControl8.Text = "Tên kho";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(62, 86);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 16);
            this.labelControl9.TabIndex = 82;
            this.labelControl9.Text = "Mã Kho";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(29, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 21);
            this.labelControl3.TabIndex = 87;
            this.labelControl3.Text = "DANH MỤC KHO";
            // 
            // frm_ThongTinKho
            // 
            this.ClientSize = new System.Drawing.Size(670, 568);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ckb_Khomacdinh);
            this.Controls.Add(this.txtTenKho);
            this.Controls.Add(this.txtMaKho);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_InAn);
            this.Name = "frm_ThongTinKho";
            this.Load += new System.EventHandler(this.frm_ThongTinKho_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_Khomacdinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_khomacdinh;
        private DevExpress.XtraGrid.Columns.GridColumn gc_tenkho;
        private DevExpress.XtraGrid.Columns.GridColumn gc_makho;
        private DevExpress.XtraGrid.Columns.GridColumn gcSTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gc_TTkho;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_InAn;
        private DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn NgLap;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHT;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn chitunganquy;
        private DevExpress.XtraGrid.Columns.GridColumn TienNganQuy;
        private DevExpress.XtraGrid.Columns.GridColumn chidennganquy;
        private DevExpress.XtraGrid.Columns.GridColumn SoChiTien;
        private DevExpress.XtraGrid.Columns.GridColumn lydo;
        private DevExpress.XtraEditors.CheckEdit ckb_Khomacdinh;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn MaKho;
        private DevExpress.XtraGrid.Columns.GridColumn TenKho;
        private DevExpress.XtraGrid.Columns.GridColumn KhoMacDinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}