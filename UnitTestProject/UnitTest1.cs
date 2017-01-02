using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    TestCalculate test1 = new TestCalculate();
        //    int result = test1.add(3, 5);
        //    Assert.AreEqual(8, result);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    TestCalculate test2 = new TestCalculate();
        //    int result = test2.mul(3, 5);
        //    Assert.AreEqual(15, result);
        //}

        [TestMethod]
        public void NullOrNot()
        {
            TestIsNull testingValue = new TestIsNull();
            Boolean msg = testingValue.isNull(""); //txtIC.text
            Assert.AreEqual(true, msg);
        }

        [TestMethod]
        public void ValidAge()
        {
            TestCalculate tc = new TestCalculate();
            Boolean validnot = tc.ageRange(45);
            Assert.AreEqual(true, validnot);
        }
    }
}
