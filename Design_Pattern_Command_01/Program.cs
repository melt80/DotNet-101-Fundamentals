using Design_Pattern_Command_01.Command;
using Design_Pattern_Command_01.Command.ConcreteCommands;
using Design_Pattern_Command_01.Invoker;
using Design_Pattern_Command_01.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_01
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car();
            IVehicle motorcycle = new Motorcycle();

            ICommand turnOnCommand = new TurnOnVehicle(car);
            ICommand turnOffCommand = new TurnOffVehicle(car);
            ICommand speedUpCommand = new SpeedUpVehicle(car);
            ICommand brakeCommand = new BrakeVehicle(car);

            ICommand turnOnMotorcycle = new TurnOnVehicle(motorcycle);
            ICommand turnOffMotorcycle = new TurnOffVehicle(motorcycle);
            ICommand speedUpMotorcycle = new SpeedUpVehicle(motorcycle);
            ICommand brakeMotorcycle = new BrakeVehicle(motorcycle);

            VehicleInvoker invoker = 
                new VehicleInvoker(turnOnCommand, turnOffCommand, speedUpCommand, brakeCommand);
            VehicleInvoker motorclycleInvoker =
                new VehicleInvoker(turnOnMotorcycle, turnOffMotorcycle, speedUpMotorcycle, brakeMotorcycle);

            invoker.TurnOn();
            invoker.SpeedUp();
            invoker.Brake();
            invoker.TurnOff();

            motorclycleInvoker.TurnOn();
            motorclycleInvoker.SpeedUp();
            motorclycleInvoker.Brake();
            motorclycleInvoker.TurnOff();
            Console.ReadLine();
        }
    }
}
