using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Business_Problem
{
    class Program
    {

        public enum VehicleType
        {
            Car = 1, Motorcycle = 2, Boat = 3, Plane = 4
        }
        static void Main(string[] args)
        {
        
            System.Console.WriteLine("Welcome to Komodo! What is your name?");
            string name = Console.ReadLine();

            System.Console.WriteLine($"Welcome, {name}, what is your age?");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            System.Console.WriteLine("What type of vehicle would you like to insure?");
            string vehicleChoice = Console.ReadLine();
            int choice = int.Parse(vehicleChoice);
            VehicleType vehicleType = (VehicleType) choice;
            decimal insuranceCost = 0m;
            switch (vehicleType)
            {
                case VehicleType.Car:
                {
                    if (age > 18 && age <= 27)
                        insuranceCost = 150.00m;
                    else if (age > 27 && age <= 65)
                        insuranceCost = 50.00m;
                    else if (age > 65)
                        insuranceCost = 100.00m;
                    break;
                }

                case VehicleType.Motorcycle:
                {
                    if (age > 18 && age <= 27)
                        insuranceCost = 200.00m;
                    else if (age > 27 && age <= 65)
                        insuranceCost = 100.00m;
                    else if (age > 65)
                        insuranceCost = 250.00m;
                    break;
                }

                case VehicleType.Boat:
                {
                    if (age > 18 && age <= 27)
                        insuranceCost = 200.00m;
                    else if (age > 27 && age <= 65)
                        insuranceCost = 100.00m;
                    else if (age > 65)
                        insuranceCost = 150.00m;
                    break;
                }

                case VehicleType.Plane:
                {
                    if (age > 18 && age <= 27)
                        insuranceCost = 1000.00m;
                    else if (age > 27 && age <= 65)
                        insuranceCost = 500.00m;
                    else if (age > 65)
                        insuranceCost = 1000.00m;
                    break;
                }

            }

            Console.WriteLine($"The cost is {insuranceCost}.");

        }
    }
}
