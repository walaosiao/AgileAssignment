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
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblID.Text = generateID();
        }

        private String generateID()
        {
            string strSelect;
            SqlCommand cmdSelect;
            SqlDataReader dtr;
            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["busConn"].ConnectionString;
            conCust = new SqlConnection(connStr); strSelect = "Select StaffID From dbo.staff";
            cmdSelect = new SqlCommand(strSelect, conCust);
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();
            string lastValue = "";
            while (dtr.Read()) lastValue = dtr["StaffID"].ToString(); if (lastValue == "")
            {
                return "S1000";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("S", "")); genID = genID + 1; return ("S" + genID.ToString());
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string strInsert;
            SqlCommand cmdInsert;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["busConn"].ConnectionString;
            conCust = new SqlConnection(connStr);


            strInsert = "Insert Into staff (StaffID,StaffName,StaffIC,StaffAddress,StaffPosition,StaffSalary,StaffContact,Password,StaffStatus) Values (@StaffID,@StaffName,@StaffIC,@StaffAddress,@StaffPosition,@StaffSalary,@StaffContact,@Password,@StaffStatus)";

            cmdInsert = new SqlCommand(strInsert, conCust);
            cmdInsert.Parameters.AddWithValue("@StaffID", lblID.Text);
            cmdInsert.Parameters.AddWithValue("@StaffName", txtName.Text);
            cmdInsert.Parameters.AddWithValue("@StaffIC", txtIC.Text);
            cmdInsert.Parameters.AddWithValue("@StaffAddress", txtAdd.Text);
            cmdInsert.Parameters.AddWithValue("@StaffPosition", txtPost.Text);
            cmdInsert.Parameters.AddWithValue("@StaffSalary", txtSalary.Text);
            cmdInsert.Parameters.AddWithValue("@StaffContact", txtCont.Text);
            cmdInsert.Parameters.AddWithValue("@Password", txtCpass.Text);
            cmdInsert.Parameters.AddWithValue("@StaffStatus", ddl.Text);
            conCust.Open();
            cmdInsert.ExecuteNonQuery();

            lblmsg.Text = "New Staff added!";

            conCust.Close();
            Response.Redirect("AddStaff.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            
            txtName.Text = "";
            txtIC.Text = "";
            txtAdd.Text = "";
            txtPost.Text = "";
            txtSalary.Text = "";
            txtCont.Text = "";
            txtCpass.Text = "";
            ddl.Text = "";
           
        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}