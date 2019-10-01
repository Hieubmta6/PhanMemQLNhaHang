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
    public partial class uc_KhuyenMai : UserControl
    {
        public uc_KhuyenMai()
        {
            InitializeComponent();
        }

        private void btn_TheVip_Click(object sender, EventArgs e)
        {
            frm_TheVip v = new frm_TheVip();
            v.ShowDialog();
            this.Show();
        }

        private void btn_ChietKhau_Click(object sender, EventArgs e)
        {
            frm_ChietKhau o = new frm_ChietKhau();
            o.ShowDialog();
            this.Show();
        }

        private void btn_KhuyenMaiTheoHoaDon_Click(object sender, EventArgs e)
        {
            frm_KhuyenMaiTheoHoaDon p = new frm_KhuyenMaiTheoHoaDon();
            p.ShowDialog();
            this.Show();
        }

        private void btn_KhuyenMaiTheoHangHoa_Click(object sender, EventArgs e)
        {
            frm_KhuyenMaiTheoHangHoa u = new frm_KhuyenMaiTheoHangHoa();
            u.ShowDialog();
            this.Show();
        }

        private void btn_KhuyenMaiTangHang_Click(object sender, EventArgs e)
        {
            frm_KhuyenMaiTangHang t = new frm_KhuyenMaiTangHang();
            t.ShowDialog();
            this.Show();
        }

        private void btn_BangKeTheVip_Click(object sender, EventArgs e)
        {
            frm_BangKeTheVip u = new frm_BangKeTheVip();
            u.ShowDialog();
            this.Show();
        }

        private void btn_BangKeKhuyenMai_Click(object sender, EventArgs e)
        {
            frm_BangKeKhuyenMai r = new frm_BangKeKhuyenMai();
            r.ShowDialog();
            this.Show();
        }

        private void btn_DoiDiem_Click(object sender, EventArgs e)
        {
            frm_DoiDiem k = new frm_DoiDiem();
            k.ShowDialog();
            this.Show();
        }

        private void lb_BCDSTheVip_Click(object sender, EventArgs e)
        {
            frm_BaoCaoDoanhSoTheVip q = new frm_BaoCaoDoanhSoTheVip();
            q.ShowDialog();
            this.Show();
        }

        private void lb_BCCTDSTheVip_Click(object sender, EventArgs e)
        {
            frm_BaoCaoChiTietDoanhSoTheoTheVip j = new frm_BaoCaoChiTietDoanhSoTheoTheVip();
            j.ShowDialog();
            this.Show();
        }
    }
}
