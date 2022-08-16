using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Square:Shape
    {
        public double length { get; set; }
        public override double calculatearea()
        {
            return (length * length);
        }
        public override double calculateperimeter()
        {
            return (4 * length);
        }
    }
}
