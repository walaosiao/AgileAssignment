using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationTesting
{
    public class AddReservationInfoTest
    {
        //retrieve data from db
        String connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\TCYEE-PC\\Desktop\\Assignment1\\Assignment1\\Assignment1.Web\\App_Data\\BusTicketing.mdf;Integrated Security=True";
        SqlCommand com;
        string str;

        public bool ReservationIDIsDuplicated(string ReservationID)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from Reservation where ReservationID='" + ReservationID + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                result = true;
            }
            return result;
        }
    }
    class Reservation
    {

    }
}
