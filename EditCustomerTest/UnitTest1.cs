using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EditCusIdTest;

namespace EditCustomerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
             public void CusIdNoShouldNotDuplicated()
        {
            // arrange
            EditCustomerIdTest CT = new EditCustomerIdTest();
            // expected result
            string CusID = "C1002";

            bool result = CT.CustomerIdIsDuplicated(CusID);
            //assert result
            Assert.AreEqual(true, result);
        }
       }
   }

