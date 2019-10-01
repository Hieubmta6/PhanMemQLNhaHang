using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.A
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=192.168.2.12,1433\DOANHO;Network Library=DBMSSOCN;Initial Catalog=sql_QL_DAWIN;User ID=m_client;Password=1234";
            SqlConnection con = new SqlConnection(str);
            DataTable t = new DataTable();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Account", con);
            adapter.Fill(t);
            con.Close();
            gridControl1.DataSource = t;
        }
    }
}
