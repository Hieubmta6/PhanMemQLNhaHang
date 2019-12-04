namespace WindowsFormsApp1
{
    partial class frm_TinhHinhThucHienDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TinhHinhThucHienDonDatHang));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_InAn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiencoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tiendat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLthuchien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienThucHien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.slhoanthanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienhoanthanh = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.panelControl2.Controls.Add(this.btn_InAn);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.btn_Export);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1098, 57);
            this.panelControl2.TabIndex = 79;
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
            this.labelControl1.Size = new System.Drawing.Size(448, 36);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tình hình thực hiện đơn đặt hàng";
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
            this.btn_Export.Location = new System.Drawing.Point(798, 16);
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
            this.panelControl4.Size = new System.Drawing.Size(1098, 10);
            this.panelControl4.TabIndex = 78;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 129);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1094, 494);
            this.gridControl1.TabIndex = 81;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STTHH,
            this.MaHang,
            this.TenHang,
            this.NgayGiao,
            this.tiencoc,
            this.SL,
            this.tiendat,
            this.SLthuchien,
            this.TienThucHien,
            this.slhoanthanh,
            this.tienhoanthanh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowHtmlDrawGroups = false;
            this.gridView1.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // STTHH
            // 
            this.STTHH.Caption = "STT";
            this.STTHH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.STTHH.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.STTHH.MinWidth = 22;
            this.STTHH.Name = "STTHH";
            this.STTHH.Visible = true;
            this.STTHH.VisibleIndex = 0;
            this.STTHH.Width = 56;
            // 
            // MaHang
            // 
            this.MaHang.Caption = "Mã Hàng";
            this.MaHang.MinWidth = 22;
            this.MaHang.Name = "MaHang";
            this.MaHang.Visible = true;
            this.MaHang.VisibleIndex = 1;
            this.MaHang.Width = 56;
            // 
            // TenHang
            // 
            this.TenHang.Caption = "Tên Hàng";
            this.TenHang.MinWidth = 22;
            this.TenHang.Name = "TenHang";
            this.TenHang.Visible = true;
            this.TenHang.VisibleIndex = 2;
            this.TenHang.Width = 56;
            // 
            // NgayGiao
            // 
            this.NgayGiao.Caption = "Ngày giao";
            this.NgayGiao.MinWidth = 22;
            this.NgayGiao.Name = "NgayGiao";
            this.NgayGiao.Visible = true;
            this.NgayGiao.VisibleIndex = 3;
            this.NgayGiao.Width = 56;
            // 
            // tiencoc
            // 
            this.tiencoc.Caption = "Tiền cọc ";
            this.tiencoc.MinWidth = 25;
            this.tiencoc.Name = "tiencoc";
            this.tiencoc.Visible = true;
            this.tiencoc.VisibleIndex = 4;
            this.tiencoc.Width = 77;
            // 
            // SL
            // 
            this.SL.Caption = "SL đặt";
            this.SL.MinWidth = 25;
            this.SL.Name = "SL";
            this.SL.Visible = true;
            this.SL.VisibleIndex = 5;
            this.SL.Width = 59;
            // 
            // tiendat
            // 
            this.tiendat.Caption = "Tiền đặt";
            this.tiendat.MinWidth = 22;
            this.tiendat.Name = "tiendat";
            this.tiendat.Visible = true;
            this.tiendat.VisibleIndex = 6;
            this.tiendat.Width = 56;
            // 
            // SLthuchien
            // 
            this.SLthuchien.Caption = "SL thực hiện";
            this.SLthuchien.MinWidth = 25;
            this.SLthuchien.Name = "SLthuchien";
            this.SLthuchien.Visible = true;
            this.SLthuchien.VisibleIndex = 7;
            this.SLthuchien.Width = 94;
            // 
            // TienThucHien
            // 
            this.TienThucHien.Caption = "Tiền thực hiện";
            this.TienThucHien.MinWidth = 25;
            this.TienThucHien.Name = "TienThucHien";
            this.TienThucHien.Visible = true;
            this.TienThucHien.VisibleIndex = 8;
            this.TienThucHien.Width = 94;
            // 
            // slhoanthanh
            // 
            this.slhoanthanh.Caption = "%SL hoàn thành";
            this.slhoanthanh.MinWidth = 25;
            this.slhoanthanh.Name = "slhoanthanh";
            this.slhoanthanh.Visible = true;
            this.slhoanthanh.VisibleIndex = 9;
            this.slhoanthanh.Width = 94;
            // 
            // tienhoanthanh
            // 
            this.tienhoanthanh.Caption = "%Tiền hoàn thành";
            this.tienhoanthanh.MinWidth = 25;
            this.tienhoanthanh.Name = "tienhoanthanh";
            this.tienhoanthanh.Visible = true;
            this.tienhoanthanh.VisibleIndex = 10;
            this.tienhoanthanh.Width = 94;
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
            this.panelControl1.Location = new System.Drawing.Point(4, 73);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1094, 50);
            this.panelControl1.TabIndex = 80;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_TimKiem.ImageOptions.SvgImage")));
            this.btn_TimKiem.Location = new System.Drawing.Point(953, 5);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(129, 29);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "tìm kiếm";
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.Location = new System.Drawing.Point(361, 12);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Size = new System.Drawing.Size(109, 22);
            this.comboBoxEdit3.TabIndex = 5;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(827, 9);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(109, 22);
            this.comboBoxEdit2.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(732, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Đến ngày";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(575, 12);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(109, 22);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(497, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Từ ngày";
            // 
            // btn_Dieukienloc
            // 
            this.btn_Dieukienloc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dieukienloc.ImageOptions.SvgImage")));
            this.btn_Dieukienloc.Location = new System.Drawing.Point(10, 5);
            this.btn_Dieukienloc.Name = "btn_Dieukienloc";
            this.btn_Dieukienloc.Size = new System.Drawing.Size(151, 29);
            this.btn_Dieukienloc.TabIndex = 0;
            this.btn_Dieukienloc.Text = "Điều kiện lọc";
            // 
            // frm_TinhHinhThucHienDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 670);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Name = "frm_TinhHinhThucHienDonDatHang";
            this.Text = "frm_TinhHinhThucHienDonDatHang";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.XtraEditors.SimpleButton btn_InAn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STTHH;
        private DevExpress.XtraGrid.Columns.GridColumn MaHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenHang;
        private DevExpress.XtraGrid.Columns.GridColumn NgayGiao;
        private DevExpress.XtraGrid.Columns.GridColumn tiencoc;
        private DevExpress.XtraGrid.Columns.GridColumn SL;
        private DevExpress.XtraGrid.Columns.GridColumn tiendat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Dieukienloc;
        private DevExpress.XtraGrid.Columns.GridColumn SLthuchien;
        private DevExpress.XtraGrid.Columns.GridColumn TienThucHien;
        private DevExpress.XtraGrid.Columns.GridColumn slhoanthanh;
        private DevExpress.XtraGrid.Columns.GridColumn tienhoanthanh;
    }
}