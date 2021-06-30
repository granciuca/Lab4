using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    public interface IFlowerBuilder
    {
        IFlowerBuilder BuildFlowerPlan();
        IFlowerBuilder BuildFlowerColors();
        IFlowerBuilder BuildFlowerProportions();
        Flower GetFlower();
    }

}
