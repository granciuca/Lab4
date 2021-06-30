using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class FlowerDirector
    {
        public void BuildFlower(IFlowerBuilder builder)
        {
            builder.BuildFlowerPlan();
            builder.BuildFlowerProportions();
            builder.BuildFlowerColors();
            
        }

    }
}
