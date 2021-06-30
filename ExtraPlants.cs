using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class ExtraPlants : BouquetAccessoriesDecorator
    {
        public ExtraPlants(Bouquet element) : base(element)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"Extra plants for 100");
            return base.CalculateTotalPrice() + 100;
        }
    }
}
