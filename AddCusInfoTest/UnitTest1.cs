using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddCustomerTest;

namespace AddCusInfoTest
{
    [TestClass]
    public class UnitTest1
    {
 
            [TestMethod]
        public void PhoneNoShouldNotDuplicated()
        {
                // arrange the clas AddCustomerTest
            AddCustomerInfoTest LTO = new AddCustomerInfoTest();
                //Expected result
            string phoneNo = "017523131";

            bool result = LTO.PhoneNoIsDuplicated(phoneNo);
                //assert result
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void NameShouldNotDuplicated()
        {
            try
            {
                AddCustomerInfoTest LTO = new AddCustomerInfoTest();

                string name = "khor rich siang";

                bool result = LTO.NameIsDuplicated(name);

                Assert.AreEqual(true, result);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }

        [TestMethod]
        public void ICShouldNotDuplicated()
        {
            try
            {
                AddCustomerInfoTest LTO = new AddCustomerInfoTest();

                string ICNo = "931101075665";

                bool result = LTO.ICIsDuplicated(ICNo);

                Assert.AreEqual(true, result);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }

        }
    }

