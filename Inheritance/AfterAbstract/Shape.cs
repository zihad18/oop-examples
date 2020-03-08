namespace Inheritance.AfterAbstract
{
    public abstract class Shape
    {
        protected string Color { get; set; }
        protected bool Filled { get; set; }
        protected Shape()
        {
            Color = "Red";
            Filled = true;
        }
        protected Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public override string ToString()
        {
            return $"Color = {Color}, Filled = {Filled}";
        }
        public abstract double GetArea();
    }
}
