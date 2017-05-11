using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    public class HtmlDocument : TemplateMethodBase
    {
        public override void Step1()
        {
            Console.WriteLine("Html just made step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Html just made step 2");
        }
    }
}
