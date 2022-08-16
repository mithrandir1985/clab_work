using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Circle:Shape
    {
        public double radius { get; set; }
        readonly static double pie = 3.14;
        public override double calculatearea()
        {
            return (pie * (radius * radius));
        }
        public override double calculateperimeter()
        {
            return (2 * pie * radius);
        }
    }
}
