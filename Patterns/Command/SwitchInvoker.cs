using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class SwitchInvoker
    {
        public List<ICommand> CommandList { get; set; }

        public SwitchInvoker()
        {
            CommandList = new List<ICommand>();
        }

        public void StoreAndExecute(ICommand command)
        {
            CommandList.Add(command);
            command.Execute();
        }

    }
}
