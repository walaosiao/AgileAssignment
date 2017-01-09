using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment
{
    public partial class AddBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BusReference.BusServiceSoapClient client = new BusReference.BusServiceSoapClient();
            int row = client.InsertLatestCustomers(txtID.Text, txtPlatenum.Text,txtModel.Text, ddlbusdriver.SelectedItem.ToString());
            if (row > 0)
            {
                //add new record of the Bus
                Response.Write("<script>alert('Record insert successfuly');</script>");
                txtID.Text = txtPlatenum.Text = txtModel.Text = ddlbusdriver.Text;
            }
            else { Response.Write("<script>alert('Record not insert');</script>"); }
        }
    }
}
