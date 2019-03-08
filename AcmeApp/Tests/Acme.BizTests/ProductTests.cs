using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        
        [TestMethod()]
        
        public void DisplayTest()
        {
            //Create instance of the class for testing
            var currentProduct = new Product();
            currentProduct.ProductName = "Bow";
            currentProduct.ProductId = 1;
            currentProduct.Description = "traditional style wooden bow, not as powerful as a mechanical one - but it is important to honour it's origins";
            var expected = "Bow 1 traditional style wooden bow, not as powerful as a mechanical one - but it is important to honour it's origins"; //Always create a var to store the expected value or result of the test

            //List the actual result
            var actual = currentProduct.Display();

            Assert.AreEqual(expected, actual);
        }
    }
}