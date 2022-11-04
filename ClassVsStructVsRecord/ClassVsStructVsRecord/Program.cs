// See https://aka.ms/new-console-template for more information
using ClassVsStructVsRecord;
using System;


// Benefits of using records

var personAsClass = new PersonAsClass("Jacek as Class", new DateOnly(2000, 12, 13));
var personAsClass2 = new PersonAsClass("Jacek as Class", new DateOnly(2000, 12, 13));
var personAsRecordClass = new PersonAsRecordClass("Jacek as Record Class", new DateOnly(2000, 12, 13));
var personAsRecordClass2 = new PersonAsRecordClass("Jacek as Record Class", new DateOnly(2000, 12, 13));

var personAsStruct = new PersonAsStruct("Jacek as Strcut", new DateOnly(2000, 12, 13));
var personAsStruct2 = new PersonAsStruct("Jacek as Strcut", new DateOnly(2000, 12, 13));
var personAsRecordStruct = new PersonAsRecordStruct("Jacek as Record Struct", new DateOnly(2000, 12, 13));
var personAsRecordStruct2 = new PersonAsRecordStruct("Jacek as Record Struct", new DateOnly(2000, 12, 13));

// 1. Records by default prints type name with fields and their values
Console.WriteLine("---Default ToString() to the console---");

Console.WriteLine(personAsClass);           // prints: ClassVsStructVsRecord.PersonAsClass
Console.WriteLine(personAsRecordClass);     // prints: PersonAsRecordClass { FullName = Jacek as Record Class, DateOfBirth = 12/13/2000 }

Console.WriteLine(personAsStruct);          // prints: ClassVsStructVsRecord.PersonAsStruct
Console.WriteLine(personAsRecordStruct);    // prints: PersonAsRecordStruct { FullName = Jacek as Record Struct, DateOfBirth = 12/13/2000 }

// 2. Equality - records (both struct and class) are equal if all fields have the same value
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---Equality---");
Console.WriteLine($"personAsClass == personAsClass2: {personAsClass == personAsClass2}"); // False (classes are equal if the have the same reference)
Console.WriteLine($"personAsRecordClass == personAsRecordClass2: {personAsRecordClass == personAsRecordClass2}"); // True (record class is the same if all fields have the same value)

//  Console.WriteLine($"personAsStruct == personAsStruct2: {personAsStruct == personAsStruct2}"); // error: Operator '==' cannot be applied to operands of type 'PersonAsStruct' and 'PersonAsStruct'
Console.WriteLine($"personAsStruct == personAsStruct2: {personAsStruct.Equals(personAsStruct2)}");  // True (struct is the same if all fields have the same value)

Console.WriteLine($"personAsRecordStruct == personAsRecordStruct: {personAsRecordStruct == personAsRecordStruct2}");    // True (record struct is the same if all fields have the same value)
Console.WriteLine($"personAsRecordStruct.Equals(personAsRecordStruct2): {personAsRecordStruct.Equals(personAsRecordStruct2)}"); // True (record struct is the same if all fields have the same value)


// 3. record can be defined using short form: internal record class PersonAsRecordClass (string FullName, DateOnly DateOfBirth);
//    but this is not supported for classes


// 4. Records but default are immutable but we can use 'with' operator to clone it.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---with operator and object duplication---");

// operator 'with' can be used to easily duplicate objects
var personAsRecordClassOlderGuy = personAsRecordClass with { DateOfBirth = new DateOnly(1901, 12, 1) };
// 'with' operator created protected constructor in the record which is used to set the fields, if we create such constructor then we can debug it
Console.WriteLine($"personAsRecordClassOlderGuy: {personAsRecordClassOlderGuy}");

// 5. de-construct
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---de-construct---");
//var (name, dateOfBirth) = personAsClass;          // deconstruct does not work for class
//var (name, dateOfBirth) = personAsStruct;         // deconstruct does not work for struct
var (name1, dateOfBirth1) = personAsRecordClass;
var (name2, dateOfBirth2) = personAsRecordStruct;

Console.WriteLine($"name1: {name1}, dateOfBirth1: {dateOfBirth1}");
Console.WriteLine($"name2: {name2}, dateOfBirth2: {dateOfBirth2}");

// 6. records supports inheritance

// 7. https://sharplab.io/ - page where you can see how for example records are converted to the actually executed c# code

Console.ReadKey();

