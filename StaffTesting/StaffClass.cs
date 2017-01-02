using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTesting
{
    public class AddStaffInfoTest
    {
        //retrieve data from db
        String connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\TCYEE-PC\\Desktop\\Assignment1\\Assignment1\\Assignment1.Web\\App_Data\\BusTicketing.mdf;Integrated Security=True";
        SqlCommand com;
        string str;

        public bool StaffContactIsDuplicated(string StaffContactNo)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from staff where StaffContact='" + StaffContactNo + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                result = true;
            }
            return result;
        }


        public bool ICIsDuplicated(string StaffICNo)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from staff where StaffIC='" + StaffICNo + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                result = true;
            }
            return result;
        }
    }
}
