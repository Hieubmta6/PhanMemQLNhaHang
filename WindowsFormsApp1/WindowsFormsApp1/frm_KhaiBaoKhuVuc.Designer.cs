namespace WindowsFormsApp1
{
    partial class frm_KhaiBaoKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KhaiBaoKhuVuc));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Mayin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenkhuvuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.makhuvuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btn_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaKV = new DevExpress.XtraEditors.TextEdit();
            this.txtMayIn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenKV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.chk_SuDung = new DevExpress.XtraEditors.CheckEdit();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_SuDung.Properties)).BeginInit();
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(512, 24);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Nhập thông tin khu vực lưới(Chọn máy in bil cho khu vực)";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Mayin
            // 
            this.Mayin.Caption = "Máy in";
            this.Mayin.FieldName = "MayIn";
            this.Mayin.MinWidth = 25;
            this.Mayin.Name = "Mayin";
            this.Mayin.Visible = true;
            this.Mayin.VisibleIndex = 2;
            this.Mayin.Width = 94;
            // 
            // tenkhuvuc
            // 
            this.tenkhuvuc.Caption = "Tên khu vực";
            this.tenkhuvuc.FieldName = "TenKV_V";
            this.tenkhuvuc.MinWidth = 25;
            this.tenkhuvuc.Name = "tenkhuvuc";
            this.tenkhuvuc.Visible = true;
            this.tenkhuvuc.VisibleIndex = 1;
            this.tenkhuvuc.Width = 94;
            // 
            // makhuvuc
            // 
            this.makhuvuc.Caption = "Mã KV";
            this.makhuvuc.FieldName = "MaKV";
            this.makhuvuc.MinWidth = 25;
            this.makhuvuc.Name = "makhuvuc";
            this.makhuvuc.Visible = true;
            this.makhuvuc.VisibleIndex = 0;
            this.makhuvuc.Width = 94;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.makhuvuc,
            this.tenkhuvuc,
            this.Mayin,
            this.Sudung});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // Sudung
            // 
            this.Sudung.Caption = "Sử Dụng";
            this.Sudung.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Sudung.FieldName = "SuDung";
            this.Sudung.MinWidth = 25;
            this.Sudung.Name = "Sudung";
            this.Sudung.Visible = true;
            this.Sudung.VisibleIndex = 3;
            this.Sudung.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 250);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(872, 277);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btn_Dong
            // 
            this.btn_Dong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dong.ImageOptions.SvgImage")));
            this.btn_Dong.Location = new System.Drawing.Point(761, 13);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(94, 29);
            this.btn_Dong.TabIndex = 16;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Luu.ImageOptions.SvgImage")));
            this.btn_Luu.Location = new System.Drawing.Point(645, 13);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 29);
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Location = new System.Drawing.Point(545, 13);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(264, 36);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thông tin Kho hàng";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Sua);
            this.panelControl2.Controls.Add(this.btn_Them);
            this.panelControl2.Controls.Add(this.btn_Dong);
            this.panelControl2.Controls.Add(this.btn_Luu);
            this.panelControl2.Controls.Add(this.btn_Xoa);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(872, 54);
            this.panelControl2.TabIndex = 19;
            // 
            // panelControl3
            // 
            this.panelControl3.Location = new System.Drawing.Point(111, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(8, 14);
            this.panelControl3.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(872, 10);
            this.panelControl1.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(60, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 17);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Mã khu vực";
            // 
            // txt_MaKV
            // 
            this.txt_MaKV.Location = new System.Drawing.Point(166, 109);
            this.txt_MaKV.Name = "txt_MaKV";
            this.txt_MaKV.Size = new System.Drawing.Size(125, 22);
            this.txt_MaKV.TabIndex = 24;
            // 
            // txtMayIn
            // 
            this.txtMayIn.Location = new System.Drawing.Point(514, 109);
            this.txtMayIn.Name = "txtMayIn";
            this.txtMayIn.Size = new System.Drawing.Size(125, 22);
            this.txtMayIn.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(410, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 16);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Máy in";
            // 
            // txt_TenKV
            // 
            this.txt_TenKV.Location = new System.Drawing.Point(166, 149);
            this.txt_TenKV.Name = "txt_TenKV";
            this.txt_TenKV.Size = new System.Drawing.Size(125, 22);
            this.txt_TenKV.TabIndex = 28;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(60, 152);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 17);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Tên khu vực";
            // 
            // chk_SuDung
            // 
            this.chk_SuDung.Location = new System.Drawing.Point(410, 151);
            this.chk_SuDung.Name = "chk_SuDung";
            this.chk_SuDung.Properties.Caption = "Sử dụng";
            this.chk_SuDung.Size = new System.Drawing.Size(94, 21);
            this.chk_SuDung.TabIndex = 29;
            // 
            // btn_Them
            // 
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.Location = new System.Drawing.Point(423, 13);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sua.ImageOptions.SvgImage")));
            this.btn_Sua.Location = new System.Drawing.Point(309, 13);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            // 
            // frm_KhaiBaoKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 527);
            this.Controls.Add(this.chk_SuDung);
            this.Controls.Add(this.txt_TenKV);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMayIn);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_MaKV);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_KhaiBaoKhuVuc";
            this.Text = "frm_KhaiBaoKho";
            this.Load += new System.EventHandler(this.frm_KhaiBaoKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_SuDung.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Mayin;
        private DevExpress.XtraGrid.Columns.GridColumn tenkhuvuc;
        private DevExpress.XtraGrid.Columns.GridColumn makhuvuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Sudung;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Dong;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_MaKV;
        private DevExpress.XtraEditors.TextEdit txtMayIn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TenKV;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chk_SuDung;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
    }
}