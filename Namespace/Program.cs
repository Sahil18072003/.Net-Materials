using System;
using Project;

namespace Project
{
    public class A
    {
        public int i = 3;
        private int j = 7;
        protected int d = 8;
        internal protected int k;
       
        public static void View()
        {
            Console.WriteLine("Hello i am class A's method");
        }
    }

   public  class C
    {
        internal protected int l
        {
            get; set;
        }

    }
}

namespace Namespace
{
    class B : C
    {
        public B ()
        {
            l = 78;
        }

        public static void Show(int l)
        {
            Console.WriteLine("This is internal protected variable : " + l);
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
            // Console.WriteLine(a.j); gives error private
            // Console.WriteLine(a.d); gives error protected

            B b = new B();
            Console.WriteLine(b.l);
        }
    }
}