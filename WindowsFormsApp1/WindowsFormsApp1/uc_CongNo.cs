using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class uc_CongNo : UserControl
    {
        public uc_CongNo()
        {
            InitializeComponent();
        }

        private void lb_CNPhaiThuChoTatCaKH_Click(object sender, EventArgs e)
        {
            frm_CongNoPhaiThuChoTatCaKhachHang h = new frm_CongNoPhaiThuChoTatCaKhachHang();
            h.ShowDialog();
            this.Show();
        }

        private void lb_CNPhaiThuTheoNhomKH_Click(object sender, EventArgs e)
        {
            frm_CongNoPhaiThuTheoNhomKhachHang n = new frm_CongNoPhaiThuTheoNhomKhachHang();
            n.Show();
            this.Show();
        }

        private void lb_CNPhaiThuTheoChungTu_Click(object sender, EventArgs e)
        {
            frm_CongNoPhaiThuTheoChungTu i = new frm_CongNoPhaiThuTheoChungTu();
            i.ShowDialog();
            this.Show();
        }

        private void lb_CNPTCuaMotKH_Click(object sender, EventArgs e)
        {
            frm_CongNoPhaiThuCuaMotKhachHang k = new frm_CongNoPhaiThuCuaMotKhachHang();
            k.ShowDialog();
            this.Show();
        }

        private void LB_CNPTraChoTCNCC_Click(object sender, EventArgs e)
        {
            frm_CongNoPhaiTraChoTatCaNhaCungCap o = new frm_CongNoPhaiTraChoTatCaNhaCungCap();
            o.ShowDialog();
            this.Show();
        }

        private void lb_CNPTraCMotNCC_Click(object sender, EventArgs e)
        {
            frm_CongNoPhaiTraChoMotNhaCungCap s = new frm_CongNoPhaiTraChoMotNhaCungCap();
            s.ShowDialog();
            this.Show();
        }

        private void lb_CNPTraTheoChungTu_Click(object sender, EventArgs e)
        {
            frm_CongNoPhaiTraTheoChungTu q = new frm_CongNoPhaiTraTheoChungTu();
            q.ShowDialog();
            this.Show();
        }
    }
}
