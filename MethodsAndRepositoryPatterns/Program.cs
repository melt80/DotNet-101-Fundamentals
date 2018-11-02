﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndRepositoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            var age = GetAge();
            Hello(name);
            Console.WriteLine("you are " + age + "years old");
            Console.ReadKey();
        }

        static void Hello(string name)
        {
            System.Console.WriteLine("Hello " + name);
        }

        static int GetAge()
        {
            System.Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine() );
            return age;
        }
    }
}
