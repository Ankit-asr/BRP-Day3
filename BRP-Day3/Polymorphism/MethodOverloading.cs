using System;

namespace Polymorphism
{
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overloading within same Class");
            MethodOverloading obj = new MethodOverloading();
            obj.Test();
            obj.Test(100);
            obj.Test("abc");
            obj.Test(100 , "abc");
            obj.Test("abc",100);
            Console.WriteLine("==================================================================================");
            Console.WriteLine("Overloading and Overriding in different Classes i.e Inheritance");
            OverloadingAndRiddingUnderChildClass obj1 = new OverloadingAndRiddingUnderChildClass();
            obj1.Method1();
            obj1.Method1(100);
            obj1.Method2();
        }
        public void Test()
        {
            Console.WriteLine("First Method without any parameters");
        }
        public void Test(int number)
        {
            Console.WriteLine("Second Method with integer type parameter :"+number);
        }
        public void Test(string str)
        {
            Console.WriteLine("Third Method with string type parameter :"+str);
        }
        public void Test(int number , string str)
        {
            Console.WriteLine("Fourth Method with two parameters :"+number+ " "+str);
        }
        public void Test(string str , int number)
        {
            Console.WriteLine("Fifth Method with two parameters but in different order :"+str+" "+number);
        }
    }
}
