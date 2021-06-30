using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class AdditionalFeatures : BouquetAccessoriesDecorator
    {
        public AdditionalFeatures(Bouquet element) : base(element)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"Additional Features for 250");
            return base.CalculateTotalPrice() + 250;
        }
    }
}

