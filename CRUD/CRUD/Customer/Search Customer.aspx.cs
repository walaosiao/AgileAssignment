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
    public partial class EditBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["busConn"].ConnectionString;
            SqlCommand com;
            string str;

            /*open connection to database*/
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from Customer where CusID='" + txtID.Text.Trim() + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["CusName"].ToString();
                txtIC.Text = reader["CusIC"].ToString();
                txtAdd.Text = reader["CusAddress"].ToString();
                txtEmail.Text = reader["CusEmail"].ToString();
                txtCont.Text = reader["CusContact"].ToString();
                txtStatus.Text = reader["CusStatus"].ToString();
                reader.Close();


            }
            else
            {
                txtName.Text = "";
                txtIC.Text = "";
                txtAdd.Text = "";
                txtEmail.Text = "";
                txtCont.Text = "";
                txtStatus.Text = "";
                lblmsg.Text = "No Record Found!";

            }
            con.Close();
        }

        protected void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtIC.Text = "";
            txtAdd.Text = "";
            txtEmail.Text = "";
            txtCont.Text = "";
            txtStatus.Text = "";
        }
    }
}