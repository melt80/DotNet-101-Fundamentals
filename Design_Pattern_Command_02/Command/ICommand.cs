using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_02.Command
{
    interface ICommand
    {
        decimal TransactionValue { get; set; }
        void Execute();
    }
}
