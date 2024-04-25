using System;

namespace NewOverrideAbstractPartial
{
    class Dada
    {
        public void saw()
        {
            Console.WriteLine("Hello !! I am Dada.");
        }

        public virtual void show()
        {
            Console.WriteLine("Hello !! I am Dadaaaa.");
        }

        public virtual void view()
        {
            Console.WriteLine("Hello !! I am Dadaaaaaaaaa.");
        }
    }

    class Papa : Dada
    {
        public virtual void saw()
        {
            Console.WriteLine("Hello !! I am Papa.");
        }

        public override void show()
        {
            Console.WriteLine("Hello !! I am Papaaaaa.");
        }

        public new void view()
        {
            Console.WriteLine("Hello !! I am Papaaaaaaaa.");
        }
    }

    class Beta : Papa
    {
        public new void saw()
        {
            Console.WriteLine("Hello !! I am Beta.");
        }
        public override void show()
        {
            Console.WriteLine("Hello !! I am Betaaaaaaaa.");
        }

        public new void view()
        {
            Console.WriteLine("Hello !! I am Betaaa.");
        }
        
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dada d = new Dada();
            //d.saw();
            //d.show();
            //d.view();

            Papa p = new Papa();
            //p.saw();
            //p.show();
            //p.view();

            Beta b = new Beta();
            //b.saw();
            //b.show();
            //b.view();

            Dada d1 = new Papa();
            //d1.saw();
            d1.show();
            d1.view();

            Papa b1 = new Beta();
            //b1.saw();
            b1.show();
            b1.view();

            Dada b2 = new Beta();
            //b2.saw();
            b2.show();
            b2.view();
        }
    }
}
