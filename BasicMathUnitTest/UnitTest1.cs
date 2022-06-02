using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestDemo;
namespace BasicMathUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }


        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMath bm = new BasicMath();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
