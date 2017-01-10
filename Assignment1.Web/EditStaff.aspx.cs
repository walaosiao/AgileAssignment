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
    public partial class EditStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
        SqlCommand com;
        string str;

        protected void btncCheck_Click(object sender, EventArgs e)
        {
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
                lblstatus.Text = reader["StaffStatus"].ToString();
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
                ddl.Text = "";
                lblmsg.Text = "No Record Found!";

            }

            con.Close();
        }


        /* insert user input into database */
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            String strUpdate;
            SqlCommand cmdUpdate;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strUpdate = "Update staff Set StaffName=@StaffName,StaffIC=@STaffIC,StaffAddress=@StaffAddress,StaffPosition=@StaffPosition,StaffSalary=@StaffSalary,StaffContact=@StaffContact, Password=@Password,StaffStatus=@StaffStatus Where StaffID=@StaffID";

            cmdUpdate = new SqlCommand(strUpdate, conCust);
            cmdUpdate.Parameters.AddWithValue("@StaffID", txtID.Text);
            cmdUpdate.Parameters.AddWithValue("@StaffName", txtName.Text);
            cmdUpdate.Parameters.AddWithValue("@StaffIC", txtIC.Text);
            cmdUpdate.Parameters.AddWithValue("@StaffAddress", txtAdd.Text);
            cmdUpdate.Parameters.AddWithValue("@StaffPosition", txtPost.Text);
            cmdUpdate.Parameters.AddWithValue("@StaffSalary", txtSalary.Text);
            cmdUpdate.Parameters.AddWithValue("@StaffContact", txtCont.Text);
            cmdUpdate.Parameters.AddWithValue("@Password", txtCpass.Text);
            cmdUpdate.Parameters.AddWithValue("@StaffStatus", ddl.Text);
            cmdUpdate.ExecuteNonQuery();

            lblmsg.Text = "Staff details is updated";
            txtID.Text = "";
            txtName.Text = "";
            txtIC.Text = "";
            txtAdd.Text = "";
            txtPost.Text = "";
            txtSalary.Text = "";
            txtCont.Text = "";
            txtCpass.Text = "";
            ddl.Text = "";
            lblstatus.Text = "";
            conCust.Close();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtIC.Text = "";
            txtAdd.Text = "";
            txtPost.Text = "";
            txtSalary.Text = "";
            txtCont.Text = "";
            txtCpass.Text = "";
            lblstatus.Text = "";
            ddl.Text = "";
        }

    
    }
}
