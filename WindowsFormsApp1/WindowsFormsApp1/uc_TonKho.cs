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
    public partial class uc_TonKho : UserControl
    {
        public uc_TonKho()
        {
            InitializeComponent();
        }

        private void btn_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            Frm_PhieuNhapKho k = new Frm_PhieuNhapKho();
            k.ShowDialog();
            this.Show();
        }

        private void btn_PhieuXuatKho_Click(object sender, EventArgs e)
        {
            frm_PhieuXuatKho x = new frm_PhieuXuatKho();
            x.ShowDialog();
            this.Show();
        }

        private void btn_PhieuChuyenKho_Click(object sender, EventArgs e)
        {
            frm_Phieuchuyenkho c = new frm_Phieuchuyenkho();
            c.ShowDialog();
            this.Show();
        }

        private void btn_KhaiBaoDinhLuong_Click(object sender, EventArgs e)
        {
            frm_KhaiBaoDinhLuong t = new frm_KhaiBaoDinhLuong();
            t.ShowDialog();
            this.Show();
        }

        private void btn_TinhDinhLuong_Click(object sender, EventArgs e)
        {
            frm_TinhDinhLuong u = new frm_TinhDinhLuong();
            u.ShowDialog();
            this.Show();
        }

        private void btn_BangKePhieuNhapKho_Click(object sender, EventArgs e)
        {
           frm_BangKePhieuThuTien y = new frm_BangKePhieuThuTien();
            y.ShowDialog();
            this.Show();
        }

        private void btn_BangKePhieuXuatKho_Click(object sender, EventArgs e)
        {
            frm_BangKePhieuXuatKho q = new frm_BangKePhieuXuatKho();
            q.ShowDialog();
            this.Show();
        }

        private void btn_BangKePhieuChuyenKho_Click(object sender, EventArgs e)
        {
            frm_BangKePhieuChuyenKho x = new frm_BangKePhieuChuyenKho();
            x.ShowDialog();
            this.Show();
        }

        private void btn_BKKBDinhLuong_Click(object sender, EventArgs e)
        {
            frm_BangKeKhaiBaoDinhLuong b = new frm_BangKeKhaiBaoDinhLuong();
            b.ShowDialog();
            this.Show();
        }

        private void btn_TinhGiaVon_Click(object sender, EventArgs e)
        {
            frm_TinhGiaVon n = new frm_TinhGiaVon();
            n.ShowDialog();
            this.Show();
        }

        private void lb_TongHopNhapXuatTon_Click(object sender, EventArgs e)
        {
            frm_Tonghopnhapxuatton t = new frm_Tonghopnhapxuatton();
            t.ShowDialog();
            this.Show();
        }

        private void lb_BCTonKho_Click(object sender, EventArgs e)
        {
            frm_BaoCaoTonKho l = new frm_BaoCaoTonKho();
            l.ShowDialog();
            this.Show();
        }

        private void lb_TheKho_Click(object sender, EventArgs e)
        {
            frm_TheKho i = new frm_TheKho();
            i.ShowDialog();
            this.Show();
        }

        private void lb_SoChiTietHangHoa_Click(object sender, EventArgs e)
        {
            frm_Sochitiethanghoa p = new frm_Sochitiethanghoa();
            p.ShowDialog();
            this.Show();
        }
    }
}
