using Design_Pattern_Command_02.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_02.Command.ConcreteCommands
{
    class CheckBalance : ICommand
    {
        private IAccount _account;

        public decimal TransactionValue { get; private set; }

        public CheckBalance(IAccount account)
        {
            _account = account;           
        }

        decimal ICommand.TransactionValue { get; set; }

        public void Execute()
        {
            _account.CheckBalance();
        }
    }
}
