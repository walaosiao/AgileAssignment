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
    public partial class EditCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        string connStr = ConfigurationManager.ConnectionStrings["busConn"].ConnectionString;
        SqlCommand com;
        string str;

        protected void btncCheck_Click(object sender, EventArgs e)
        {
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
                lblstatus.Text = reader["CusStatus"].ToString();
                reader.Close();


            }
            else
            {
                txtName.Text = "";
                txtIC.Text = "";
                txtAdd.Text = "";
                txtEmail.Text = "";
                txtCont.Text = "";
                ddl.Text = "";
                lblmsg.Text = "No Record Found!";

            }

            con.Close();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conCust;
            String strUpdate;
            SqlCommand cmdUpdate;

            /*open connection to database*/
            string connStr = ConfigurationManager.ConnectionStrings["busConn"].ConnectionString;
            conCust = new SqlConnection(connStr);

            conCust.Open();

            strUpdate = "Update Customer Set CusName=@CusName,CusIC=@CusIC,CusAddress=@CusAddress,CusEmail=@CusEmail,CusContact=@CusContact,CusStatus=@CusStatus Where CusID=@CusID";

            cmdUpdate = new SqlCommand(strUpdate, conCust);
            cmdUpdate.Parameters.AddWithValue("@CusID", txtID.Text);
            cmdUpdate.Parameters.AddWithValue("@CusIC", txtIC.Text);
            cmdUpdate.Parameters.AddWithValue("@CusName", txtName.Text);
            cmdUpdate.Parameters.AddWithValue("@Cus", txtName.Text);
            cmdUpdate.Parameters.AddWithValue("@CusAddress", txtAdd.Text);
            cmdUpdate.Parameters.AddWithValue("@CusEmail", txtEmail.Text);
            cmdUpdate.Parameters.AddWithValue("@CusContact", txtCont.Text);
            cmdUpdate.Parameters.AddWithValue("@CusStatus", ddl.Text);
            cmdUpdate.ExecuteNonQuery();

            lblmsg.Text = "Customer details is updated";
            txtID.Text = "";
            txtIC.Text = "";
            txtName.Text = "";
            txtAdd.Text = "";
            txtEmail.Text = "";
            txtCont.Text="";
            ddl.Text = "";
            lblstatus.Text= "";
            conCust.Close();
        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtIC.Text = "";
            txtName.Text = "";
            txtAdd.Text = "";
            txtEmail.Text = "";
            txtCont.Text = "";
            lblstatus.Text = "";
            ddl.Text = "";
        }
    }
}