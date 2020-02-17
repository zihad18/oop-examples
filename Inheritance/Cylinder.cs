using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }
}
