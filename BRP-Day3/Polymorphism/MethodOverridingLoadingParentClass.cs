using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class MethodOverridingLoadingParentClass
    {
        public void Method1()
        {
            Console.WriteLine("Parent's Class Method1 is called");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Parent's Class Method2 is called");
        }
    }
    class OverloadingAndRiddingUnderChildClass : MethodOverridingLoadingParentClass
    {
        public void Method1(int number)
        {
            Console.WriteLine("Child's Class Method1 is called which is Overloading Parent's Method1");
        }
        public override void Method2()
        {
            Console.WriteLine("Child's Class Method2 is called which is Overrriding Parent's Method2");
        }
    }
}
