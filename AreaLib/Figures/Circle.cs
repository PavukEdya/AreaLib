using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Figures
{
    public class Circle : IFigure
    {
        public Circle(double radius) {
            Radius = radius;
        }

        public double Radius { get; set; }
        
        public double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}
