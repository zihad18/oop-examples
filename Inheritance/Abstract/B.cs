using System;

namespace Inheritance.Abstract
{
    public class B : A
    {
        public override void M1()
        {
            Console.WriteLine("M1 Implemented");
        }
        public override void M3()
        {
            Console.WriteLine("M3 Implemented");
        }
    }
}
