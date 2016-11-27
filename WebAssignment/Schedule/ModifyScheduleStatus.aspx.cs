using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;


namespace WebAssignment
{
    public partial class ModifyScheduleStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtRetrieve_Click(object sender, EventArgs e)
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;

            SqlConnection conBook;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conBook = new SqlConnection(connStr);

            strSelect = "Select * From Schedule where scheduleID = @scheduleID";


            cmdSelect = new SqlCommand(strSelect, conBook);
            cmdSelect.Parameters.AddWithValue("@scheduleID", txtID.Text);


            conBook.Open();
            dtr = cmdSelect.ExecuteReader();


            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    txtDestination.Text = dtr["destinationLocation"].ToString();
                    txtbusID.Text = dtr["busID"].ToString();
                    txtDate.Text = dtr["departureDate"].ToString();
                    ddlstatus.Text = dtr["status"].ToString();
                }

            }
            conBook.Close();
            dtr.Close();
        }

        protected void txtUpdate_Click(object sender, EventArgs e)
        {
            ScheduleReference.ScheduleSoapClient client = new ScheduleReference.ScheduleSoapClient();
            int row = client.updateRecord(txtID.Text,ddlstatus.SelectedItem.ToString());

             if (row > 0)
            {
                Response.Write("<script>alert('Update successfuly');</script>");
            }
            else { Response.Write("<script>alert('Record not update');</script>"); }
        }

        protected void txtDelete_Click(object sender, EventArgs e)
        {
            ScheduleReference.ScheduleSoapClient client = new ScheduleReference.ScheduleSoapClient();
          

            if (txtID.Text == "")
            {
                Response.Write("<script>alert('Delete failed, no id is inserted');</script>");
            }
            else {
                Response.Write("<script>alert('Delete sucess.');</script>");
                int row = client.deleteRecord(txtID.Text);
            }  
        }


        }


    }