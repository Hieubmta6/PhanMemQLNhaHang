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
    public partial class uc_BaoCao : UserControl
    {
        public uc_BaoCao()
        {
            InitializeComponent();
        }

        private void btn_BCCPhiTheoBoPhan_Click(object sender, EventArgs e)
        {
            frm_BaoCaoChiPhiTheoBoPhan t = new frm_BaoCaoChiPhiTheoBoPhan();
            t.ShowDialog();
            this.Show();
        }

        private void btn_BCKQkinhDoanh_Click(object sender, EventArgs e)
        {
            frm_BaoCaoKetQuaKinhDoanh k = new frm_BaoCaoKetQuaKinhDoanh();
            k.ShowDialog();
            this.Show();
        }

        private void btn_BangKeChungTuTheoMaPhi_Click(object sender, EventArgs e)
        {
            frm_BangKeChungTuTheoMaPhi o = new frm_BangKeChungTuTheoMaPhi();
            o.ShowDialog();
            this.Show();
        }

        private void btn_NhacNhoSinhNhat_Click(object sender, EventArgs e)
        {
            frm_NhacNhoSinhNhat n = new frm_NhacNhoSinhNhat();
            n.ShowDialog();
            this.Show();
        }
    }
}
