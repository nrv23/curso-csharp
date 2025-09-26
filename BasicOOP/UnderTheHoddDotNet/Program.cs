using UnderTheHoddDotNet.clasess;

// value type
int number = 5;
//int anotherNumber = number;
//anotherNumber++;

//Console.WriteLine($"number: {number}, anotherNumber: {anotherNumber}");

// reference type



var person = new Person { Name = "John", Age = 20 };
//var anotherPerson = person;
//anotherPerson.Name = "Jane";
//Console.WriteLine($"person: {person.Name}, anotherPerson: {anotherPerson.Name}");

// Passing value type to method
AddOneToNumber(number);
Console.WriteLine($"number after method call: {number}");

// Passing reference type to method

HaveBirthday(person);

Console.WriteLine($"person after birthday: {person.Name}, Age: {person.Age}");

const string path = "test.txt";

// forma legacy de usar using

using (var listString = new AllLinesFromTextFileReader(path))
{
    var lines = listString.ReadAllLines();
    Console.WriteLine("lines" + string.Join(",", lines));
}

using (var fileWriter = new FileWriter(path))
{
    fileWriter.Write("test1");
    fileWriter.Write("test2");
    fileWriter.Write("test3");
    fileWriter.Write("test4");
}
//fileWriter.Dispose();
// forma moderna de usar using
using var reader = new SpecificLineFromTextFileReader(path);
Console.WriteLine(reader.ReadLineNumber(3));
Console.WriteLine(reader.ReadLineNumber(4));

//reader.Dispose();
void AddOneToNumber(int num)
{
    num++;
}
;

void HaveBirthday(Person p)
{
    p.Age++;
}

Console.ReadKey();

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

