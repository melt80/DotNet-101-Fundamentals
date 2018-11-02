using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Inheritance_Demo;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Bear bear = new Bear();

            bear.GetMad();
            bird.GetMad();

            bear.Talk();
            bird.Talk();
        }
    }
}
