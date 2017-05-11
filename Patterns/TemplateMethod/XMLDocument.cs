using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    public class XmlDocument : TemplateMethodBase
    {
        public override void Step1()
        {
            Console.WriteLine("XML just made step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("XML just made step 2");
        }
    }
}
