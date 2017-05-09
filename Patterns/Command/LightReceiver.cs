using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class LightReceiver
    {
        public void TurnOn()
        {
            Console.WriteLine("Light turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light turned off");
        }

    }
}
