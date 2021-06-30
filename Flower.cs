using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    public class Flower
    {
        public string Plan { get; set; }
        public string Color { get; set; }
        public string Proportions { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .AppendLine(Plan)
            .AppendLine(Color)
            .AppendLine(Proportions)
        .ToString();
    }

}

