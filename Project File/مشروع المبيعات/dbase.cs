using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace مشروع_المبيعات
{
    class DBase
    {
        SqlConnection con;
        SqlCommand com;
        public DBase()
        {
            con = new SqlConnection(@"Data Source=≺∙∙∙≻;Initial Catalog=SAQ;Integrated Security=True");
        }

        public void dml(string q)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            com = new SqlCommand(q, con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public DataTable getdata(string q)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            com = new SqlCommand(q, con);
            com.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }
    }
}
