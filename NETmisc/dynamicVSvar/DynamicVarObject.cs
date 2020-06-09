using System;
using System.Diagnostics;

namespace dynamicVSvarVSobject
{
    public class DynamicVarObject
    {
        public static void Go()
        {
            
            //1. var does not allow the type of value assigned to be changed after it is assigned to.
            //   dynamic supports it also object supports it.

            var i = 999;
            // i = "aaaa"; //compilation error

            dynamic d = 999;
            d = "aaa";

            object o = 999;
            o = "999";

            //2. Intellisense works for var, does not work for dynamic, for object we can see only basic things from object type

            //3. dynamic variables can be used to create properties and return values from a function.
            //   var variables cannot be used for property or return values from a function. They can only be used as local variable in a function.
            //   object can be used everywhere.

            //4. object types increase the overhead of boxing and un-boxing, before we can use the actual values stored in it.
            //   it is not the case for vat.

            int i4 = 1;
            object o4 = i4;     //boxing
            var v4 = i4;        //no boxing

            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types
            // !!!"As part of the process, variables of type dynamic are compiled into variables of type object. 
            //  Therefore, type dynamic exists only at compile time, not at run time."!!!

            dynamic d4 = i4;    //probably also boxing because MSDN says that dynamic types exsists only during compilation!

            //5. for object and dynamic can happen runtime excpetions in case conversion or casting is not possible

            object o5 = "aaaa";
            dynamic d5 = "aaaa";

            // int i5 = Convert.ToInt32(o5); // runtime error
            // int i5 = d5;

        }

        // [Conditional("DEBUG")]
        private static void Test(string x)
        {

        }

        // [Conditional("DEBUG")]
        private static void Test(int x)
        {

        }

        public static void ObjectVsDynamic()
        {
            // dynamic correctly handles calling overloaded methods!
            // but it does not work if Test method is conditional! why -> https://stackoverflow.com/questions/28562834/why-cannot-i-use-debug-assert-with-a-method-accepting-dynamic-and-returning-bo
            dynamic w = 1;
            Test(w);


            // based on https://docs.microsoft.com/en-us/archive/blogs/csharpfaq/what-is-the-difference-between-dynamic-and-object-keywords
            // with dynamic you can write less code and achieve the same results


            // ---object---
            object obj = 10;
            System.Diagnostics.Debug.WriteLine(obj.GetType());

            // you need to explicitly cast obj to a necessary type.
            obj = (int)obj + 10;




            // ---dynamic---
            dynamic dyn = 10;
            // works:
            Console.WriteLine(dyn.GetType());
            // does not work, throws exception
            // System.Diagnostics.Debug.WriteLine(dyn.GetType()); // Cannot dynamically invoke method 'WriteLine' because it has a Conditional attribute
            // more here https://stackoverflow.com/questions/14104865/how-can-i-use-debug-write-with-dynamic-data
            // and here https://stackoverflow.com/questions/9382130/why-does-a-method-invocation-expression-have-type-dynamic-even-when-there-is-onl

            // this version works:
            System.Diagnostics.Debug.WriteLine(((int)dyn).GetType());
            // no need to do casting (better then object)
            dyn = dyn + 10;
            // Also, this operation will succeed for all numeric
            // or other types that support a “+” operation.
            dyn = 10.0;
            dyn = dyn + 10;

            dyn = "10";
            dyn = dyn + 10;

            // "So, if you often use the object keyword and have to perform a lot of casting
            // and/or use reflection to call methods and properties of objects,
            // you probably should take a look at the dynamic keyword. 
            // In some cases it’s more convenient than object and with less code to write."

        }
    }
}
