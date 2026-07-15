using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.SOLID_Principles.O_OpenClosedPrinciple
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}
