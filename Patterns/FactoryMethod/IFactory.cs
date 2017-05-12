using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public interface IFactory
    {
        void Action();
    }

    public class Product1 : IFactory
    {
        public void Action()
        {
            Console.WriteLine("Product1 action");
        }
    }

    public class Product2 : IFactory
    {
        public void Action()
        {
            Console.WriteLine("Product2 action");
        }
    }
}
