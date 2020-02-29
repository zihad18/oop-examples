namespace Inheritance.BeforeAbstract
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Length { get; set; }
        public Rectangle()
            :base()
        {

        }
        public Rectangle(float width, float length)
            :base()
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
        public virtual double GetArea() => Width * Length;
    }
}
