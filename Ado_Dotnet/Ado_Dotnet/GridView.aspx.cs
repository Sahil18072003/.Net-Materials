using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Ado_Dotnet
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
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