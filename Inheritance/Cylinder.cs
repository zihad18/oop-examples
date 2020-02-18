using System;

namespace Inheritance
{
    public class Cylinder : Circle
    {
        public double Height { get; set; }
        public Cylinder(double radius, double height)
        :base(radius, "red")
        {
            Height = height;
        }

        public double GetCylinderArea()
        {
            return base.GetArea() * Height;
        }
    }
}
