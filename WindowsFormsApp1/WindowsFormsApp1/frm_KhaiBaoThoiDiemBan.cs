using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;

namespace WindowsFormsApp1
{
    public partial class frm_KhaiBaoThoiDiemBan : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ThoiDiemBan_DAL B = new ThoiDiemBan_DAL();
        public frm_KhaiBaoThoiDiemBan()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_KhaiBaoThoiDiemBan_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = B.LoadDL();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //B.luu(gc_Mathoidiem.GetTextCaption, gc_Tenthoidiem.GetTextCaption, TimeSpan.Parse(gc_GioBatDau.GetTextCaption.ToString()), TimeSpan.Parse(gc_PHUTBD.ToString()));
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            B.add(txtMaTD.Text, txtTenTD.Text, TimeSpan.Parse(txtGBD.ToString()));
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maTD = gridView1.GetFocusedRowCellValue("MaThoiDiem").ToString();
            B.Xoa(maTD);
            gridControl1.DataSource = B.LoadDL();
        }
    }
}
