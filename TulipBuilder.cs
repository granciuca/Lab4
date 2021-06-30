using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class TulipBuilder : IFlowerBuilder
    {
        private Flower _flower;

        public TulipBuilder()
        {
            _flower = new Flower();
        }

        public IFlowerBuilder BuildFlowerPlan()
        {
            _flower.Plan = "Plan: " + Plans.Tulip;
            return this;
        }


        public IFlowerBuilder BuildFlowerColors()
        {
            _flower.Color = "Color: " + Colors.Yellow;
            return this;
        }

        public IFlowerBuilder BuildFlowerProportions()
        {
            _flower.Proportions = "Proportions: " + Proportions.Medium;
            return this;
        }

        public Flower GetFlower()
        {
            var flower = _flower;
            Clear();
            return flower;
        }

        private void Clear() => _flower = new Flower();
    }
}


