using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Figures
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            var sides = new[] { a, b, c };
            Array.Sort(sides);
            if (c >= a + b)
                throw new ArgumentException("The sides of a triangle cannot be greater than or equal to the sum of the other two sides");
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public double Area()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRight()
        {
            var sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
        }

    }
}
