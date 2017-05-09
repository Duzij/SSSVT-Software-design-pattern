using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class Invoker
    {
        public CommandBase CommandBase { get; set; }

        public void SetCommand(CommandBase com)
        {
            CommandBase = com;
        }

        public void ExecuteCommand()
        {
            CommandBase.Execute();
        }

    }
}
