using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo
{
    public abstract class Person
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }

        public virtual void Greet(string mood)
        {
            Console.WriteLine($"I am {FirstName}. I am {mood}.");
        }

        public void Greet()
        {
            Console.WriteLine($"I am {FirstName}.");
        }
    }
}
