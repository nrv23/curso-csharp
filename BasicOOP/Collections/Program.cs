

using System.Collections;

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
    
Console.ReadKey();

// implementacion generica 



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
