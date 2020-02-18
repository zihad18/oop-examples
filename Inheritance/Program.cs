using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5.0);
            Console.WriteLine(circle.GetArea());

            var cylinder = new Cylinder(5.0, 10.0);
            Console.WriteLine(cylinder.GetArea());
            cylinder.GetCylinderArea();
        }
    }
}
