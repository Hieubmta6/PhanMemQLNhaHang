namespace WindowsFormsApp1
{
    partial class frm_BangKeNganHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BangKeNganHang));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChiTuNganQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tiennganquy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chidennganquy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTienChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LyDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_InAn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(540, 450);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 450);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(800, 0);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton1.Location = new System.Drawing.Point(5, 609);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(201, 29);
            this.simpleButton1.TabIndex = 84;
            this.simpleButton1.Text = "Xuất dữ liệu lưới ra excel";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 94);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(1078, 498);
            this.gridControl1.TabIndex = 83;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MaPhieu,
            this.NgLap,
            this.NgayHT,
            this.HinhThuc,
            this.NhanVien,
            this.ChiTuNganQuy,
            this.Tiennganquy,
            this.Chidennganquy,
            this.SoTienChi,
            this.LyDo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowHtmlDrawGroups = false;
            this.gridView1.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
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
            // HinhThuc
            // 
            this.HinhThuc.Caption = "Hình Thức";
            this.HinhThuc.MinWidth = 22;
            this.HinhThuc.Name = "HinhThuc";
            this.HinhThuc.Visible = true;
            this.HinhThuc.VisibleIndex = 4;
            this.HinhThuc.Width = 82;
            // 
            // NhanVien
            // 
            this.NhanVien.Caption = "Nhân viên";
            this.NhanVien.MinWidth = 22;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Visible = true;
            this.NhanVien.VisibleIndex = 5;
            this.NhanVien.Width = 82;
            // 
            // ChiTuNganQuy
            // 
            this.ChiTuNganQuy.Caption = "Chi Từ Ngân Qũy";
            this.ChiTuNganQuy.MinWidth = 25;
            this.ChiTuNganQuy.Name = "ChiTuNganQuy";
            this.ChiTuNganQuy.Visible = true;
            this.ChiTuNganQuy.VisibleIndex = 6;
            this.ChiTuNganQuy.Width = 94;
            // 
            // Tiennganquy
            // 
            this.Tiennganquy.Caption = "TienNganQuy";
            this.Tiennganquy.MinWidth = 25;
            this.Tiennganquy.Name = "Tiennganquy";
            this.Tiennganquy.Visible = true;
            this.Tiennganquy.VisibleIndex = 7;
            this.Tiennganquy.Width = 94;
            // 
            // Chidennganquy
            // 
            this.Chidennganquy.Caption = "Chi Đến Ngân Qũy";
            this.Chidennganquy.MinWidth = 25;
            this.Chidennganquy.Name = "Chidennganquy";
            this.Chidennganquy.Visible = true;
            this.Chidennganquy.VisibleIndex = 8;
            this.Chidennganquy.Width = 94;
            // 
            // SoTienChi
            // 
            this.SoTienChi.Caption = "SoTienChi";
            this.SoTienChi.MinWidth = 25;
            this.SoTienChi.Name = "SoTienChi";
            this.SoTienChi.Visible = true;
            this.SoTienChi.VisibleIndex = 9;
            this.SoTienChi.Width = 94;
            // 
            // LyDo
            // 
            this.LyDo.Caption = "Lý Do";
            this.LyDo.MinWidth = 25;
            this.LyDo.Name = "LyDo";
            this.LyDo.Visible = true;
            this.LyDo.VisibleIndex = 10;
            this.LyDo.Width = 94;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Dong);
            this.panelControl2.Controls.Add(this.btn_Xoa);
            this.panelControl2.Controls.Add(this.btn_Them);
            this.panelControl2.Controls.Add(this.btn_Sua);
            this.panelControl2.Controls.Add(this.btn_InAn);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.btn_Export);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1080, 57);
            this.panelControl2.TabIndex = 82;
            // 
            // btn_Dong
            // 
            this.btn_Dong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dong.ImageOptions.SvgImage")));
            this.btn_Dong.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Dong.Location = new System.Drawing.Point(1000, 16);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(82, 29);
            this.btn_Dong.TabIndex = 16;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa.Location = new System.Drawing.Point(662, 16);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 29);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            // 
            // btn_Them
            // 
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them.Location = new System.Drawing.Point(485, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(82, 29);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            // 
            // btn_Sua
            // 
            this.btn_Sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sua.ImageOptions.SvgImage")));
            this.btn_Sua.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua.Location = new System.Drawing.Point(575, 16);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(82, 29);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            // 
            // btn_InAn
            // 
            this.btn_InAn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InAn.ImageOptions.Image")));
            this.btn_InAn.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_InAn.Location = new System.Drawing.Point(885, 16);
            this.btn_InAn.Name = "btn_InAn";
            this.btn_InAn.Size = new System.Drawing.Size(102, 29);
            this.btn_InAn.TabIndex = 10;
            this.btn_InAn.Text = "mở rộng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(303, 36);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Bảng kê phiếu thu tiền";
            // 
            // panelControl3
            // 
            this.panelControl3.Location = new System.Drawing.Point(97, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(7, 14);
            this.panelControl3.TabIndex = 0;
            // 
            // btn_Export
            // 
            this.btn_Export.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Export.ImageOptions.SvgImage")));
            this.btn_Export.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_Export.Location = new System.Drawing.Point(750, 16);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(82, 29);
            this.btn_Export.TabIndex = 9;
            this.btn_Export.Text = "Export";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1080, 10);
            this.panelControl4.TabIndex = 81;
            // 
            // frm_BangKeNganHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Name = "frm_BangKeNganHang";
            this.Text = "frm_BangKeNganHang";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn NgLap;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHT;
        private DevExpress.XtraGrid.Columns.GridColumn HinhThuc;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ChiTuNganQuy;
        private DevExpress.XtraGrid.Columns.GridColumn Tiennganquy;
        private DevExpress.XtraGrid.Columns.GridColumn Chidennganquy;
        private DevExpress.XtraGrid.Columns.GridColumn SoTienChi;
        private DevExpress.XtraGrid.Columns.GridColumn LyDo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_InAn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}