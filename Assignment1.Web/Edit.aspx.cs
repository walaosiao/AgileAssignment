using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT

namespace Assignment1.Web
{
    public partial class Edit : System.Web.UI.Page
    {

        string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
        SqlCommand com;
        string str;
        // Allow admin search the route record
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            /*open connection to database*/
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from route where RouteID='" + txtID.Text.Trim() + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                txtDepart.Text = reader["RouteDepart"].ToString();

                txtDest.Text = reader["RouteDestination"].ToString();

                txtFare.Text = reader["BusFare"].ToString();

                reader.Close();
                

            }
            

            con.Close();
        }

        // Allow admin update the route detail
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            String strUpdate;
            SqlCommand cmdUpdate;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strUpdate = "Update route Set RouteDepart=@RouteDepart,RouteDestination=@RouteDestination,BusFare=@BusFare Where RouteID=@RouteID";

            cmdUpdate = new SqlCommand(strUpdate, conCust);
            cmdUpdate.Parameters.AddWithValue("@RouteID", txtID.Text);
            cmdUpdate.Parameters.AddWithValue("@RouteDepart", txtDepart.Text);
            cmdUpdate.Parameters.AddWithValue("@RouteDestination", txtDest.Text);
            cmdUpdate.Parameters.AddWithValue("@BusFare", txtFare.Text);
             cmdUpdate.ExecuteNonQuery();

            conCust.Close();
        }

        

        protected void txtFare_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }
 