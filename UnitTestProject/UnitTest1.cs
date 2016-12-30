using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestCalculate test1 = new TestCalculate();
            int result = test1.add(3, 5);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TestCalculate test2 = new TestCalculate();
            int result = test2.mul(3, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void NullOrNot()
        {
            
            Class1 testingValue = new Class1();
            Boolean msg = testingValue.isNull(""); //txtIC.text
            Assert.AreEqual(true, msg);
        }
    }
}
