using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class SunkaSyrPizzaBuilder : IBuilder
    {
        public Pizza Product { get; set; } = new Pizza();
        public void BuildPart1()
        {
            Product.Part1 = "těsto";
        }

        public void BuildPart2()
        {
            Product.Part2 = "sunka";
        }

        public void BuildPart3()
        {
            Product.Part3 = "syr";
        }

        public void GetResult()
        {
            Console.WriteLine($"We just made {Product.Part1}, {Product.Part2}, {Product.Part3}");
        }
    
    }

    public class FereronkyPizzaBuilder : IBuilder
    {
        public Pizza Product { get; set; } = new Pizza();
        public void BuildPart1()
        {
            Product.Part1 = "těsto";
        }

        public void BuildPart2()
        {
            Product.Part2 = "Fereronky";
        }

        public void BuildPart3()
        {
            Product.Part3 = " ";
        }
        public void GetResult()
        {
            Console.WriteLine($"We just made {Product.Part1}, {Product.Part2}, {Product.Part3}");
        }
    }
}
