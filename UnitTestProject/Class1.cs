using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    class Class1
    {
        public Boolean isNull(object value)
        {
            Boolean message = false;

            if(value == null || value.Equals(""))
            {
                message = true;
            }
            return message;
        }
    }
}
