using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    class CompositePurchase : Flower, ICompositeOperations
    {
        private List<Flower> _flower;
        public CompositePurchase(string name, int price)
            : base(name, price)
        {
            _flower = new List<Flower>();
            
        }
        public void Add(Flower element)
        {
            _flower.Add(element);
        }
        public void Remove(Flower element)
        {
            _flower.Remove(element);
        }
        public int CalculateTotalPrice()
        {
            int total = 0;
            Console.WriteLine($"{Plan} contains the following products with prices:");
            foreach (var gift in _flower)
            {
                total += gift.CalculateTotalPrice();
            }
            return total;
        }

    }
}
