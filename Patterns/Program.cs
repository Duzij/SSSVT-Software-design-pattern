using Patterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Command
            Receiver R = new Receiver();
            Invoker I = new Invoker();
            MyCommand com = new MyCommand(R);

            I.SetCommand(com);
            I.ExecuteCommand();


        }
    }
}
