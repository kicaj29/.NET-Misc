using Newtonsoft.Json;
using System;

namespace SerializationDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = JsonConvert.DeserializeObject<Person>("{ Name: 'Jacek' }");

            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
        }
    }
}
