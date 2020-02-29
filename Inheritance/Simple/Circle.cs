using System;

namespace Inheritance.Simple
{
    public class Circle
    {
        public double Radius { get; set; }
        public Circle()
        {

        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public virtual double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
