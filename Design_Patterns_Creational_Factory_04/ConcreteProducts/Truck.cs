using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_04.ConcreteProducts
{
    class Truck : IVehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DoorNumber DoorNumber { get; set; }
        public bool HasGas { get; set; }

        public void Brake()
        {
            Console.WriteLine("The truck is braking.");
        }

        public void FuelStatus()
        {
            if (HasGas)
                Console.WriteLine("There's gas in the truck.");
            else
                Console.WriteLine("The hog's runnin' dry.");
        }

        public void Move()
        {
            Console.WriteLine("Move em out.");
        }

        public void Start()
        {
            Console.WriteLine("10-4 good buddy.");
        }
    }
}
