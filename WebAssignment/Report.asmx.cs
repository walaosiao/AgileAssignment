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

namespace WebAssignment
{
    /// <summary>
    /// Summary description for Report1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Report1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Get Schedule from Schedule table")]
        public DataSet GetLatestCustomers(string destinationLocation)
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "SELECT * FROM [Schedule] where destinationLocation='" + destinationLocation + "'";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                DataTable myTable = new DataTable("myTable");
                myTable.Columns.Add("Destination", typeof(string));
                myTable.Columns.Add("From Location ", typeof(string));
                myTable.Columns.Add("Depart Date", typeof(string));
                myTable.Columns.Add("Depart Time", typeof(string));
                myTable.Columns.Add("Bus ID", typeof(string));
                myTable.Columns.Add("Driver ID", typeof(string));
                myTable.Columns.Add("Status ", typeof(string));



                while (reader.Read())
                {
                    myTable.Rows.Add(new object[]
                 {
                      reader["destinationLocation"].ToString(),reader["originLocation"],
                      reader["departureDate"].ToString(), reader["departTime"], reader
                      ["busID"], reader["driverID"], reader["status"] });
                }
                //myTable.Load(reader);
                myTable.AcceptChanges();
                DataSet ds = new DataSet();
                ds.Tables.Add(myTable);
                ds.AcceptChanges();
                return ds;


            }
        }

        [WebMethod(Description = "Get Schedule from Schedule table")]
        public DataSet GetLatestDriver(string driverID)
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "SELECT Driver.driverName, Schedule.scheduleID, Schedule.destinationLocation, Schedule.originLocation, Schedule.departureDate, Schedule.departTime FROM Driver INNER JOIN Schedule ON Driver.driverID = Schedule.driverID AND Schedule.driverID ='" + driverID + "'";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                DataTable myTable = new DataTable("myTable");
                myTable.Columns.Add("DRIVER NAME", typeof(string));
                myTable.Columns.Add("SCHEDULE ID", typeof(string));
                myTable.Columns.Add("DESTINATION Location ", typeof(string));
                myTable.Columns.Add("ORIGINAL LOCATION ", typeof(string));
                myTable.Columns.Add("Depart Date", typeof(string));
                myTable.Columns.Add("Depart Time", typeof(string));


                while (reader.Read())
                {
                    myTable.Rows.Add(new object[]
                 {
                        reader["driverName"],reader["scheduleID"],reader["destinationLocation"].ToString(),reader["originLocation"],
                      reader["departureDate"].ToString(), reader["departTime"]});
                }
                //myTable.Load(reader);
                myTable.AcceptChanges();
                DataSet ds = new DataSet();
                ds.Tables.Add(myTable);
                ds.AcceptChanges();
                return ds;


            }
        }
    }
}
