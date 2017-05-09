using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class SwitchOnCommand : ICommand
    {
        public LightReceiver LightReceiver { get; set; }
        public SwitchOnCommand(LightReceiver light)
        {
            LightReceiver = light;
        }
        public void Execute()
        {
            LightReceiver.TurnOn();
        }
    }

    public class SwitchOffCommand : ICommand
    {
        public LightReceiver LightReceiver { get; set; }
        public SwitchOffCommand(LightReceiver light)
        {
            LightReceiver = light;
        }
        public void Execute()
        {
            LightReceiver.TurnOff();
        }
    }
}
