using System;

namespace Inheritance
{
    public class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(int radius)
        {

        }

        public Circle(double radius, string color)
        {

        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
