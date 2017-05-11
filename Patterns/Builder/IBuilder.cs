using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        void GetResult();
    }
}
