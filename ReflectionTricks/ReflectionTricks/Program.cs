using ReflectionTricks;
using System.Reflection;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MethodInfo mi = typeof(Example).GetMethod(nameof(Example.Add));

MethodBody mb = mi.GetMethodBody();
byte[] bodyBytes = mb.GetILAsByteArray();


Console.ReadKey();
