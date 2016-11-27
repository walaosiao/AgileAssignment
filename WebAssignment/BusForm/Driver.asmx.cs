using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace WebAssignment.Bus
{
    /// <summary>
    /// Summary description for Driver
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Driver : System.Web.Services.WebService
    {

        [WebMethod(Description = "Get all driver from driver table")]
        public DataSet GetLatestCustomers()
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "SELECT * FROM [Driver] ORDER BY [driverID] DESC";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                DataTable myTable = new DataTable("myTable");
                myTable.Columns.Add("driverID", typeof(string));
                myTable.Columns.Add("driverName", typeof(string));
                myTable.Columns.Add("driverAge", typeof(string));
                myTable.Columns.Add("driverGender", typeof(string));
                myTable.Columns.Add("driverRace", typeof(string));
                myTable.Columns.Add("driverLicence", typeof(string));
                myTable.Columns.Add("driverAddress", typeof(string));

                while (reader.Read())
                {
                    myTable.Rows.Add(new object[]
                 {
                      reader["driverID"].ToString(), reader["driverName"].ToString(), 
                      reader["driverAge"].ToString(), reader["driverGender"], reader
                      ["driverRace"], reader["driverLicence"], reader["driverAddress"] });
                }
                //myTable.Load(reader);
                myTable.AcceptChanges();
                DataSet ds = new DataSet();
                ds.Tables.Add(myTable);
                ds.AcceptChanges();
                return ds;
            }
        }

        [WebMethod(Description = "Insert driver from driver table")]
        public int InsertLatestCustomers(string driverID, string driverName, string driverAge, string driverGender, string driverRace, string driverLicence, string driverAddress)
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "INSERT INTO Driver VALUES ('" + driverID + "','" + driverName + "','" + driverAge + "','" + driverGender + "','" + driverRace + "','" + driverLicence + "','" + driverAddress + "')";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                int row = command.ExecuteNonQuery();

                return row;
            }
        }
    }
}
