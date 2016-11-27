using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;
using System.Data;// IMPORTANT

namespace Assignment1.Web
{
    public partial class RouteList : System.Web.UI.Page
    {



        protected void GetRouteDetails(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager
                        .ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select * from route where RouteName like '%'+@SearchText+'%'";

                    cmd.Parameters.AddWithValue("@SearchText", this.txtRouteName.Text.Trim());
                    cmd.Connection = conn;
                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        this.GridView1.DataSource = ds;
                        this.GridView1.DataBind();

                    }
                    conn.Close();

                }
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> SearchRoute(string prefixText, int count)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager
                        .ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "Select RouteName From route where " +
                    "RouteName like @SearchTest + '%'";
                    cmd.Parameters.AddWithValue("@SearchText", prefixText);
                    cmd.Connection = conn;
                    conn.Open();
                    List<string> route = new List<string>();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            route.Add(sdr["RouteName"].ToString());
                        }
                    }
                    conn.Close();
                    return route;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}