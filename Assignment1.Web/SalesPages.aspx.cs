using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using Assignment1.Web;

namespace Assignment1.Web
{
    public partial class SalesPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        
        protected void Button1_Click(object sender, EventArgs e)
        {

            string strInsert;
            SqlCommand cmdInsert;

            SqlConnection conAdd;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conAdd = new SqlConnection(connStr);


            strInsert = "Insert Into Sales (Categories,Origin,Destination,DepartDate,DepartTime,Passenger ) Values (@Categories,@Origin, @Destination, @DepartDate, @DepartTime, @Passenger )";

            cmdInsert = new SqlCommand(strInsert, conAdd);




            cmdInsert.Parameters.AddWithValue("@Categories", RadioButton1.Text);
            cmdInsert.Parameters.AddWithValue("@Origin", DropDownList4.Text);
            cmdInsert.Parameters.AddWithValue("@Destination", id2.SelectedValue);
            cmdInsert.Parameters.AddWithValue("@DepartDate", DropDownList2.Text);
            cmdInsert.Parameters.AddWithValue("@DepartTime", DropDownList3.Text);
            cmdInsert.Parameters.AddWithValue("@Passenger", DropDownList1.SelectedValue);

            conAdd.Open();
            cmdInsert.ExecuteNonQuery();



            conAdd.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        protected void id2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
          
            
            DropDownList2.Items.Clear();
            
            DataTable ddate = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {

                try
                {
                   
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT departureDate FROM dbo.Schedule WHERE destinationLocation='"+id2.SelectedValue+"'", con);
                   
                   
                    adapter.Fill(ddate);

                    DropDownList2.DataSource = ddate;
                    DropDownList2.DataTextField = "departureDate";
                    DropDownList2.DataValueField = "departureDate";
                    DropDownList2.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error

                }

            }

            // Add the initial item - you can add this even if the options from the
            // db were not successfully loaded
            DropDownList2.Items.Insert(0, new ListItem("<Select Date>", "0"));
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
             
         
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
          
                       
            DropDownList3.Items.Clear();
           

            DataTable dtime = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT departTime FROM dbo.Schedule WHERE departureDate='"+DropDownList2.SelectedValue+"'", con);
                   
                   
                    adapter.Fill(dtime);

                    DropDownList3.DataSource = dtime;
                    DropDownList3.DataTextField = "departTime";
                    DropDownList3.DataValueField = "departTime";
                    DropDownList3.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }

            }

            // Add the initial item - you can add this even if the options from the
            // db were not successfully loaded
            DropDownList3.Items.Insert(0, new ListItem("<Select Time>", "0"));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
         
            id2.Items.Clear();
           

            DataTable dest = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {

                try
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT destinationLocation FROM dbo.Schedule WHERE originLocation='"+DropDownList4.SelectedValue+"'", con);
                   
                   
                    adapter.Fill(dest);

                    id2.DataSource = dest;
                   id2.DataTextField = "destinationLocation";
                    id2.DataValueField = "destinationLocation";
                   id2.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }

            }

            // Add the initial item - you can add this even if the options from the
            // db were not successfully loaded
            id2.Items.Insert(0, new ListItem("<Select Destination>", "0"));
        }

      
        }

        }

     


    
