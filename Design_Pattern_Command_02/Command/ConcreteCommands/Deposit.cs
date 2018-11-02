using Design_Pattern_Command_02.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_02.Command.ConcreteCommands
{ 
    class Deposit : ICommand
    {
        private IAccount _account;

        public Deposit(IAccount account, decimal value)
        {
            _account = account;
            TransactionValue = value;
        }

        public decimal TransactionValue { get; set; }

        public void Execute()
        {
            _account.Deposit(TransactionValue);
        }
    }
}
