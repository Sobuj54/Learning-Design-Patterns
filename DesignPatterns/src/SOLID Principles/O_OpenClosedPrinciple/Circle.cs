using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.src.SOLID_Principles.O_OpenClosedPrinciple
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
