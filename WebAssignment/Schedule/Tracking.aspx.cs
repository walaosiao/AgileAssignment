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
    public partial class Tracking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {

            ScheduleReference.ScheduleSoapClient client = new ScheduleReference.ScheduleSoapClient();

          

            if (txtTrackID.Text == "")
            {
                Response.Write("<script>alert('No ID is inserted , Please try again.');</script>");
                txtTrackID.Focus();
            }

            else {
                GridView1.DataSource = client.GetLatestCustomers(txtTrackID.Text);
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}