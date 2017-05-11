using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public abstract class SubjectBase
    {
        private List<IObserver> observers { get; set; }

        public SubjectBase()
        {
            observers = new List<IObserver>();
        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }
        public void Dettach(IObserver o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
