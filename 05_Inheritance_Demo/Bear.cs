using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Demo
{
    public class Bear : Animal
    {
        public override void GetMad()
        {
            Console.WriteLine("Roar!");
        }

        public override void StateType()
        {
            throw new NotImplementedException();
        }


    }
}
