using System;
namespace Inheritance.Abstract
{
    public abstract class A
    {
        public int Prop1 { get; set; }
        public const int Prop2 = 52;
        public A()
        {
            Prop1 = 1;
        }
        public abstract void M1();
        public abstract void M3();
        public void M2()
        {
            Console.WriteLine("This is the implementation.");
        }
    }
}
