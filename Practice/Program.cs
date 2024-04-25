using System;

namespace Practice
{
    class Xyz
    {
        public string name;
        public int age;

        public Xyz(string name, int age)
        {
            Console.WriteLine(name + " " + age);
        }

        public void Show(params int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public void Doneref(ref int n)
        {
            Console.Out.WriteLine(n);

        }

        public void Doneout(out int n)
        {
            n = 30;
            n += 30;
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }

    enum e
    {
        Computer,
        Electrical,
        Civil,
        Chemical,
        Electronic
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Xyz xyz = new Xyz("Sahil", 20);

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            int[,] b = new int[,] { { 1, 2, 3 }, { 3, 4, 5 } };

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine((int)e.Electrical);
            Console.WriteLine((int)e.Computer);



            Xyz x1 = new Xyz(" ", 0);
            x1.Show(array);

            // i am not giving params so it will gives me error
            x1.Show(34, 463, 14, 123, 5, 324, 543, 532, 534, 65325, 332, 53);

            // method overloading
            x1.Sum(23, 45);
            x1.Sum(12, 34, 34);

            int x = 50;
            x1.Doneref(ref x);

            int y;
            x1.Doneout(out y);
            Console.WriteLine(y);
        }
    }
}

