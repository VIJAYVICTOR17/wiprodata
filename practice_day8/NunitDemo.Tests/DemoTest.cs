using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitDemos;

namespace NunitDemo.Tests
{
    [TestFixture]
    public class DemoTest
    {
        [Test]
        public void TestDemo()
        {
            Demo demo = new Demo();
            Assert.AreEqual("Hi, I am Vijay", demo.Hello());
        }
    }
}
