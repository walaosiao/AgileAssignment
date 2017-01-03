using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddCusInfoTesting;

namespace AddCustomerInfoTesting2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PhoneNoShouldNotDuplicated()
        {
            // arrange the clas AddCustomerTest
            AddCustomerInfoTesting LTO = new AddCustomerInfoTesting();
            //Expected result
            string phoneNo = "017451123";

            bool result = LTO.PhoneNoIsDuplicated(phoneNo);
            //assert result
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void NameShouldNotDuplicated()
        {

            AddCustomerInfoTesting LTO = new AddCustomerInfoTesting();

            string name = "khor chin siang";

            bool result = LTO.NameIsDuplicated(name);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ICShouldNotDuplicated()
        {
            AddCustomerInfoTesting LTO = new AddCustomerInfoTesting();

            string ICNo = "9311010231";

            bool result = LTO.ICIsDuplicated(ICNo);

            Assert.AreEqual(true, result);
        }
    }
}
