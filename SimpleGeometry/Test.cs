using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry
{
    class Test
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(50, 10));
            shapes.Add(new Triangle(50, 10));
            shapes.Add(new Circle(50));
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
