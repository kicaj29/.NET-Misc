using System;

namespace RecordType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // record type is reference type
            PersonRecord pRecord1 = new PersonRecord() { FirstName = "Jacek", LastName = "Placek" };
            PersonRecord pRecord2 = new PersonRecord() { FirstName = "Jacek", LastName = "Placek" };
            if (pRecord1 == pRecord2)
            {
                // record type has own equality implemention that checks if all files are the same and it does not check if
                // the reference is the same
                Console.WriteLine("The same person (record)");
            }

            // use with to create a new record but with some fields modified
            var pRecord3 = pRecord1 with { LastName = "Wacek" };

            pRecord1 = pRecord2;
            pRecord1.FirstName = "New Name";
            Console.WriteLine(pRecord2.FirstName); // will print New Name because record type is a reference type

            PersonClass pClass1 = new PersonClass() { FirstName = "Jacek", LastName = "Placek" };
            PersonClass pClass2 = new PersonClass() { FirstName = "Jacek", LastName = "Placek" };
            if (pClass1 == pClass2)
            {
                Console.WriteLine("The same person (class)");
                // will not print this because for class is chcekd reference and not values of all fields from the class
            }
            pClass1 = pClass2;
            pClass1.FirstName = "New new name";
            Console.WriteLine(pClass2.FirstName); // will print New new name because class type is a reference type

            PersonStruct pStruct1 = new PersonStruct() { FirstName = "Jacek", LastName = "Placek" };
            PersonStruct pStruct2 = new PersonStruct() { FirstName = "Jacek", LastName = "Placek" };
            // This will not compile, we cannot use == to compare structs!!!
            // if (pStruct1 == pStruct2)
            if (pStruct1.Equals(pStruct2))
            {
                Console.WriteLine("The same person (struct)"); // this will be printed because structs compare all fields
            }
            pStruct1 = pStruct2;
            pStruct1.FirstName = "Struct new name";
            Console.WriteLine(pStruct2.FirstName);
            // because it is value type we changed the FirstName only in pStruct1 so pStruct2 will keep its old value


            Console.WriteLine("END");
            Console.ReadKey();
        }
    }

    public record PersonRecord
    {
        public string FirstName { get; set; }
        public string LastName { get; init; }
    }


    public class PersonClass
    {
        public string FirstName { get; set; }
        public string LastName { get; init; }
    }


    public struct PersonStruct
    {
        public string FirstName { get; set; }
        public string LastName { get; init; }
    }
}
