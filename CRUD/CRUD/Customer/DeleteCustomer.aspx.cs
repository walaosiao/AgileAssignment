using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT

namespace CRUD.Customer
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            string strDelete;
            SqlCommand cmdDelete;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["busConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strDelete = "Delete Customer where CusID=@CusID";
            cmdDelete = new SqlCommand(strDelete, conCust);

            cmdDelete.Parameters.AddWithValue("@CusID", (txtID.Text));

            int intNoofDelete = cmdDelete.ExecuteNonQuery();

            conCust.Close();

            if (intNoofDelete != 0)
            {
                lblmsg.Text = "Record for this Customer is deleted";

            }
            else
                lblmsg.Text = "No record for this Customer";
                txtID.Text = "";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
    }
}