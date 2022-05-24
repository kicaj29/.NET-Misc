using System;

namespace SerializeException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                throw new CustomerException("Jacek", "Kowalski");
            }
            catch(Exception ex)
            {
                var data = ex.Data;
                foreach(var item in data)
                {


                }

            }
        }
    }
}
