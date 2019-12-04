using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketnoi
{
    public class Class1
    {
        string contr = @"Data Source=DESKTOP-BDFTKDM\SQLEXPRESS;Initial Catalog=QUANLYNHAHANG;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Fill(data);
            con.Close();
            return data;
        }
    }
}
