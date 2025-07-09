using System;
using System.Diagnostics;

namespace dynamicVSvarVSobject
{
    public class DynamicVarObject
    {
        public static object returnObject()
        {
            object o = "123";
            return o;
        }

        /*public static var returnVar()
        {
            var s = "abc";
            return s;
        }*/

        public static string returnString()
        {
            var s = "abc";
            return s;
        }

        public static dynamic returnDynamic(dynamic x)
        {
            if (x)
            {
                dynamic val1 = new
                {
                    Name = "Jacek",
                    Age = 21
                };
                return val1;
            }
            else
            {
                dynamic val2 = new
                {
                    Gender = "male",
                    Salary = 2000
                };
                return val2;
            }
        }

        public static void Go()
        {

            //1. var does not allow the type of value assigned to be changed after it is assigned to.
            //   dynamic supports it also object supports it.

            var i = 999;
            // i = "aaaa"; //compilation error

            dynamic d = 999;
            d = "aaa";

            object o = 999;
            o = "aaa";

            //2. Intellisense works for var, does not work for dynamic, for object we can see only basic things from object type

            dynamic address = new
            {
                City = "Katowice",
                Street = "Mikolowska"
            };



            //3. dynamic variables can be used to create properties and return values from a function.
            //   var variables cannot be used for property or return values from a function. They can only be used as local variable in a function.
            //   object can be used everywhere.

            //4. object types increase the overhead of boxing and un-boxing, before we can use the actual values stored in it.
            //   it is not the case for var.

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

        private static void TestTypes()
        {
            dynamic dyn = 1;
            object obj = 1;

            Debug.WriteLine((string)dyn.GetType().Name);    // prints Int32
            Debug.WriteLine(obj.GetType().Name);            // prints Int32

            dyn = dyn + 3;                                  // 4
            // obj = obj + 3; // compilation error
        }

        public static void ObjectVsDynamic()
        {
            TestTypes();

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


        public static void ConvertFromStringJsonToDynamic()
        {
            string jsonString = "{\"Type\": \"Notification\", \"MessageId\": \"d9a5ec79-ffa4-4da4-8c9c-e8a4cd7a39a9\", \"TopicArn\": \"arn:aws:sns:us-east-1:000000000000:hxp-audit-events-topic\", \"Message\": \"{\\\"specversion\\\":\\\"1.0\\\",\\\"id\\\":\\\"e1b1808b-c8f1-4943-98c2-cd505c4d432e\\\",\\\"type\\\":\\\"hxp:audit:event:v1\\\",\\\"source\\\":\\\"hxp:client:audit\\\",\\\"time\\\":\\\"2022-10-10T07:10:58.2291726Z\\\",\\\"data\\\":{\\\"appKey\\\":\\\"hxc\\\",\\\"context\\\":{\\\"id\\\":\\\"STORAGEINTEGRATIONTEST\\\",\\\"type\\\":\\\"environment\\\"},\\\"actor\\\":\\\"hxc.file.uploaded\\\",\\\"type\\\":\\\"hxc.file.uploaded\\\",\\\"subject\\\":{\\\"id\\\":\\\"94e3c3d6-ff63-47dc-b8e4-e7c8a59e57e7\\\",\\\"scope\\\":\\\"file\\\"},\\\"date\\\":\\\"2022-10-10T07:10:58.2190398Z\\\",\\\"message\\\":{\\\"general\\\":{\\\"description\\\":\\\"Uploaded file.\\\",\\\"duration\\\":7318.6465,\\\"serviceId\\\":\\\"ms_storage\\\",\\\"connectionId\\\":\\\"0HMLAHQ8AJITF\\\",\\\"type\\\":\\\"production\\\"},\\\"change\\\":[{\\\"field\\\":\\\"name\\\",\\\"value\\\":\\\"8050cc6e-ab03-468a-91e0-5bf486259e3d.txt\\\"},{\\\"field\\\":\\\"size\\\",\\\"value\\\":36},{\\\"field\\\":\\\"version\\\",\\\"value\\\":\\\"ORIGINAL\\\"},{\\\"field\\\":\\\"contentType\\\",\\\"value\\\":\\\"text/plain\\\"}]},\\\"traceId\\\":\\\"599cb9139872e5e0babe59ae4aa9f9d7\\\"}}\", \"Timestamp\": \"2022-10-10T07:11:00.451Z\", \"SignatureVersion\": \"1\", \"Signature\": \"EXAMPLEpH+..\", \"SigningCertURL\": \"https://sns.us-east-1.amazonaws.com/SimpleNotificationService-0000000000000000000000.pem\", \"MessageAttributes\": {\"content-type\": {\"Type\": \"String\", \"Value\": \"application/cloudevents+json; charset=utf-8\"}}}";

        }
    }
}
