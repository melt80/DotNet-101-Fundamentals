using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_02.Receiver
{
    class CheckingAccount : IAccount
    {
        private decimal _balance = 0;
        
        public decimal CheckBalance()
        {
            return _balance;
        }

        public void Deposit(decimal transAmount)
        {
            _balance += transAmount;
        }

        public void Withdrawl(decimal transAmount)
        {
            _balance -= transAmount;
        }
    }
}
