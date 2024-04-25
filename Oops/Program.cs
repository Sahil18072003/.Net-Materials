using System;
using Project;

namespace Oops
{
    class D : Project.A
    {
        public D() {
            k = 67;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A a = new A();
            Console.WriteLine(a.i);
            Console.WriteLine(a.k);
            a.View();
        }
    }
}
