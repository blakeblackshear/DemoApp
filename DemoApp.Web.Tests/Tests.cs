using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoApp.Web.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int b = 2;
            int result = a + b;
            Assert.AreEqual(5, result);
        }
    }
}
