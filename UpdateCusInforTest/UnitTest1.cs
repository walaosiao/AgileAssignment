using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpdateCusInfoTest;

namespace UpdateCusInforTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CusIdNoShouldNotDuplicated()
        {
            // arrange
            UpdateCusInforTest CT = new UpdateCusInforTest();
            // expected result
            string CusID = "C1002";

            bool result = CT.CustomerIdIsDuplicated(CusID);
            //assert result
            Assert.AreEqual(true, result);
        }
    }
}
