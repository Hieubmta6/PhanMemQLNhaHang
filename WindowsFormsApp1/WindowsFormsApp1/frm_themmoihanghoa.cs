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
    public partial class frm_themmoihanghoa : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        HangHoa_DAL t = new HangHoa_DAL();
        public frm_themmoihanghoa()
        {
            InitializeComponent();
        }
        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (chk_HienThi.Checked == true && chk_TheoDoiTonKho.Checked == true && cb_SuDung.Checked == true)
            {
                t.Them(txt_MaHH.Text, txt_Cachtinhgiaton.Text, txt_TenHang.Text, txt_TiengAnh.Text, Txt_NhomHang.Text, txt_DVT.Text, float.Parse(txt_GiaBan.Text), int.Parse(txt_STT.Text), true, true, true);

            }
        }
        private void frm_themmoihanghoa_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (chk_HienThi.Checked == true && chk_TheoDoiTonKho.Checked == true && cb_SuDung.Checked == true)
            {
                t.Them(txt_MaHH.Text, txt_Cachtinhgiaton.Text, txt_TenHang.Text, txt_TiengAnh.Text, Txt_NhomHang.Text, txt_DVT.Text, float.Parse(txt_GiaBan.Text), int.Parse(txt_STT.Text),true,true,true);
            }
        }
    }
}
