using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    public abstract class TemplateMethodBase
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
        }

        public abstract void Step1();

        public abstract void Step2();
    }
}
