using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT
using System.Data;

namespace Assignment1.Web
{
    public partial class addroute : System.Web.UI.Page
    {
        //AUTO GENERATE ID
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = generateID();
        }
        private String generateID()
        {
            string strSelect; 
            SqlCommand cmdSelect;
            SqlDataReader dtr;
            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString; 
            conCust = new SqlConnection(connStr); strSelect = "Select RouteID From dbo.route";
            cmdSelect = new SqlCommand(strSelect, conCust);
            conCust.Open(); 
            dtr = cmdSelect.ExecuteReader();
            string lastValue = "";
            while (dtr.Read()) lastValue = dtr["RouteID"].ToString(); if (lastValue == "")
            {
                return "MR1000";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("MR", "")); genID = genID + 1; return ("MR" + genID.ToString());
            }
        }
        // Allow admin add route
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString);
            conn.Open();
            string name = txtDepart.Text + "-" + txtDest.Text;
            SqlCommand cmd = new SqlCommand("SELECT RouteName FROM route WHERE RouteName=@RouteName", conn);
            cmd.Parameters.AddWithValue("@RouteName", name);
            SqlDataReader reader = cmd.ExecuteReader();
            
                string strInsert;
                SqlCommand cmdInsert;
                SqlConnection conCust;
                string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
                conCust = new SqlConnection(connStr);


                strInsert = "Insert Into route (RouteID,RouteDepart,RouteDestination,BusFare,RouteName) Values (@RouteID,@RouteDepart, @RouteDestination, @BusFare,@RouteName )";

                cmdInsert = new SqlCommand(strInsert, conCust);
                cmdInsert.Parameters.AddWithValue("@RouteID",Label2.Text);
                cmdInsert.Parameters.AddWithValue("@RouteDepart", txtDepart.Text);
                cmdInsert.Parameters.AddWithValue("@RouteDestination", txtDest.Text);
                cmdInsert.Parameters.AddWithValue("@BusFare", txtFare.Text);
                cmdInsert.Parameters.AddWithValue("@RouteName", txtDepart.Text + "-" + txtDest.Text);
                conCust.Open();
                cmdInsert.ExecuteNonQuery();
                conCust.Close();
                Response.Redirect("addroute.aspx");
         
            }

       
     
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

    
    }
}