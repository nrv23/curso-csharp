using GenericTypes.clasess;
using GenericTypes.exercises;

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

var gemicTuple = new GenericTuple<int, string>(1, "Hello");

Console.WriteLine($"Max: {gemicTuple.Item1}, Min: {gemicTuple.Item2}");
GenericTuple<int,int,string> GetMaxAndMinNumber(IEnumerable<int> numbers // IEnumerable es una interfaz que representa una colección de elementos que se pueden enumerar
)
{
    if (numbers == null || numbers.Count() == 0)
    {
        throw new ArgumentException("The array must not be null or empty", nameof(numbers));
    }

    if(!numbers.Any()) // si la colección no tiene ningún elemento
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
    return new GenericTuple<int,int,string>(max, min,"Hola");
}

Console.ReadKey();
