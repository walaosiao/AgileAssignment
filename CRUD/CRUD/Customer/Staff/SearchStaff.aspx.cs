using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT


namespace CRUD.Customer.Staff
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearc_Click(object sender, EventArgs e)
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
            str = "select * from staff where StaffID='" + txtID.Text.Trim() + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["StaffName"].ToString();
                txtIC.Text = reader["StaffIC"].ToString();
                txtAdd.Text = reader["StaffAddress"].ToString();
                txtPost.Text = reader["StaffPosition"].ToString();
                txtSalary.Text = reader["StaffSalary"].ToString();
                txtCont.Text = reader["StaffContact"].ToString();
                txtCpass.Text = reader["Password"].ToString();
                txtStatus.Text = reader["StaffStatus"].ToString();
                reader.Close();


            }
            else
            {
                txtID.Text = "";
                txtName.Text = "";
                txtIC.Text = "";
                txtAdd.Text = "";
                txtPost.Text = "";
                txtSalary.Text = "";
                txtCont.Text = "";
                txtCpass.Text = "";
                txtStatus.Text = "";
                lblmsg.Text = "No Record Found!";

            }
            con.Close();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click1(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtIC.Text = "";
            txtAdd.Text = "";
            txtPost.Text = "";
            txtSalary.Text = "";
            txtCont.Text = "";
            txtCpass.Text = "";
            txtStatus.Text = "";
        }

        protected void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

   
    }
}