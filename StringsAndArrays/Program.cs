using System;

namespace StringsAndArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello How are you ?";
            Console.WriteLine(s);

            Console.WriteLine(s.Length);

            Console.WriteLine(s.ToLower());

            Console.WriteLine(s.ToUpper());

            string firstName = "John";
            string lastName = "Doe";
            string name = firstName + " " + lastName;

            Console.WriteLine(name);

            Console.WriteLine(firstName + " " + lastName);

            // string interpolaration
            string name1 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name1);

            int x = 10, y = 20;
            string a = "10", b = "10";
            
            Console.WriteLine(x + y);

            Console.WriteLine(a + b);

            Console.WriteLine(++x + a);
            Console.WriteLine(x++ + a);

            Console.WriteLine(y + b);

            Console.WriteLine(a + x);

            Console.WriteLine(y + b);
        }
    }
}
