using GenericTypes.clasess;

var numbers = new ListOfInts();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);

numbers.RemoveAt(1); // elimina el elemento en el índice 1 (el número 2)

Console.WriteLine("Count: " + numbers.Count); // muestra el tamaño actual de la lista
Console.WriteLine($"value of index {2}: {numbers.GetAtIndex(2)} ");

Console.ReadKey();
