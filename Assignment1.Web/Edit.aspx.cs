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
            else
            {
                lblmsg.Text = "No record for this Bus.";
                txtDepart.Text = "";
                txtDest.Text = "";
                txtFare.Text = "";

            }

            con.Close();
        }

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

             lblmsg.Text = "Route details is updated";
             txtDepart.Text = "";
             txtDest.Text = "";
             txtFare.Text = "";
            conCust.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            string strDelete;
            SqlCommand cmdDelete;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strDelete = "Delete route where RouteID=@RouteID";
            cmdDelete = new SqlCommand(strDelete, conCust);

            cmdDelete.Parameters.AddWithValue("@RouteID",(txtID.Text));
            cmdDelete.ExecuteNonQuery();
            txtDepart.Text = "";
            txtDest.Text = "";
            txtFare.Text = "";

            conCust.Close();

           
                lblmsg.Text = "Record for this route is deleted";
   
            conCust.Close();
        }

        protected void txtFare_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }
 