using System;

namespace NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            int? b = null; // ? Nallable operator

            int c = 12;

            int d = b ?? c; // ?? is Null-coalescing operator

            int? e = 456;

           // Console.WriteLine(a); It will returns error

            Console.WriteLine(b);

            Console.WriteLine(b.HasValue);

            Console.WriteLine(b.GetValueOrDefault());

            Console.WriteLine(e);

            Console.WriteLine(e.HasValue);

            Console.WriteLine(e.GetValueOrDefault());

            Console.WriteLine(c);

            Console.WriteLine(d);

            Nullable<int> i = null;
            Console.WriteLine(i);

            Nullable<int> j = 345;
            Console.WriteLine(j);

            int k = 78;
            int l = 78;

            if (Nullable.Compare<int>(k, l) < 0)
            {
                Console.WriteLine("k < l");
            }
            else if (Nullable.Compare<int>(k, l) > 0)
            {
                Console.WriteLine("k > l");
            }
            else
            {
                Console.WriteLine("k = l");
            }

            int? o = null;
            int p = 78;

            if (Nullable.Compare<int>(o, p) < 0)
            {
                Console.WriteLine("o < p");
            }
            else if (Nullable.Compare<int>(o, p) > 0)
            {
                Console.WriteLine("o > p");
            }
            else
            {
                Console.WriteLine("o = p");
            }
        }
    }
}
