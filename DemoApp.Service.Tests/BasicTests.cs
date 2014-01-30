using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DemoApp.Service.Tests
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void A_equal_B()
        {
            int a = 1;
            int b = 1;
            Assert.AreEqual(a, b);
        }
        
        [Test]
        public void Broken_Test()
        {
            int a = 1;
            int b = 2;
            Assert.AreEqual(a, b);
        }        
    }
}
