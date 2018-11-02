using System;
using _04_Encapsulation_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Encapsulation_1_Tests
{
    [TestClass]
    public class CustomerTests
    {
        private CustomerQueueRepository customerQueue;
        private Customer customer1;
        private Customer customer2;
        [TestInitialize]
        //-- TestInit (Arrange)
        public void Arrange()
        {
            customerQueue = new CustomerQueueRepository();
            customer1 = new Customer
            {
                FirstName = "Paul",
                LastName = "McCartney",
                Age = 74,
                Question = "I want a new motorcycle." 
            };

            customer2 = new Customer
            {
                FirstName= "Clark",
                LastName = "Kent",
                Question = "I hate all."
            };

            customerQueue.AddCustomerToQueue(customer1);
            customerQueue.AddCustomerToQueue(customer2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The age is out of rangee.")]
        public void Customer_AgeIsNegative_ShouldThrowException()
        {
            Customer customer = new Customer();
            customer.FirstName = "Kenn";
            customer.LastName = "Pascasio";
            customer.Age = -5;
        }

        //TODO test other exceptions
        [TestMethod]
        public void Customer_ServeCustomer_ShouldReturnNextCustomer()
        {
            var _expected = customer1;
            var _actual = customerQueue.ServeCustomer();
            Assert.AreEqual(_expected, _actual);


        }

        public void Customer_PeakAhead_ShouldReturnNextCustomer()
        {
            var _expected = customer1;


        }
    }
}
