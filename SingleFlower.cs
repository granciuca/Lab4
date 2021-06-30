using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class SingleFlower : Flower
    {
        public SingleFlower(string plan, int price)
        : base(plan, price)
        {
        }
        public SingleFlower()
       : base()
        {
        }
        public int CalculateTotalPrice()
        {
            Console.WriteLine($"{Plan} with the price {Price}");
            return Price;
        }

    }
}
