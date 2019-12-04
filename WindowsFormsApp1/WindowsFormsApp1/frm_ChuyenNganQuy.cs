using System;
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
    public partial class frm_ChuyenNganQuy : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_ChuyenNganQuy()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
