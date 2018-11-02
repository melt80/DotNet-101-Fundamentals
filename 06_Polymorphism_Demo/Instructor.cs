using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo
{
    class Instructor : Person, ITrainable
    {
        //public override void Greet()
        //{
        //    Console.WriteLine($"Hello my name is Mr. {LastName}");

        //}

        void ITrainable.GetTraining()
        {
            Console.WriteLine("You are getting instructor training.");
        }
    }
}
