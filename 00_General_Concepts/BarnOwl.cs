using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    class BarnOwl : IBird
    {
        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Console.WriteLine("ssssssssssssssssss");
        }
    

        public void FlapWings()
        {
        Console.WriteLine("No sound.");
        }


        public void MakeSound()
        {
            Console.WriteLine("ssssssssssssssssss");
        }

        public void Move()
        {
        Console.WriteLine("The thing is creepy!");
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
