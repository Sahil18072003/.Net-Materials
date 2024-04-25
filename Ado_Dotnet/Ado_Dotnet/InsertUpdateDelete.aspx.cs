using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace Ado_Dotnet
{
    public partial class InsertUpdateDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["emp"].ConnectionString;

            SqlConnection con = new SqlConnection(str);

            string eid = TextBox1.Text;
            string ename = TextBox2.Text;
            string salary = TextBox3.Text;
            string mid = TextBox4.Text;
            string did = TextBox5.Text;

            string query = "insert into employee values(@eid, @ename, @salary, @mid, @did)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@eid", eid);
            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@did", did);

            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                Console.WriteLine(a + " Value is inserted");
            }
            else
            {
                Console.WriteLine(a + " insersation");
            }

            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["emp"].ConnectionString;

            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand("select * from employee", con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            GridView1.DataSource = dr;

            GridView1.DataBind();

            con.Close();
        }
    }
}