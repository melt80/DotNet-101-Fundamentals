using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependancy_Injection
{
    class UglyConsole : IConsole
    {
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.Write("This is the Ugly Console\n");
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            Console.Write("This is the Ugly Console\n");
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

    }
}
