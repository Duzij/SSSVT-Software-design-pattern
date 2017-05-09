using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SimpleCommand
{
    public class SimpleCommand
    {
        private int State { get; set; }
        public SimpleCommand(int state)
        {
            this.State = state;
        }

        public void Add(int num)
        {
            this.State += num;
        }

        public void AddTwo(int num, int num2)
        {
            this.State += (num + num2);
        }

        public int Result()
        {
            return State;
        }
    }
}
