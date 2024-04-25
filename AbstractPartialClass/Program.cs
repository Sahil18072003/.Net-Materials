using System;

namespace AbstractPartialClass
{
    internal class Program
    {
        abstract class Animal
        {
            public abstract void show();
            public void view()
            {
                Console.WriteLine("Hello I am base animal class ka method");
            }
        }

        class Cat : Animal
        {
            public override void show()
            {
                Console.WriteLine("Hello !! I am child class ka method.");
            }
        }

        class Horse : Cat
        {
            public override void show()
            {
                Console.WriteLine("Hello !! I am grand child class ka method.");
            }
        }

        partial class Maths
        { 
            public void view()
            {
                Console.WriteLine("This is partial first class ka method");
            }
        }

        partial class Maths
        { 
            public void show()
            {
                Console.WriteLine("This is partial second class ka method");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cat c = new Cat();
            c.show();

            Animal a = new Cat();
            a.show();

            Cat c1 = new Horse();
            c1.show();

            Animal c2 = new Horse();
            c2.show();

            Maths m = new Maths();
            m.show();
            m.view();
        }
    }
}
