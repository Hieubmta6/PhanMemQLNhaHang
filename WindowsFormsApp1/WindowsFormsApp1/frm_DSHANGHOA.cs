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
    public partial class frm_DSHANGHOA : DevExpress.XtraEditors.XtraForm
    {
        HangHoa_DAL h = new HangHoa_DAL();
        HangHoa t = new HangHoa();
        public frm_DSHANGHOA()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DSHANGHOA_Load(object sender, EventArgs e)
        {
            gcData.DataSource = h.LoadDL();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gvData.GetFocusedRowCellValue("MaHang").ToString());
            string mamh = gvData.GetFocusedRowCellValue("MaHang").ToString();
            h.Xoa(mamh);
            gcData.DataSource = h.LoadDL();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_themmoihanghoa y = new frm_themmoihanghoa();
            y.ShowDialog();
            this.Show();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }
    }
}
