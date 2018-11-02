﻿using Design_Pattern_Command_01.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_01.Command.ConcreteCommands
{
    class TurnOffVehicle : ICommand
    {
        private IVehicle _vehicle;
        public TurnOffVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Execute()
        {
            _vehicle.TurnOff();
        }
    }
}
