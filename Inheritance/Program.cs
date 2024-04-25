using System;
using System.Security.Cryptography;

namespace Inheritance
{
    class A
    {
        public int A1;
        public int A2;

        public A() {
            A1 = 456;
            A2 = 4325;
        }
        public A(int a, int b)
        {
            // Console.WriteLine("This is class A's Constructor.");
            A1 = a;
            A2 = b;
        }

        public void AA(int A1, int A2)
        {
            // Console.WriteLine("This is class A's method");
            Console.WriteLine(A1 + " " + A2);
        }
    }

    // Single inheritance
    class B : A
    {
        public int A3;
        public int A4;
        
        public B() { }
        public B(int a, int b)
        {
            // Console.WriteLine("This is class B's Constructor.");
            this.A3 = a;
            this.A4 = b;
        }    
 
        public void BB()
        {
            // Console.WriteLine("This is class B's method");
            Console.WriteLine(A1 + " " + A2 + " " + A3 + " " + A4);
        }
    }

    // Multi-level Inheritance
    class C : B
    {
        public C()
        {
             Console.WriteLine("This is class C's Constructor.");
        }

        public void CC()
        {
             Console.WriteLine("This is class C's method");
        }
    }

    // Hierachical Inheritance
    class D : A
    {
        public D()
        {
             Console.WriteLine("This is class D's Costructor.");
        } 

        public void DD()
        {
             Console.WriteLine("This is class D's method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance
            B a1 = new B(34,56);
            a1.AA(23,54);
            a1.BB();

            B a = new B(24,76);
            a.AA(62,75);
            a.BB();

            // Multi-level Inheritance
            C a2 = new C();
            a2.AA(342,75);
            a2.BB();
            a2.CC();

            // Hierachical Inheritance
            B a3 = new B(443,643);
            D a4 = new D();
            a3.AA(87,97);
            a3.BB();
            a4.AA(53,85);
            a4.DD();

            //A a5 = new B();
            //a5.AA();
            // a5.BB(); // returns error
        }
    }
}
