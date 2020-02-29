namespace Inheritance.BeforeAbstract
{
    public class Cylinder : Circle
    {
        public float Height { get; set; }
        public Cylinder()
            :base()
        {

        }
        public Cylinder(float radius, float height)
            :base(radius)
        {
            Height = height;
        }
        public Cylinder(float radius, float height, string color, bool filled)
            : base(radius, color, filled)
        {
            Height = height;
        }
        public override string ToString() => $"{base.ToString()}, Height = {Height}";
        public override double GetArea() => base.GetArea() * Height;
    }
}
