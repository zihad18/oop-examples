using Inheritance.BeforeAbstract;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new Circle();
            Console.WriteLine(circle1.ToString());
            Console.WriteLine(circle1.GetArea());

            var circle2 = new Circle(5.0f);
            Console.WriteLine(circle2.ToString());
            Console.WriteLine(circle2.GetArea());

            var circle3 = new Circle(5.0f, "Black", false);
            Console.WriteLine(circle3.ToString());
            Console.WriteLine(circle3.GetArea());

            var cylinder1 = new Cylinder();
            Console.WriteLine(cylinder1.ToString());
            Console.WriteLine(cylinder1.GetArea());

            var cylinder2 = new Cylinder(5.0f, 10.0f);
            Console.WriteLine(cylinder2.ToString());
            Console.WriteLine(cylinder2.GetArea());

            var cylinder3 = new Cylinder(5.0f, 10.0f, "Blue", true);
            Console.WriteLine(cylinder3.ToString());
            Console.WriteLine(cylinder3.GetArea());
        }
    }
}
