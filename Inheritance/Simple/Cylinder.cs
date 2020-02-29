using System;

namespace Inheritance.Simple
{
    public class Cylinder : Circle
    {
        public double Height { get; set; }
        public Cylinder(double radius, double height)
            :base(radius)
        {
            Height = height;
        }

        public override double GetArea()
        {
            return base.GetArea() * Height;
        }
    }
}
