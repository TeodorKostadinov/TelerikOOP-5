using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry
{
    public abstract class Shape
    {
        private double width;
        private double height;
       protected double Width 
       { 
           get
            {
                return this.width;
            } 
           set
           {
               this.width=value;
           } 
       }
       protected double Height 
       { 
           get
            {
                return this.height;
            } 
           set
           {
               this.height=value;
           } 
       }
       
       public Shape(int widht, int height)
       {
           this.Width = widht;
           this.Height = height;
       }
       public abstract double CalculateSurface();
    }
}
