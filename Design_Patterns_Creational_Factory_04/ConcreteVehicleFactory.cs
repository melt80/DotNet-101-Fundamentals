using Design_Patterns_Creational_Factory_04.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_04
{
    class ConcreteVehicleFactory : VehicleFactory

    {
        public override IVehicle GetVehicle(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    return new Car();
                case "2":
                    return new Motorcycle();
                case "3":
                    return new Truck();

                default:
                    throw new ApplicationException("No valid input received.");
            }
        }
    }
}
