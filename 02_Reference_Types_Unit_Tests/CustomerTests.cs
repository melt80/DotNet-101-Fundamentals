using System;
using _02_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Unit_Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Customer_SetFirstNameAsString()
        {
            //-- Arrange
            Customer customer = new Customer();

            //-- Act
            customer.FirstName = "Shivjeet";
            var expected = "Shivjeet";
            var actual = customer.FirstName;
            Console.WriteLine($"Actual:{actual}");
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Customer_LastNameIsProperString()
        {
            //-- Arrange
            Customer customer = new Customer();

            //-- Act
            customer.LastName = "Jauhal";
            var expected = "Jauhal";
            var actual = customer.LastName;
            Console.WriteLine($"Actual:{actual}");
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
