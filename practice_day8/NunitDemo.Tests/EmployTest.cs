using NUnit.Framework;
using NunitDemos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemo.Tests
{
    [TestFixture]
    internal class EmployTest
    {
        [Test]
        public void TestGettersAndSetters()
        {
            Employ employ = new Employ();
            employ.Id = 1;
            employ.Name = "vijaykumar";
            employ.Salary = 25000;

            Assert.AreEqual(1, employ.Id);
            Assert.AreEqual("vijaykumar", employ.Name);
            Assert.AreEqual(25000, employ.Salary);
        }
        [Test]
        public void TestSearchEmploy()
        {
            EmployDao employDao = new EmployDao();
            Employ employFound = employDao.SearchEmploy(1);
            Assert.IsNotNull(employFound);
            employFound = employDao.SearchEmploy(-1);
            Assert.Null(employFound);
        }

    }
}
