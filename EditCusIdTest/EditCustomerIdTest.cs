using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // IMPORTANT
using System.Configuration;// IMPORTANT
using System.Data;

namespace EditCusIdTest
{
   public  class EditCustomerIdTest
    {
       // search the local db data
        String connStr = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\TCYEE-PC\\Desktop\\Assignment1\\Assignment1\\Assignment1.Web\\App_Data\\BusTicketing.mdf;Integrated Security=True";
        SqlCommand com;
        string str;
       // using bool to determine the result true or false
        public bool CustomerIdIsDuplicated(string CusID)
        {
            bool result = false;
            // checking in db
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            str = "select * from Customer where CusID='" + CusID + "'";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();

            // if the result is false thenreturn false
            if (reader.Read())
            {
                result = true;
            }
            return result;
        }
    }
}
