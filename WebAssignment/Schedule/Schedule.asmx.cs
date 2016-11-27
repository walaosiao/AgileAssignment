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
namespace WebAssignment.Schedule
{
    /// <summary>
    /// Summary description for Schedule
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Schedule : System.Web.Services.WebService
    {

        [WebMethod]
        public int updateRecord(string scheduleid, string status)
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "UPDATE Schedule SET status='" + status + "' where scheduleID='" + scheduleid + "'";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                int row = command.ExecuteNonQuery();
                return row;
            }
        }

        [WebMethod(Description = "Get Schedule from Schedule table")]
        public DataSet GetLatestCustomers(string scheduleid)
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "SELECT * FROM [Schedule] where scheduleID='" + scheduleid + "'";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                DataTable myTable = new DataTable("myTable");
                myTable.Columns.Add("Destination", typeof(string));
                myTable.Columns.Add("Depart Date", typeof(string));
                myTable.Columns.Add("Depart Time", typeof(string));
                myTable.Columns.Add("Bus ID", typeof(string));
                myTable.Columns.Add("Driver ID", typeof(string));
                myTable.Columns.Add("Status ", typeof(string));
                myTable.Columns.Add("From Location ", typeof(string));


                while (reader.Read())
                {
                    myTable.Rows.Add(new object[]
                 {
                      reader["destinationLocation"].ToString(), 
                      reader["departureDate"].ToString(), reader["departTime"], reader
                      ["busID"], reader["driverID"], reader["status"],reader["originLocation"] });
                }
                //myTable.Load(reader);
                myTable.AcceptChanges();
                DataSet ds = new DataSet();
                ds.Tables.Add(myTable);
                ds.AcceptChanges();
                return ds;


            }
        }


        [WebMethod(Description = "Insert schedule into schedule table")]
        public int InsertLatestSchedule(string scheduleID, string destination, string departDate, string departTime, string busID, string driverID, string status, string originLocation)
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "INSERT INTO [Schedule] VALUES ('" + scheduleID + "','" + destination + "','" + departDate + "','" + departTime + "','" + busID + "','" + driverID + "','" + status + "','" + originLocation + "')";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                int row = command.ExecuteNonQuery();
                return row;
            }
        }

        [WebMethod]
        public int deleteRecord(string scheduleid)
        {
            using (SqlConnection connection = new SqlConnection
           (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "DELETE Schedule WHERE scheduleID ='" + scheduleid + "'";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                int row = command.ExecuteNonQuery();
                return row;

            }
        }
    }
}
