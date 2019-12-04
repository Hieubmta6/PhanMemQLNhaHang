namespace WindowsFormsApp1
{
    partial class frm_DSHANGHOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DSHANGHOA));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_InAn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tinhtonkho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cachtinhgiavon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Dieukienloc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Dong);
            this.panelControl2.Controls.Add(this.btn_Xoa);
            this.panelControl2.Controls.Add(this.btn_Them);
            this.panelControl2.Controls.Add(this.btn_Sua);
            this.panelControl2.Controls.Add(this.btn_InAn);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btn_Refresh);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.btn_Export);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1092, 54);
            this.panelControl2.TabIndex = 58;
            // 
            // btn_Dong
            // 
            this.btn_Dong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dong.ImageOptions.SvgImage")));
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
            this.btn_Xoa.Location = new System.Drawing.Point(662, 16);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 29);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.Location = new System.Drawing.Point(485, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(82, 29);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sua.ImageOptions.SvgImage")));
            this.btn_Sua.Location = new System.Drawing.Point(575, 16);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(82, 29);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_InAn
            // 
            this.btn_InAn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InAn.ImageOptions.Image")));
            this.btn_InAn.Location = new System.Drawing.Point(905, 16);
            this.btn_InAn.Name = "btn_InAn";
            this.btn_InAn.Size = new System.Drawing.Size(82, 29);
            this.btn_InAn.TabIndex = 10;
            this.btn_InAn.Text = "mở rộng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(283, 36);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Danh Sách Hàng Hóa";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(388, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(82, 29);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Import";
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
            this.panelControl4.Size = new System.Drawing.Size(1092, 10);
            this.panelControl4.TabIndex = 57;
            // 
            // gcData
            // 
            this.gcData.Location = new System.Drawing.Point(12, 119);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gcData.Size = new System.Drawing.Size(1072, 380);
            this.gcData.TabIndex = 59;
            this.gcData.UseEmbeddedNavigator = true;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STTHH,
            this.MaHang,
            this.TenHang,
            this.DVT,
            this.loai,
            this.sudung,
            this.tinhtonkho,
            this.cachtinhgiavon});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.AllowHtmlDrawGroups = false;
            this.gvData.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.OptionsView.ShowIndicator = false;
            // 
            // STTHH
            // 
            this.STTHH.Caption = "STT";
            this.STTHH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.STTHH.FieldName = "STT";
            this.STTHH.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.STTHH.MinWidth = 22;
            this.STTHH.Name = "STTHH";
            this.STTHH.Visible = true;
            this.STTHH.VisibleIndex = 0;
            this.STTHH.Width = 82;
            // 
            // MaHang
            // 
            this.MaHang.Caption = "Mã Hàng";
            this.MaHang.FieldName = "MaHang";
            this.MaHang.MinWidth = 25;
            this.MaHang.Name = "MaHang";
            this.MaHang.Visible = true;
            this.MaHang.VisibleIndex = 1;
            this.MaHang.Width = 94;
            // 
            // TenHang
            // 
            this.TenHang.Caption = "Tên Hàng";
            this.TenHang.FieldName = "TenHang_V";
            this.TenHang.MinWidth = 22;
            this.TenHang.Name = "TenHang";
            this.TenHang.Visible = true;
            this.TenHang.VisibleIndex = 2;
            this.TenHang.Width = 82;
            // 
            // DVT
            // 
            this.DVT.Caption = "ĐVT";
            this.DVT.FieldName = "DVT";
            this.DVT.MinWidth = 22;
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 3;
            this.DVT.Width = 82;
            // 
            // loai
            // 
            this.loai.Caption = "Loại";
            this.loai.FieldName = "LoaiHH";
            this.loai.MinWidth = 22;
            this.loai.Name = "loai";
            this.loai.Visible = true;
            this.loai.VisibleIndex = 4;
            this.loai.Width = 82;
            // 
            // sudung
            // 
            this.sudung.Caption = "Sử dụng";
            this.sudung.ColumnEdit = this.repositoryItemCheckEdit1;
            this.sudung.FieldName = "SuDung";
            this.sudung.MinWidth = 22;
            this.sudung.Name = "sudung";
            this.sudung.Visible = true;
            this.sudung.VisibleIndex = 5;
            this.sudung.Width = 82;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // tinhtonkho
            // 
            this.tinhtonkho.Caption = "Tính tồn kho";
            this.tinhtonkho.ColumnEdit = this.repositoryItemCheckEdit2;
            this.tinhtonkho.FieldName = "TinhTonKho";
            this.tinhtonkho.MinWidth = 22;
            this.tinhtonkho.Name = "tinhtonkho";
            this.tinhtonkho.Visible = true;
            this.tinhtonkho.VisibleIndex = 6;
            this.tinhtonkho.Width = 82;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // cachtinhgiavon
            // 
            this.cachtinhgiavon.Caption = "Cách tính G.vốn";
            this.cachtinhgiavon.FieldName = "CachTinhGiaVon";
            this.cachtinhgiavon.MinWidth = 22;
            this.cachtinhgiavon.Name = "cachtinhgiavon";
            this.cachtinhgiavon.Visible = true;
            this.cachtinhgiavon.VisibleIndex = 7;
            this.cachtinhgiavon.Width = 82;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_TimKiem);
            this.panelControl1.Controls.Add(this.comboBoxEdit3);
            this.panelControl1.Controls.Add(this.comboBoxEdit2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.comboBoxEdit1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Dieukienloc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1092, 54);
            this.panelControl1.TabIndex = 60;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_TimKiem.ImageOptions.SvgImage")));
            this.btn_TimKiem.Location = new System.Drawing.Point(953, 16);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(90, 29);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "tìm kiếm";
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.Location = new System.Drawing.Point(361, 23);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Size = new System.Drawing.Size(109, 22);
            this.comboBoxEdit3.TabIndex = 5;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(827, 20);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(109, 22);
            this.comboBoxEdit2.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(732, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Đến ngày";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(575, 23);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(109, 22);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(497, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Từ ngày";
            // 
            // btn_Dieukienloc
            // 
            this.btn_Dieukienloc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dieukienloc.ImageOptions.SvgImage")));
            this.btn_Dieukienloc.Location = new System.Drawing.Point(10, 16);
            this.btn_Dieukienloc.Name = "btn_Dieukienloc";
            this.btn_Dieukienloc.Size = new System.Drawing.Size(109, 29);
            this.btn_Dieukienloc.TabIndex = 0;
            this.btn_Dieukienloc.Text = "Điều kiện lọc";
            // 
            // frm_DSHANGHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 511);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Name = "frm_DSHANGHOA";
            this.Text = "DSHANGHOA";
            this.Load += new System.EventHandler(this.frm_DSHANGHOA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn STTHH;
        private DevExpress.XtraGrid.Columns.GridColumn TenHang;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn loai;
        private DevExpress.XtraGrid.Columns.GridColumn sudung;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn tinhtonkho;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn cachtinhgiavon;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Dieukienloc;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_InAn;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraGrid.Columns.GridColumn MaHang;
    }
}