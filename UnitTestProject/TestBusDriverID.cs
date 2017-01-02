using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    class TestBusDriverID
    {
        String connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Chun\\Documents\\GitHub\\AgileAssignment\\Assignment1.Web\\App_Data\\BusTicketing.mdf;Integrated Security = True";
        String str;
        SqlCommand cmd;

        public bool ValidBusDriverID(string busID)
        {
            Boolean result = true;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "SELECT * from Driver WHERE driverID = '" + busID + "'";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                result = false;
            }
            return result;
        }
    }
}
