using Design_Pattern_Command_02.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_02.Invoker
{
    class AccountInvoker
    {
        private ICommand _checkBalance, _deposit, _withdrawl;
        private List<ICommand> _accountHistory;

        public AccountInvoker(ICommand checkBalance, ICommand deposit, ICommand withdrawl)
        {
            _checkBalance = checkBalance;
            _deposit = deposit;
            _withdrawl = withdrawl;
            _accountHistory = new List<ICommand>();
        }

        //-- Invoker Methods
        public void CheckBalance()
        {
            _checkBalance.Execute();
            _accountHistory.Add(_checkBalance);
        }

        public void Deposit()
        {
            _deposit.Execute();
            _accountHistory.Add(_deposit);
        }

        public void Withdrawl()
        {
            _withdrawl.Execute();
            _accountHistory.Add(_withdrawl);
        }
    }
}
