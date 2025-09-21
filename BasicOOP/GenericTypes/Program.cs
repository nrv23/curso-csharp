using GenericTypes.clasess;
using GenericTypes.exercises;
using GenericTypes.extensions;
using System.Diagnostics;

//var numbers = new ListOfInts();
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);

//numbers.RemoveAt(1); // elimina el elemento en el índice 1 (el número 2)

//Console.WriteLine("Count: " + numbers.Count); // muestra el tamaño actual de la lista
//Console.WriteLine($"value of index {2}: {numbers.GetAtIndex(2)} ");

//var genericList = new GenericList<string>();
//genericList.Add("Hello");
//genericList.Add("World");
//genericList.Add("from");
//genericList.Add("Generic");
//genericList.Add("List");
//genericList.RemoveAt(3); // elimina el elemento en el índice 3 (el número "Generic");

//Console.WriteLine("Count: " + genericList.Count); // muestra el tamaño actual de la lista
//Console.WriteLine($"value of index {2}: {genericList.GetAtIndex(2)} ");
//var genericListInt = new GenericList<int>();    
//genericListInt.Add(10);
//genericListInt.Add(20);
//genericListInt.Add(30);
//genericListInt.RemoveAt(0);

//Console.WriteLine("Count: " + genericListInt.Count); // muestra el tamaño actual de la lista
//Console.WriteLine($"value of index {1}: {genericListInt.GetAtIndex(1)} ");

//var pair = new Pair<int>(1, 2);
//Console.WriteLine($"First: {pair.First}, Second: {pair.Second}");
//pair.ResetFirst();
//Console.WriteLine($"First: {pair.First}, Second: {pair.Second}");

var numbers = new List<int> { 3, 5, 1, 8, -2, 7 };

var result = GetMaxAndMinNumber(numbers);
Console.WriteLine($"Max: {result.Item1}, Min: {result.Item2}, String data: {result.Item3}");

//var gemicTuple = new GenericTuple<int, string>(1, "Hello");

//Console.WriteLine($"Max: {gemicTuple.Item1}, Min: {gemicTuple.Item2}");


//var ints = new List<decimal> { 1.1m, 2.2m, 3.1m, 4.1m, 5.1m };
//ints.AddToFront<decimal>(6);

//var result = ints.ConvertTo<decimal, int>();

//Stopwatch stopwatch = Stopwatch.StartNew();
//var randomInts = CreateCollectionOfRandomLength<int>(10);
//stopwatch.Stop();
//Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
//Console.WriteLine(string.Join(" ", ints));
//Console.WriteLine();
//Console.WriteLine(string.Join(" ", randomInts));

// metodos que tienen mas de una reestricion 

void SomeMethod<TPet,TPetOwner>(TPet pet, TPetOwner petOwner)
    where TPet: Pet, IComparable<TPet>
    where TPetOwner: new ()
    // cada tipo generico tiene sus propias restricciones
{

}

Console.WriteLine(Calculator.Square<int>(5));
Console.WriteLine(Calculator.Square<decimal>(5.1m));
Console.WriteLine(Calculator.Square<double>(5.3333));
Console.WriteLine(Calculator.Square<long>(1364863473264326432));


var people = new List<Person>
{
    new Person {Name = "John", YearOfBirth = 1980},
    new Person {Name = "Anna", YearOfBirth = 1915},
    new Person {Name = "Bill", YearOfBirth = 2011},
};

var employeesDerivedFromPerson = new List<Employee>
{
    new Employee {Name = "John", YearOfBirth = 1980},
    new Employee {Name = "Anna", YearOfBirth = 1815},
    new Employee {Name = "Bill", YearOfBirth = 2150},
};

people.Sort(); // usa el CompareTo de Person
employeesDerivedFromPerson.Sort(); // usa el CompareTo de Person

PrintInOrder(5, 10);
PrintInOrder("apple", "banana");
PrintInOrder(new Person { Name = "John", YearOfBirth = 1980 }, new Person { Name = "Anna", YearOfBirth = 1915 });
// PrintInOrder(new TowInts(1,2), new TowInts(1, 1));no implementa IComparable<T>


var validPeople = GetOnlyValid<Person>(people);
var validEmployees = GetOnlyValid<Employee>(employeesDerivedFromPerson);

foreach (var employee in validEmployees)
{
    employee.GoToWork();
}

foreach (var employee in validPeople)
{
    // employee.GoToWork(); la clase Person no tiene el método GoToWork()
    Console.WriteLine($"{employee.Name} is a valid person");
}

void PrintInOrder<T>(T first, T second) where T : IComparable<T> // constraint que obliga a que T implemente IComparable<T>
{
    Console.Out.WriteLine(first.CompareTo(second) > 0
        ? $"{second}, {first}"
        : $"{first}, {second}");
}

Console.ReadKey();

IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> people) where TPerson : Person // solo se puede usar con tipos que heredan de Person
{
    var newList = new List<TPerson>();
    foreach (var person in people)
    {
        if (person.YearOfBirth > 1900 && person.YearOfBirth <= DateTime.Now.Year && !string.IsNullOrWhiteSpace(person.Name))
        {
            newList.Add(person);
        }
    }

    return newList;
}
//IEnumerable<Person> GetOnlyValid(IEnumerable<Person> people)
//{
//    var newList = new List<Person>();
//    foreach (var person in people)
//    {
//        if (person.YearOfBirth > 1900 && person.YearOfBirth <= DateTime.Now.Year && !string.IsNullOrWhiteSpace(person.Name))
//        {
//            newList.Add(person);
//        }
//    }

//    return newList;
//}

IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
    // where T : new() es un constraint que indica que T debe tener un constructor público sin parámetros
{
    int length = 100000000;//new Random().Next(maxLength + 1); // longitud aleatoria entre 1 y maxLength
    var collection = new List<T>(length); // se setea la lista con el tamaño fijo de manera que con cada iteracion 
    // la lista no tenga que redimensionarse y asi no afectar el rendimiento
    for (int i = 0; i < length; i++)
    {
        collection.Add(new T()); // agrega una nueva instancia de T a la colección
    }
    return collection;
}

GenericTuple<int, int, string> GetMaxAndMinNumber(IEnumerable<int> numbers // IEnumerable es una interfaz que representa una colección de elementos que se pueden enumerar
)
{
    if (numbers == null || numbers.Count() == 0)
    {
        throw new ArgumentException("The array must not be null or empty", nameof(numbers));
    }

    if (!numbers.Any()) // si la colección no tiene ningún elemento
    {
        throw new InvalidOperationException("The array must not be empty");
    }
    int max = numbers.First();
    int min = numbers.First();
    foreach (var number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
        if (number < min)
        {
            min = number;
        }
    }
    return new GenericTuple<int, int, string>(max, min, "Hola");
}


public class Pet { }
public class PetOwner { }