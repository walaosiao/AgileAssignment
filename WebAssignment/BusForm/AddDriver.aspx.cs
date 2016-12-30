using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WebAssignment
{
    public partial class AddDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* string strInsert;
             SqlCommand cmdInsert;

             SqlConnection conBook;
             string connStr = ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString;
             conBook = new SqlConnection(connStr);


             strInsert = "Insert Into Driver(driverID,driverName,driverAge,driverGender,driverRace,driverLicence,driverAddress) Values (@driverID, @driverName, @driverAge,@driverGender,@driverRace,@driverLicence,@driverAddress)";

             cmdInsert = new SqlCommand(strInsert, conBook);

             cmdInsert.Parameters.AddWithValue("@driverID", txtID.Text);
             cmdInsert.Parameters.AddWithValue("@driverName", txtName.Text );
             cmdInsert.Parameters.AddWithValue("@driverAge", txtAge.Text);
             cmdInsert.Parameters.AddWithValue("@driverGender", rbGender.SelectedItem.ToString());
             cmdInsert.Parameters.AddWithValue("@driverRace", ddlRace.SelectedItem.ToString());
             cmdInsert.Parameters.AddWithValue("@driverLicence", txtLicence.Text );
             cmdInsert.Parameters.AddWithValue("@driverAddress", txtAddress.Text);


             conBook.Open();
             cmdInsert.ExecuteNonQuery();

             lblAdd.Text = "New customer added!";

             conBook.Close();*/
            
            //allow user add the new record
            DriverFunction.DriverSoapClient client = new DriverFunction.DriverSoapClient();
              int row = client.InsertLatestCustomers(txtID.Text, txtName.Text, txtAge.Text, rbGender.SelectedItem.ToString(), ddlRace.SelectedItem.ToString(), txtLicence.Text, txtAddress.Text);
              if (row > 0)
              {
                  Response.Write("<script>alert('Record insert successfuly');</script>");
                  txtID.Text = txtName.Text = txtAge.Text = rbGender.Text = ddlRace.Text = txtLicence.Text = txtAddress.Text;
              }
              else
              {
                  Response.Write("<script>alert('Record not insert');</script>");
              }
        }


        //allow user clear the data
        protected void Button2_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAge.Text = "";
            txtID.Text = "";
            txtLicence.Text = "";
            txtName.Text = "";
            rbGender.SelectedItem.Selected = false;
            ddlRace.SelectedIndex = 0;

        }
    }
}
