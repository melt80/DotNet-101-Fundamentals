using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_02.Receiver
{
    interface IAccount
    {
        decimal CheckBalance();
        void Deposit(decimal transAmount);
        void Withdrawl(decimal transAmount);
    }
}
