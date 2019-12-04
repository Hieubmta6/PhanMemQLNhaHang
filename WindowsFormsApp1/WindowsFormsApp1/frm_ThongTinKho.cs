using DevExpress.XtraEditors.Repository;
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
    public partial class frm_ThongTinKho : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        DMKHO_DALL h = new DMKHO_DALL();
        DMKho k = new DMKho();
        public frm_ThongTinKho()
        {
            InitializeComponent();
        }

        private void frm_ThongTinKho_Load_1(object sender, EventArgs e)
        {
            gridControl1.DataSource = h.LoadDL();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(ckb_Khomacdinh.Checked == true)
            {
                 h.them(txtMaKho.Text , txtTenKho.Text,true);
            }
           else
            {
                h.them(txtMaKho.Text, txtTenKho.Text, false);
            }
            gridControl1.DataSource = h.LoadDL();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
        }
    }
}
