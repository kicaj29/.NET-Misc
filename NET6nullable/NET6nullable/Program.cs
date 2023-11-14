// See https://aka.ms/new-console-template for more information

using NET6nullable;

Console.WriteLine("Hello, World!");

Person p1 = new() { Name = "Jacek" };
Person? p2 = new() { Name = "Placek" };

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);

p2 = null;
string sWithText = "abc";
string s1 = p2?.Name; // s1 will be set on null
string s2; // s2 will be set on null
sWithText = p2?.Name; // sWithText will be set on null
//Console.WriteLine(p2!.Name); // this will throw null reference exception

Person p11 = null;
Person? p22 = null;

Console.WriteLine(p11.Name);
Console.WriteLine(p22.Name);

