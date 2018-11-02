using Design_Pattern_Command_02.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_02.Command.ConcreteCommands
{
    class Withdrawl : ICommand
    {
        public Withdrawl(IAccount account, decimal value)
        {
            _account = account;
            TransactionValue = value;
        }

        private IAccount _account;

        public decimal TransactionValue { get; set; }

        public void Execute()
        {
            _account.Withdrawl(TransactionValue);
        }
    }
}
