using System;

namespace Design_Patterns_Creational_Factory_04
{
    internal class ProgramUI
    {
        private VehicleFactory _factory = new ConcreteVehicleFactory();
        IVehicle _vehicle;

        internal void Run()
        {
            Console.WriteLine("What type of vehicle do you need?\n\n" +
                "1. Car\n2. Motorcycle\n3. Truck\n\n");
            var userInput = Console.ReadLine();

            _vehicle = _factory.GetVehicle(userInput);
            _vehicle.Start();
            Console.ReadKey();
        }
    }
}