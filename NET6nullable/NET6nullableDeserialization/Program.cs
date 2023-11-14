// See https://aka.ms/new-console-template for more information
using NET6nullableDeserialization;
using System.Text.Json;

Console.WriteLine("Hello, World!");

/*List<Car> generator = new List<Car>();
generator.Add(new Car("car1", 3));
generator.Add(new Car("car2", 23));

string json = JsonSerializer.Serialize(generator);

File.WriteAllText("cars.json", json);*/


List<Car>? cars = JsonSerializer.Deserialize<List<Car>>(File.ReadAllText("carsWithNulls.json"));

Console.WriteLine(cars?.Count);
Console.WriteLine("name 0: " + cars?[0].Name);
Console.WriteLine("name 1: " + cars?[1].Name);

Console.ReadKey();


