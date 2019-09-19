namespace WindowsFormsApp1
{
    partial class frm_Baocaodoanhsonhomtheonam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Baocaodoanhsonhomtheonam));
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Tongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhiPhucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_Dieukienloc = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_InAn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Export = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // Tongtien
            // 
            this.Tongtien.Caption = "Tổng Tiền";
            this.Tongtien.MinWidth = 25;
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Visible = true;
            this.Tongtien.VisibleIndex = 6;
            this.Tongtien.Width = 94;
            // 
            // PhiPhucVu
            // 
            this.PhiPhucVu.Caption = "Phí Phục Vụ";
            this.PhiPhucVu.MinWidth = 22;
            this.PhiPhucVu.Name = "PhiPhucVu";
            this.PhiPhucVu.Visible = true;
            this.PhiPhucVu.VisibleIndex = 4;
            this.PhiPhucVu.Width = 82;
            // 
            // TienCK
            // 
            this.TienCK.Caption = "Tiền CK";
            this.TienCK.MinWidth = 25;
            this.TienCK.Name = "TienCK";
            this.TienCK.Visible = true;
            this.TienCK.VisibleIndex = 5;
            this.TienCK.Width = 94;
            // 
            // TienThue
            // 
            this.TienThue.Caption = "Tiền Thuế";
            this.TienThue.MinWidth = 22;
            this.TienThue.Name = "TienThue";
            this.TienThue.Visible = true;
            this.TienThue.VisibleIndex = 3;
            this.TienThue.Width = 82;
            // 
            // tenhang
            // 
            this.tenhang.Caption = "Tên Hàng";
            this.tenhang.MinWidth = 22;
            this.tenhang.Name = "tenhang";
            this.tenhang.Visible = true;
            this.tenhang.VisibleIndex = 2;
            this.tenhang.Width = 82;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày ";
            this.Ngay.MinWidth = 22;
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 82;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ngay,
            this.tenhang,
            this.TienThue,
            this.TienCK,
            this.PhiPhucVu,
            this.Tongtien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowHtmlDrawGroups = false;
            this.gridView1.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-17, 133);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(969, 392);
            this.gridControl1.TabIndex = 84;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TimKiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_TimKiem.ImageOptions.SvgImage")));
            this.btn_TimKiem.Location = new System.Drawing.Point(804, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(129, 46);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "tìm kiếm";
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
            // btn_Dieukienloc
            // 
            this.btn_Dieukienloc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Dieukienloc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dieukienloc.ImageOptions.SvgImage")));
            this.btn_Dieukienloc.Location = new System.Drawing.Point(2, 2);
            this.btn_Dieukienloc.Name = "btn_Dieukienloc";
            this.btn_Dieukienloc.Size = new System.Drawing.Size(124, 46);
            this.btn_Dieukienloc.TabIndex = 0;
            this.btn_Dieukienloc.Text = "Điều kiện lọc";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(604, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 40);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Mở rộng";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Dong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dong.ImageOptions.SvgImage")));
            this.btn_Dong.Location = new System.Drawing.Point(742, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(82, 47);
            this.btn_Dong.TabIndex = 16;
            this.btn_Dong.Text = "Đóng";
            // 
            // btn_InAn
            // 
            this.btn_InAn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_InAn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InAn.ImageOptions.Image")));
            this.btn_InAn.Location = new System.Drawing.Point(824, 2);
            this.btn_InAn.Name = "btn_InAn";
            this.btn_InAn.Size = new System.Drawing.Size(109, 47);
            this.btn_InAn.TabIndex = 10;
            this.btn_InAn.Text = "mở rộng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(469, 36);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Báo cáo doanh thu nhóm theo năm";
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
            this.btn_Export.Location = new System.Drawing.Point(721, 5);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(111, 40);
            this.btn_Export.TabIndex = 9;
            this.btn_Export.Text = "Export";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_TimKiem);
            this.panelControl1.Controls.Add(this.comboBoxEdit2);
            this.panelControl1.Controls.Add(this.btn_Dieukienloc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 61);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(935, 50);
            this.panelControl1.TabIndex = 83;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.btn_Dong);
            this.panelControl2.Controls.Add(this.btn_InAn);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.btn_Export);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(935, 51);
            this.panelControl2.TabIndex = 82;
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(935, 10);
            this.panelControl4.TabIndex = 81;
            // 
            // frm_Baocaodoanhsonhomtheonam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 542);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl4);
            this.Name = "frm_Baocaodoanhsonhomtheonam";
            this.Text = "frm_Baocaodoanhsonhomtheonam";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn Tongtien;
        private DevExpress.XtraGrid.Columns.GridColumn PhiPhucVu;
        private DevExpress.XtraGrid.Columns.GridColumn TienCK;
        private DevExpress.XtraGrid.Columns.GridColumn TienThue;
        private DevExpress.XtraGrid.Columns.GridColumn tenhang;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.SimpleButton btn_Dieukienloc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.XtraEditors.SimpleButton btn_InAn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Export;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
    }
}