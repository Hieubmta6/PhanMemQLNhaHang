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
    public partial class uc_ThuChi : UserControl
    {
        public uc_ThuChi()
        {
            InitializeComponent();
        }

        private void btn_PhieuThuTien_Click(object sender, EventArgs e)
        {
            frm_PhieuThuTien t = new frm_PhieuThuTien();
            t.ShowDialog();
        }

        private void btn_ThuQuaNHgiaybaoco_Click(object sender, EventArgs e)
        {
            frm_ThuQuaNganHangGiayBaoCo u = new frm_ThuQuaNganHangGiayBaoCo();
            u.ShowDialog();
            this.Show();
        }

        private void btn_PhieuChiTien_Click(object sender, EventArgs e)
        {
            Frm_PhieuChiTien p = new Frm_PhieuChiTien();
            p.ShowDialog();
            this.Show();
        }

        private void btn_ChiQuaNganHangGiayBaoNo_Click(object sender, EventArgs e)
        {
            frm_thuquanganhanggiaybaono y = new frm_thuquanganhanggiaybaono();
            y.ShowDialog();
            this.Show();
        }

        private void btn_ChuyenNganQuy_Click(object sender, EventArgs e)
        {
            frm_ChuyenNganQuy f = new frm_ChuyenNganQuy();
            f.ShowDialog();
            this.Show();
        }

        private void btn_BangKePhieuThuTien_Click(object sender, EventArgs e)
        {
            frm_BangKePhieuThuTien c = new frm_BangKePhieuThuTien();
            c.ShowDialog();
            this.Show();
        }

        private void btn_BangKeThuQuaNganHang_Click(object sender, EventArgs e)
        {
            frm_BangKEThuQuaNganHang a = new frm_BangKEThuQuaNganHang();
            a.ShowDialog();
            this.Show();
        }

        private void btn_BangKePhieuChitien_Click(object sender, EventArgs e)
        {
            frm_BangKePhieuChiTien s = new frm_BangKePhieuChiTien();
            s.ShowDialog();
            this.Show();
        }

        private void btn_BKCQNH_Click(object sender, EventArgs e)
        {
            frm_BangKeChiQuaNganHang d = new frm_BangKeChiQuaNganHang();
            d.ShowDialog();
            this.Show();
        }

        private void btn_BangKeNganHang_Click(object sender, EventArgs e)
        {
            frm_BangKeNganHang w = new frm_BangKeNganHang();
            w.ShowDialog();
            this.Show();
        }

        private void lb_SoQuyTienMat_Click(object sender, EventArgs e)
        {
            frm_SoQuyTienMat x = new frm_SoQuyTienMat();
            x.ShowDialog();
            this.Show();
        }

        private void lb_SoQuyNH_Click(object sender, EventArgs e)
        {

        }

        private void lb_TongHopChiPhiDoanhNghiep_Click(object sender, EventArgs e)
        {
            frm_TongHopChiPhiDoanhNghiep m = new frm_TongHopChiPhiDoanhNghiep();
            m.ShowDialog();
            this.Show();
        }

        private void lb_KhauKhaoChiPhiTSCD_Click(object sender, EventArgs e)
        {
            frm_KhauHaoTSCD o = new frm_KhauHaoTSCD();
            o.ShowDialog();
            this.Show();
        }
    }
}
