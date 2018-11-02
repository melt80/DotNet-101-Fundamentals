using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_1
{
    public class Customer
    {
        //public string FirstName { get; set; }
        private string _firstName;

        public Customer()
        {
        }

        public Customer(string name, string lastname)
        {

        }

        public string FirstName
        {
            get => _firstName;
            
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("First name cannot be empty");
                else
                    _firstName = value.Trim();
            }
        }
        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Last name cannot be empty");
                _lastName = value.Trim();
            }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The age is out of range.");
                _age = value;
            }
        }


        //public string LastName { get; set; }
        //public int Age { get; set; }
        public string Question { get; set; }
    }
}
