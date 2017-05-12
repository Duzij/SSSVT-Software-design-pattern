using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public class MyVehicleFactory : IProductFactory
    {
        public IFactory CreateProduct(string product)
        {
            if (product == "Product1")
                return new Product1();
            else
                return new Product2();
        }
    }
}
