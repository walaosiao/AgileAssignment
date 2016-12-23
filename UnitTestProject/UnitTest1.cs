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
            test1.add(3, 5);
            Assert.AreEqual(test1,8);
        }
    }
}
