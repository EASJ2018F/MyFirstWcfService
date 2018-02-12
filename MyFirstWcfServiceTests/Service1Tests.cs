using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWcfService.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetMyEmailTest()
        {
            //arrange
            var service1 = new Service1();

            //act
            string email = service1.GetMyEmail();

            //assert
            Assert.AreEqual("mark@easj.dk", email);

            //Assert.Fail();
        }

        [TestMethod()]
        public void GetMyNameTest()
        {
            Assert.Fail();
        }
    }
}