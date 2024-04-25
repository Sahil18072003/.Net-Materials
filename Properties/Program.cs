using System;

namespace Properties
{
    public class Apple
    {
        public Apple(string nam)
        {
            i++;
            a = 12;
            c = 'R';
            d = 80;
            age = 56;
            nam = "Sahil Khan";
        }

        // Fields -> This can be public also
        private int a;

        // Properties -> can be private, public, protected, or internal
        public int A
        {
            // Methods
            get { return a; }
            set { a = value; }
        }

        public string B { get; set; }

        // STatic Properties
        private static char c = 'G';
        public static char C 
        {
            get { return c; }
            set { c = value; }
        }

        private static int i = 92;

        // read-only static property
        public static int Con
        {
            get { return i; }
        }

        int d;
        public int D
        {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
            }
        }

        // read-only non-static property
        public int Don
        {
            get { return d; }
        }

        // Const variable
        public const int Add = 789;

        // private const int Add = 789; // Protection level error

        // Readonly 
        readonly int roll = 3213;

        readonly int age;

        readonly string nam = "Gsab";

        /*public changeName(string newName)
        {
            nam = "Manish Khan";
        }*/  // will result error
    }
    internal class Program
    {
        private const float PI = 3.14F;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Apple a = new Apple("Sunit");

            Console.WriteLine(a.A);
            a.A = 80;
            Console.WriteLine(a.A);

            Console.WriteLine(a.B);
            a.B = "Sahil";
            Console.WriteLine(a.B);

            Console.WriteLine(Apple.C);
            Apple.C = 'A';
            Console.WriteLine(Apple.C);

            Console.WriteLine(a.D);
            a.D = 90;
            Console.WriteLine(a.D);

            Console.WriteLine("This is read-only static property : " + Apple.Con);

            Console.WriteLine("This is read-only property : " + a.Don);

            const int RollNo = 1234;
            const int Age = 12 + 34;
            const string Name = "Sahil Dharaviya";

            // RollNo = 1405; // Will result compile time error. 
            // Age++; // Will result compile time error. 

            Console.WriteLine(Name);

            Console.WriteLine(PI);

            Console.WriteLine(Apple.Add);

            Apple b = new Apple("Manish");
            Console.Read();
        }
    }
}
