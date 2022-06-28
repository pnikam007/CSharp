using System;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Show();           // "From Base Class"

            Derived d = new Derived();
            d.Show();           // "From Derived Class"

            Base bd = new Derived();
            bd.Show();          // override = "From Derived Class"         new/nothing = "From Base Class"

            Console.ReadKey();
        }
    }


    class Base
    {
        public virtual void Show()
        {
            Console.WriteLine("From Base Class");
        }
    }

    class Derived : Base
    {
        public new void Show()
        {
            Console.WriteLine("From Derived Class");
        }
    }
}
