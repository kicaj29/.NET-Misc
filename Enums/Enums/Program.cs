// See https://aka.ms/new-console-template for more information
using Enums;

Console.WriteLine("Hello, World!");


// try parse executes trim operation before parsing!
if (Enum.TryParse("  ExpORted  ", ignoreCase: true, out MyEnum result))
{
    Console.WriteLine(result);
}
Console.WriteLine("END");
Console.ReadKey();