using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

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
                Customer c = new Customer("Jacek", "Kowalski");

                var s1Customer = System.Text.Json.JsonSerializer.Serialize(c, new System.Text.Json.JsonSerializerOptions());

                XmlSerializer serializer = new XmlSerializer(typeof(CustomerException));
                StringBuilder sb = new StringBuilder();
                TextWriter writer = new StringWriter(sb);
                writer.Write(ex);

                var s1xml = sb.ToString();


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
