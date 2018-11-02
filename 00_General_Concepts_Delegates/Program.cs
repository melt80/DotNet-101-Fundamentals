using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Delegates
{
    class Program
    {
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            Func<string, string, string> myMethod = GetName;
            myMethod("Neil", "Tiedeman");
        }

        private static void DoSomeStuff(Del myMethod)
        {
            Console.WriteLine("Do some stuff.");
        }

        public static string GetName(string first, string last)
        {
            return first + " " + last;
        } 
    }
}
