namespace Inheritance.BeforeAbstract
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Length { get; set; }
        public Rectangle()
            : base()
        {
            Width = 1.0f;
            Length = 1.0f;
        }
        public Rectangle(float width, float length)
            : base()
        {
            Width = width;
            Length = length;
        }
        public Rectangle(float width, float length, string color, bool filled)
            : base(color, filled)
        {
            Width = width;
            Length = length;
        }
        public override string ToString() => $"{base.ToString()}, Width={Width}, Length={Length}";
        public double GetArea() => Width * Length;
    }
}
