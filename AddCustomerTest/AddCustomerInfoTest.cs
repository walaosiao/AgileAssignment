using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT
using System.Data;

namespace AddCustomerTest
{
    public class AddCustomerInfoTest
    {
        //retrieve data from db
        String connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\TCYEE-PC\\Desktop\\Assignment1\\Assignment1\\Assignment1.Web\\App_Data\\BusTicketing.mdf;Integrated Security=True";
        SqlCommand com;
        string str;
        //using bool check the result true/false
        public bool PhoneNoIsDuplicated(string PhoneNo)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from Customer where CusContact='" + PhoneNo + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            // system using if to determine data got duplicated or not
            if (reader.Read())
            {
                result = true;
            }
            return result;
        }

        public bool NameIsDuplicated(string Name)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from Customer where CusName='" + Name + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                result = true;
            }
            return result;
        }

        public bool ICIsDuplicated(string ICNo)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from Customer where CusIC='" + ICNo + "'";
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
