using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerDirector director = new FlowerDirector();

            var roseBuilder = new RoseBuilder();
            director.BuildFlower(roseBuilder);
            var roseReport = roseBuilder.GetFlower();

            Console.WriteLine(roseReport);
            Console.WriteLine("____________________________________\n");

            var mumBuilder = new MumBuilder();
            director.BuildFlower(mumBuilder);
            var mumReport = mumBuilder.GetFlower();

            Console.WriteLine(mumReport);
            Console.WriteLine("____________________________________\n");

            var tulipBuilder = new TulipBuilder();
            director.BuildFlower(tulipBuilder);
            var tulipReport = tulipBuilder.GetFlower();

            Console.WriteLine(tulipReport);
            Console.WriteLine("____________________________________\n");

        }
    }
}
