using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class TestCalculate
    {
        public int add(int a, int b)
        {
            int ans = a + b;
            return ans;
        }

        public int mul(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public Boolean ageRange(int age)
        {
            Boolean result = false;
            
            if(age > 21 && age < 50)
            {
                result = true;
            }
            return result;
        }
    }
}
