using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo
{
    class Student : Person, ITrainable
    {
        public char CurrentGrade { get; set; }

        void ITrainable.GetTraining()
        {
            Console.WriteLine("You are getting student training.");
        }
    }
}
