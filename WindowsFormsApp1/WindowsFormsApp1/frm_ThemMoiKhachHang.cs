using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace WindowsFormsApp1
{
    public partial class frm_ThemMoiKhachHang : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        KetNoi k = new KetNoi();

        public frm_ThemMoiKhachHang()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
