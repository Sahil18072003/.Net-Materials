using System;

namespace Constructors
{
    class Cons
    {
        // Fields
        public int num;
        public string name;

        // If we are not giving default values so it will take null and 0
        /* public Cons() 
        {
            Console.WriteLine("This is default Constructor");
        } */

        // Default Constructor
        public Cons()
        {
            name = "Ramesh";
            num = 60;
        }

        // Parameterized Constructor
        public Cons(int num, string name)
        {
            this.num = num;
            this.name = name;
        }

        public Cons(Cons obj)
        {
            name = obj.name; 
            num = obj.num;
        }

        public void View(string name, int num)
        {
            Console.WriteLine("Number = " + num + " and Name = " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cons c1 = new Cons();
            Console.WriteLine("Number = " + c1.num + " and Name = " + c1.name);
            c1.View("Sahu", 5);

            Cons c2 = new Cons(2, "Sahil");
            Console.WriteLine("Number = " + c2.num + " and Name = " + c2.name);
            c2.View("Ramu", 7);

            Cons c3 = new Cons(c2);
            Console.WriteLine("Number = " + c3.num + " and Name = " + c3.name);
            c3.View("Raghu", 8);
        }
    }
}
