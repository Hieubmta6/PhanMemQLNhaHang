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
    public partial class frm_DanhSachKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KhachHang_DAL y = new KhachHang_DAL();
        public frm_DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = y.LoadDL();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
