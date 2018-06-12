using System;

namespace AbstractClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //myAbstractClass mac = new myAbstractClass(); Not possible to instantiate in abstract class
            MyImplementedClass mac1 = new MyImplementedClass("Bru", 20);
            Console.WriteLine(mac1.Birthday());
        }
    }
}
