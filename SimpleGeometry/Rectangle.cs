﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry
{
    class Rectangle:Shape
    {
        public Rectangle(int width, int height) : base(width, height) { }
        public override double CalculateSurface()
        {
            return this.Height * Width;
        }
    }
}
