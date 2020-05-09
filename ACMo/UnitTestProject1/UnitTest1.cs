using System;
using ACM.BLi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ACM.BLTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameTestValid()
        {   //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
