using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class MyObserver : IObserver
    {
        public MySubject subject { get; set; }

        public MyObserver(MySubject subject)
        {
            this.subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"Pozor, state je nyní {subject.GetState()}");  
        }
    }
}
