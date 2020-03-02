namespace Inheritance.BeforeAbstract
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Length { get; set; }
        public Rectangle()
            : base()
        {
            SetDefaultValues(1.0f, 1.0f);
        }
        public Rectangle(float width, float length)
            : base()
        {
            SetDefaultValues(width, length);
        }
        public Rectangle(float width, float length, string color, bool filled)
            : base(color, filled)
        {
            SetDefaultValues(width, length);
        }

        private void SetDefaultValues(float width, float length)
        {
            Width = width;
            Length = length;
        }

        public override string ToString() => $"{base.ToString()}, Width={Width}, Length={Length}";
        public double GetArea() => Width * Length;
    }
}
