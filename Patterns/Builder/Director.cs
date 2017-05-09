using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class Director 
    {
        public void Construct(IBuilder biulder)
        {
            biulder.BuildPart1();
            biulder.BuildPart2();
            biulder.BuildPart3();
        }
    }
}
