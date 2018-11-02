using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Demo
{
    public abstract class Animal
    {
        private string _latinName;
        public int HasLegs{ get; set; }
        public int? Legs { get; set; }

        public string Name { get; set; }

        public string LatinName
        {
            get { return _latinName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name can't be empty");
                _latinName = value;
            }
        }

        public abstract void StateType();
        public abstract void GetMad();

        public virtual void Talk()
        {
            Console.WriteLine("I'm an animal.");
        }

    }
}
