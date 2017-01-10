using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
namespace WebAssignment
{
    public partial class AddSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            string busstatus = "On Going";
           
            //allow user add the new schedule

            ScheduleReference.ScheduleSoapClient client = new ScheduleReference.ScheduleSoapClient();
            int row = client.InsertLatestSchedule(txtID.Text, ddlFrom.SelectedItem.ToString(), ddlDestination.SelectedItem.ToString(), txtDate.Text, ddlTime.SelectedItem.ToString(), ddlBusID.SelectedItem.ToString(), ddlDriverID.SelectedItem.ToString(), busstatus);
           if (row > 0)
            {
                Response.Write("<script>alert('Record insert successfuly');</script>");
                txtID.Text = ddlDestination.Text = txtDate.Text = ddlTime.Text = "";
            }
            else { Response.Write("<script>alert('Record not insert');</script>"); }
        }

        protected void DepartDateCalender_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = DepartDateCalender.SelectedDate.ToString("dd/MM/yyyy"); 
        }

        protected void ddlBusID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
