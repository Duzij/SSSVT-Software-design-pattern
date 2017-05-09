using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public abstract class CommandBase
    {
        public Receiver Receiver { get; set; }
        public CommandBase(Receiver rec)
        {
            Receiver = rec;
        }

        public abstract void Execute();



    }
}
