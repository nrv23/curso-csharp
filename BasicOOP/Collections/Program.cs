

using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;

string text = "Hello, World!";

var customeCollection = new CustomCollection<string>(new string[] { "Hello", "from", "Custom", "Collection" });

customeCollection[0] = "usando el indexador en la primera posicion";

foreach (char c in text)
{
    Console.WriteLine(c);
}
// custoemCollection usando foreach
Console.WriteLine("\ncustoemCollection usando foreach\n");
foreach (var c in customeCollection)
{
    Console.WriteLine(c);
}

// como .net implementa IEnumerable
Console.WriteLine("\nUsando IEnumerator\n");
IEnumerator textEnumerator = text.GetEnumerator();
object currentWord;
while (textEnumerator.MoveNext()) // MoveNext retorna true se houver mais elementos o no ha llegado al final de la lista
{
    currentWord = textEnumerator.Current;
    Console.WriteLine(currentWord);
}

// copyTo

var numbers = new int[] { 1, 2, 3, 4, 5 };
var moreNumbers = new int[10];
numbers.CopyTo(moreNumbers, 2); // copia los elementos de numbers a moreNumbers a partir del indice 2 pero del array moreNumbers
// copia dentro del array pero del array que se pasa como parametro en el metodo CopyTo en este caso moreNumbers
Console.WriteLine("\nUsando CopyTo\n");

Console.WriteLine($"moreNumbers {string.Join(",", moreNumbers)}");

// lisras de solo lectura 
var planets = ReadPlanets();
// formas de convertir a una lista de solo lectura
var asReadOnlyCollection1 = planets as ReadOnlyCollection<string>;
var asReadOnlyCollection2 = (ReadOnlyCollection<string>) planets;
Console.WriteLine("\nUsando ReadOnlyCollection\n");
Console.WriteLine($"planets {string.Join(",", planets)}");

//planets[0] = "Pluton"; // Error de compilacion no se puede modificar una lista de solo lectura

//asReadOnlyCollection2[0] = "Pluton"; // Error de compilacion no se puede modificar una lista de solo lectura
IEnumerable<string> ReadPlanets()
{
    var result = new List<string> { "Mercurio", "Venus", "Tierra", "Marte", "Jupiter", "Saturno", "Urano", "Neptuno" };

    return new ReadOnlyCollection<string>(result);
}
// dicccionariosde solo lectura 
var capitals = new Dictionary<string, string>
{
    ["Mexico"] = "Ciudad de Mexico",
    ["USA"] = "Washington D.C.",
    ["Canada"] = "Ottawa"
};

var readOnlyCapitals = new ReadOnlyDictionary<string, string>(capitals);

//readOnlyCapitals[readOnlyCapitals.Keys.First()] = "New Value"; // Error de compilacion no se puede modificar una lista de solo lectura


var sortedlist = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12};


var indexOf1 = sortedlist.FindIndexInSorted<int>(1);
var indexOf2 = sortedlist.FindIndexInSorted<int>(2);
var indexOf4 = sortedlist.FindIndexInSorted<int>(4);
var indexOf5 = sortedlist.FindIndexInSorted<int>(5);
var indexOf12 = sortedlist.FindIndexInSorted<int>(12);

Console.WriteLine($"indexOf1 : {indexOf1}");
Console.WriteLine($"indexOf2 : {indexOf2}");
Console.WriteLine($"indexOf4 : {indexOf4}");
Console.WriteLine($"indexOf5: {indexOf5}");
Console.WriteLine($"indexOf12 : {indexOf12}");

// generar una lista con Enumerable.Range

var input = Enumerable.Range(1, 100_000_000); // genera una lista de 1 a 100
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

var list = new List<int>();
foreach (var item in list)
{
  list.Add(item);
}
stopwatch.Stop();

Console.WriteLine($"Time taken to create list: {stopwatch.ElapsedMilliseconds} ms");

// la forma eficiente cargar una lista es con el constructor que recibe un IEnumerable
var efficientList = new List<int>(input);

list.Clear();
list.TrimExcess(); // libera la memoria no usada por la lista
Console.ReadKey();

// agregar una lista de elementos dentro de la lista 

list.AddRange(input); // agrega una lista de elementos dentro de la lista

// eliminacion de elementos en una lista

list.Remove(12); // elimina la primera ocurrencia del elemento 12
list.RemoveRange(list.IndexOf(20), 5); // elimina 5 elementos a partir del indice del elemento 20
list.RemoveAt(list.IndexOf(30)); // elimina el elemento en el indice del elemento 30

public static class ListExtensions
{

    // con IComparable se asegura que la lista este ordenada
    public static int? FindIndexInSorted<T>(this IList<T> list, T itemToFind) where T: IComparable<T>
    {
        int leftBound = 0;
        int rightBound = list.Count - 1;

        while (leftBound <= rightBound)
        {
            int middleIndex = (leftBound + rightBound) / 2; // obtener el idnice medio
            if (itemToFind.Equals(list[middleIndex]))
            {
                return middleIndex;
            }

            else if (itemToFind.CompareTo(list[middleIndex]) < 0) // si devuelve menos 1 entonces el valor es menor 
            {
                rightBound = middleIndex - 1;
            } else  
            {
                leftBound = middleIndex + 1;
            }
       

        }

        return null;
    }

}


// implementacion de strings  
class CustomCollection<T> : IEnumerable<T>
{
    private T[] items { get; }

    public CustomCollection(T[] items)
    {
        this.items = items;
    }

    // inxador
    public T this[int index]
    {
        get => items[index]; // el valor generico del indice
        set => items[index] = value; // asignar un valor generico al indice
    }
     IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public IEnumerator<T> GetEnumerator()
    {
       return new WordsEnumerator<T>(items);
    }
};

class WordsEnumerator<T> : IEnumerator<T>
{
    private const int _InitialPosition = -1;
    private int _currentPosition { get; set; } = _InitialPosition;
    private readonly T[] words;

    public WordsEnumerator(T[] words)
    {
        this.words = words;
    }
    object IEnumerator.Current =>  Current!;
    public T Current
    {
        get
        {
            try
            {
                return words[_currentPosition];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException($"{nameof(CustomCollection<T>)}'s has reached", ex);
            }
        }
    }

    public bool MoveNext()
    {
        _currentPosition++;
        return _currentPosition < words.Length;
    }

    public void Reset()
    {
        _currentPosition = _InitialPosition;
    }

    public void Dispose()
    {
        // No resources to dispose
    }   
} 
