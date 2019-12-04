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
    public partial class frm_KhaiBaoKhuVuc : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        KhuVuc_DALL k = new KhuVuc_DALL();
        public frm_KhaiBaoKhuVuc()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_KhaiBaoKhuVuc_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = k.LoadDL();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (chk_SuDung.Checked == true)
            {
                k.them(txt_MaKV.Text, txt_TenKV.Text, true, txtMayIn.Text);
            }
            else
            {
                k.them(txt_MaKV.Text, txt_TenKV.Text, false, txtMayIn.Text);
            }
            gridControl1.DataSource = k.LoadDL();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            string makv = gridView1.GetFocusedRowCellValue("MaKV").ToString();
            k.Xoa(makv);
            gridControl1.DataSource = k.LoadDL();
        }
    }
}
