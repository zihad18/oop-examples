using System;

namespace Inheritance.AfterAbstract
{
    public class Circle : Shape
    {
        public float Radius { get; set; }
        public Circle()
            : base()
        {
            Radius = 1.0f;
        }
        public Circle(float radius)
            : base()
        {
            Radius = radius;
        }
        public Circle(float radius, string color, bool filled)
            : base(color, filled)
        {
            Radius = radius;
        }
        public override double GetArea() => Math.PI * Radius * Radius;
        public override string ToString() => $"{base.ToString()}, Radius = {Radius}";
    }
}
