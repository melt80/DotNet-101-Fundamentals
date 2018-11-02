using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_1
{ 
    public class CustomerQueueRepository
    {
        private Queue<Customer> _customerQueue = new Queue<Customer>();

        public void AddCustomerToQueue(Customer customer)
        {
            _customerQueue.Enqueue(customer);
        }

        public Customer ServeCustomer()
        {
            var customer = _customerQueue.Dequeue();
            return customer;
        }

        public Customer PeekAhead()
        {
            if (_customerQueue.Count == 0)
                return null;
            return _customerQueue.Peek();
        }

    }
}
