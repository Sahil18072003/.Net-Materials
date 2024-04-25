using System;
using System.ComponentModel.Design;

namespace StaticKeyword
{
    class B
    {
        public string i = "Hello";

        public static string j = "Sahil";

        public B(string i)
        {
            this.i = i;
        }

        static B()
        {
            j = "Ramu";
        }

        public void View(string i, string j)
        {
            Console.WriteLine(i + " " + j);
        }

        public static void Show()
        {
            Console.WriteLine(j);
        }
    }
    class A
    {
        public int i;

        public static int j;

        public A()
        {
            i = 10;
            j = 20;
        }

        public void View()
        {
            Console.WriteLine(i + " " + j);
        }
        public static void Show()
        {
            Console.WriteLine(j);
        }
    }

    static class Mother
    {
        public static int i;

        static Mother()
        {
            i = 100;
        }
         
        public static void View(string i)
        {
            Console.WriteLine(i);
        }
    }

    static class Father
    {
        public static string i;

        static Father()
        {
            i = "Yogeshbhai";
        }

        public static void View(string i)
        {
            Console.WriteLine(i);
        }
    }

    static class Son
    {
        public static int a = 45;

        // public int b = 34; // we cannot create normal members

        public static string str = "Static class";
        static Son() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            A a = new A();
            a.View(); // normal method
            A.Show(); // static method

            B b = new B("Raj");
            b.View();
            B.Show();

            Console.WriteLine(Father.i);

            Father.View("Tomybhai");

            Console.WriteLine(Mother.i);

            Mother.View("Gangaben");
        }
    }
}
