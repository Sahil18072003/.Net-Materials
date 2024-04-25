using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int MyDelegate(int a);

namespace Delegates
{
    internal class Program
    {
        static int n = 45;
        public static int Add(int a)
        {
            n += a;
            return n;
        }

        public static int View() 
        {
            return n;
        }

        static void Main(string[] args)
        {
            MyDelegate Del = new MyDelegate(Add);

            Del(43);

            Console.WriteLine(View());

            Console.ReadKey();
        }
    }
}
