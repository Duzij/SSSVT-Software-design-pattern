using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class MyCommand : CommandBase
    {
        public MyCommand(Receiver rec) : base(rec)
        {
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }
}
