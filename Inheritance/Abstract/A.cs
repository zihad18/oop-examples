using System;
namespace Inheritance.Abstract
{
    public abstract class A
    {
        public int Prop1 { get; set; }
        public A()
        {
            Prop1 = 1;
        }
        public abstract void M1();

        public void M2()
        {
            Console.WriteLine("This is the implementation.");
        }
    }
}
