using Newtonsoft.Json;
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
                var s1 = Newtonsoft.Json.JsonConvert.SerializeObject(ex);

                try
                {
                    // https://github.com/dotnet/runtime/issues/43026
                    var s2 = System.Text.Json.JsonSerializer.Serialize(ex, new System.Text.Json.JsonSerializerOptions()
                    {
                        MaxDepth = 2
                    });
                }
                catch (Exception ex1)
                {

                }


                var data = ex.Data;
                foreach(var item in data)
                {


                }

            }
        }
    }
}
