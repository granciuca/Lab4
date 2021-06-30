using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class AdditionalRibbon : BouquetAccessoriesDecorator
    {
        public AdditionalRibbon(Bouquet element) : base(element)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"Additional ribbon for 20");
            return base.CalculateTotalPrice() + 20;
        }
    }
}
