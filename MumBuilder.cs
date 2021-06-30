using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    public class MumBuilder : IFlowerBuilder
    {
        private Flower _flower;

        public MumBuilder()
        {
            _flower = new Flower();
        }

        public IFlowerBuilder BuildFlowerPlan()
        {
            _flower.Plan = "Plan: " + Plans.Mum;
            return this;
        }

        public IFlowerBuilder BuildFlowerColors()
        {
            _flower.Color = "Color: " + Colors.White;
            return this;
        }

        public IFlowerBuilder BuildFlowerProportions()
        {
            _flower.Proportions = "Proportions: " + Proportions.Large;
            return this;
        }

        public Flower GetFlower()
        {
            var Flower = _flower;
            Clear();
            return Flower;
        }

        private void Clear() => _flower = new Flower();
    }

}
