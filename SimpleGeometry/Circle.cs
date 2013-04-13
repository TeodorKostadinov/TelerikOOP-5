using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry
{
    class Circle:Shape
    {
        public Circle(int radius):base(radius,radius)
       {

       }
       public override double CalculateSurface()
       {
           return Math.PI * this.Width*2;
       }
    }
}
