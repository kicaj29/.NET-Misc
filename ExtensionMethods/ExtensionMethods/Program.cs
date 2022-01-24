using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer c = new Customer();
            c.Name = "Jacek";
            c.SecondName = "Placek";
            var fullName = c.GetFullName();
            c = null;
            // we can call extension method on a null value
            var fullNameFromNull = c.GetFullName();
        }
    }
}
