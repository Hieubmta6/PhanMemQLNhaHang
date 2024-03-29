﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_trangchu : DevExpress.XtraEditors.XtraForm
    {
        public frm_trangchu()
        {
            InitializeComponent();
        }
        private void btn_NhacNho_Click(object sender, EventArgs e)
        {
            uc_NhacNho t = new uc_NhacNho();
            epcontrol(t);
        }
        private void epcontrol(Control c)
        {
            c.Dock = DockStyle.Fill;
            pn_chinh.Controls.Clear();
            pn_chinh.Controls.Add(c);

        }
        private void btn_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            Frm_PhieuNhapKho n = new Frm_PhieuNhapKho();
            n.ShowDialog();
            this.Show();
        }

        private void btn_PhieuChiTien_Click(object sender, EventArgs e)
        {
            Frm_PhieuChiTien t = new Frm_PhieuChiTien();
            t.ShowDialog();
            this.Show();
        }

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            uc_DanhMuc d = new uc_DanhMuc();
            epcontrol(d);
        }
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            uc_BanHang b = new uc_BanHang();
            epcontrol(b);
        }

        private void btn_MuaHang_Click(object sender, EventArgs e)
        {
            uc_MuaHang m = new uc_MuaHang();
            epcontrol(m);
        }

        private void btn_CongNo_Click(object sender, EventArgs e)
        {
            uc_CongNo cn = new uc_CongNo();
            epcontrol(cn);
        }

        private void btn_TonKho_Click(object sender, EventArgs e)
        {
            uc_TonKho tk = new uc_TonKho();
            epcontrol(tk);
        }

        private void btn_ThuChi_Click(object sender, EventArgs e)
        {
            uc_ThuChi tc = new uc_ThuChi();
            epcontrol(tc);
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            uc_KhuyenMai km = new uc_KhuyenMai();
            epcontrol(km);
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            uc_BaoCao bc = new uc_BaoCao();
            epcontrol(bc);
        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {
            uc_HeThong ht = new uc_HeThong();
            epcontrol(ht);
        }

        private void frm_trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show("ban co muon thoát ko", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //sdsdsds

    }
}
