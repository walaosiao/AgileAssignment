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
    public partial class Add : System.Web.UI.Page
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
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr); strSelect = "Select CusID From dbo.Customer";
            cmdSelect = new SqlCommand(strSelect, conCust);
            conCust.Open();
            dtr = cmdSelect.ExecuteReader();
            string lastValue = "";
            while (dtr.Read()) lastValue = dtr["CusID"].ToString(); if (lastValue == "")
            {
                return "C1000";
            }
            else
            {
                double genID = double.Parse(lastValue.Replace("C", "")); genID = genID + 1; return ("C" + genID.ToString());
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string strInsert;
            SqlCommand cmdInsert;

            SqlConnection conCust;
            string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
            conCust = new SqlConnection(connStr);


            strInsert = "Insert Into Customer (CusID,CusName,CusIC,CusAddress,CusEmail,CusContact,CusStatus) Values (@CusID, @CusName, @CusIC,@CusAddress,@CusEmail,@CusContact,@CusStatus)";

            cmdInsert = new SqlCommand(strInsert, conCust);
            cmdInsert.Parameters.AddWithValue("@CusID", lblID.Text);
            cmdInsert.Parameters.AddWithValue("@CusName", txtName.Text);
            cmdInsert.Parameters.AddWithValue("@CusIC", txtIC.Text);
            cmdInsert.Parameters.AddWithValue("@CusAddress", txtAdd.Text);
            cmdInsert.Parameters.AddWithValue("@CusEmail", txtEmail.Text);
            cmdInsert.Parameters.AddWithValue("@CusContact", txtCont.Text);
            cmdInsert.Parameters.AddWithValue("@CusStatus", ddl.Text);

            conCust.Open();
            cmdInsert.ExecuteNonQuery();

            lblmsg.Text = "New customer added!";

            conCust.Close();
            Response.Redirect("AddCustomer.aspx");
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}