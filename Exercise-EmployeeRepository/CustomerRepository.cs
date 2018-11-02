using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_EmployeeRepository
{
    class CustomerRepository
    {
        private List<Customer> _customerRepository = new List<Customer>();

        public void AddCustomerToList(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public List<Customer> GetList()
        {
            return _customerRepository;
        }

        public string Message(Customer customer)
        {
            var message = "";

            if (customer.YearsWithKomodo < 1)
                message = "New Customer Added.";
            else if (customer.YearsWithKomodo >= 1)
                message = "You entered a legacy customer.";
            return message;
        }
    }
}
