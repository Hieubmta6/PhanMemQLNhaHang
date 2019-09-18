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
    public partial class uc_DanhMuc : UserControl
    {
        public uc_DanhMuc()
        {
            InitializeComponent();
        }

        private void btn_ThemMoiHangHoa_Click(object sender, EventArgs e)
        {
            frm_themmoihanghoa t = new frm_themmoihanghoa();
            t.ShowDialog();
            this.Show();
        }

        private void btn_ttkh_Click(object sender, EventArgs e)
        {
            frm_ThongTinKho k = new frm_ThongTinKho();
            k.ShowDialog();
            this.Show();
         
        }

        private void btn_khaibaokhuvuc_Click(object sender, EventArgs e)
        {
            frm_KhaiBaoKhuVuc v = new frm_KhaiBaoKhuVuc();
            v.ShowDialog();
            this.Show();
        }

        private void btn_KhaiBaoThoiDiemBan_Click(object sender, EventArgs e)
        {
            frm_KhaiBaoThoiDiemBan b = new frm_KhaiBaoThoiDiemBan();
            b.ShowDialog();
            this.Show();
        }

        private void btn_ThemMoiNhaCungCap_Click(object sender, EventArgs e)
        {
            frm_ThemMoiNhaCungCap c = new frm_ThemMoiNhaCungCap();
            c.ShowDialog();
            this.Show();
        }

        private void btn_ThemMoiKhachHang_Click(object sender, EventArgs e)
        {
            frm_ThemMoiKhachHang h = new frm_ThemMoiKhachHang();
            h.ShowDialog();
            this.Show();
        }

        private void btn_themmoinhanvien_Click(object sender, EventArgs e)
        {
            frm_ThemMoiNhanVien n = new frm_ThemMoiNhanVien();
            n.ShowDialog();
            this.Show();
        }

        private void btn_DSHH_Click(object sender, EventArgs e)
        {
            frm_DSHANGHOA hh = new frm_DSHANGHOA();
            hh.ShowDialog();
            this.Show();
        }

        private void btn_DSKH_Click(object sender, EventArgs e)
        {
            frm_DanhSachKhachHang kh = new frm_DanhSachKhachHang();
            kh.ShowDialog();
            kh.Show();
        }

        private void btn_DSNCC_Click(object sender, EventArgs e)
        {
            frm_Danhsachnhacungcap ncc = new frm_Danhsachnhacungcap();
            ncc.ShowDialog();
            ncc.Show();
        }

        private void btn_DSNV_Click(object sender, EventArgs e)
        {
            frm_DanhSchNhanVien nv = new frm_DanhSchNhanVien();
            nv.ShowDialog();
            nv.Show();
        }

        private void lb_PNHH_Click(object sender, EventArgs e)
        {
            frm_PhanNhomHangHoa phh = new frm_PhanNhomHangHoa();
            phh.ShowDialog();
            this.Show();
        }

        private void lb_PNKH_Click(object sender, EventArgs e)
        {
            frm_PhanNhomKhachHang nkh = new frm_PhanNhomKhachHang();
            nkh.ShowDialog();
            nkh.Show();
        }

        private void lb_BPNV_Click(object sender, EventArgs e)
        {
            frm_BoPhanNhanVien pnv = new frm_BoPhanNhanVien();
            pnv.ShowDialog();
            this.Show();
        }

        private void lb_DMP_Click(object sender, EventArgs e)
        {
            frm_DanhMucPhi mp = new frm_DanhMucPhi();
            mp.ShowDialog();
            this.Show();
        }

        private void lb_DMTS_Click(object sender, EventArgs e)
        {
            frm_DanhMucThueSuat ts = new frm_DanhMucThueSuat();
            ts.ShowDialog();
            this.Show();
        }

        private void lb_HTTT_Click(object sender, EventArgs e)
        {
            frm_HinhThucThanhToan tt = new frm_HinhThucThanhToan();
            tt.ShowDialog();
            this.Show();
        }
    }
}
