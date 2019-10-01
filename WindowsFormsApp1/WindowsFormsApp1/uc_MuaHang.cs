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
    public partial class uc_MuaHang : UserControl
    {
        public uc_MuaHang()
        {
            InitializeComponent();
        }

        private void btn_DonDatHang_Click(object sender, EventArgs e)
        {
            frm_DonDatHang h = new frm_DonDatHang();
            h.ShowDialog();
            this.Show();
        }

        private void btn_HDMH_Click(object sender, EventArgs e)
        {
            frm_HoaDonMuaHang m = new frm_HoaDonMuaHang();
            m.ShowDialog();
            this.Show();
        }

        private void btn_khaibaokhuvuc_Click(object sender, EventArgs e)
        {
            frm_PhieuTraHang t = new frm_PhieuTraHang();
            t.ShowDialog();
            this.Show();
        }

        private void btn_BangKeDonDatHang_Click(object sender, EventArgs e)
        {
            frm_BangKeDonDatHang d = new frm_BangKeDonDatHang();
            d.ShowDialog();
            this.Show();
        }

        private void btn_BangKeHoaDonMua_Click(object sender, EventArgs e)
        {
            frm_BangKeHoaDonMua r = new frm_BangKeHoaDonMua();
            r.ShowDialog();
            this.Show();
        }

        private void btn_BangKePhieuTraHang_Click(object sender, EventArgs e)
        {
            frm_BangKePhieuTraHang o = new frm_BangKePhieuTraHang();
            o.ShowDialog();
            this.Show();
        }

        private void lb_BCTongHopMuaHang_Click(object sender, EventArgs e)
        {
            frm_BaoCaoTongHopMuaHang b = new frm_BaoCaoTongHopMuaHang();
            b.ShowDialog();
            this.Show();
        }

        private void lb_MHTheoNhaCungCap_Click(object sender, EventArgs e)
        {
            frm_BaoCaoMuaHangTheoNhaCungCap g = new frm_BaoCaoMuaHangTheoNhaCungCap();
            g.ShowDialog();
            this.Show();
        }

        private void lb_SCTMH_Click(object sender, EventArgs e)
        {
            frm_Sochitietmuahang j = new frm_Sochitietmuahang();
            j.ShowDialog();
            this.Show();
        }

        private void lb_BaoCaoTongHopTraHang_Click(object sender, EventArgs e)
        {
            frm_BaoCaoTongHopTraHang l = new frm_BaoCaoTongHopTraHang();
            l.ShowDialog();
            this.Show();
        }

        private void lb_THThucHienDonDatHang_Click(object sender, EventArgs e)
        {
            frm_TinhHinhThucHienDonDatHang y = new frm_TinhHinhThucHienDonDatHang();
            y.ShowDialog();
            this.Show();
        }
    }
}
