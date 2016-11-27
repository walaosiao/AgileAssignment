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


namespace WebAssignment.BusForm
{
    /// <summary>
    /// Summary description for BusService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BusService : System.Web.Services.WebService
    {

        [WebMethod(Description = "Insert driver from Bus table")]
        public int InsertLatestCustomers(string busID, string busPlateNum, string busModel, string busDriver)
        {
            using (SqlConnection connection = new SqlConnection
            (ConfigurationManager.ConnectionStrings["BusTicketingConnectionString"].ConnectionString))
            {
                string Query = "INSERT INTO [Bus] VALUES ('" + busID + "','" + busPlateNum + "','" + busModel + "','" + busDriver + "')";
                SqlCommand command = new SqlCommand(Query, connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                int row = command.ExecuteNonQuery();

                return row;
            }
        }
    }
}
