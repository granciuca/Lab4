using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class BouquetAccessoriesDecorator : Bouquet
    {
        private Bouquet _bouquet;
        public BouquetAccessoriesDecorator(Bouquet element)
        {
            this._bouquet = element;
        }

        public override int CalculateTotalPrice()
        {
            return this._bouquet.CalculateTotalPrice();
        }
    }
}
