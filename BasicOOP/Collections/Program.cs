

using System.Collections;

string text = "Hello, World!";

var customeCollection = new CustomCollection(new string[] { "Hello", "from", "Custom", "Collection" });

foreach (char c in text)
{
    Console.WriteLine(c);
}
// custoemCollection usando foreach
Console.WriteLine("\ncustoemCollection usando foreach\n");
foreach (string c in customeCollection)
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

Console.ReadKey();

class CustomCollection : IEnumerable
{
    private string[] items { get; }

    public CustomCollection(string[] items)
    {
        this.items = items;
    }

    public IEnumerator GetEnumerator()
    {
       return new WordsEnumerator(items);
    }
};

class WordsEnumerator : IEnumerator
{
    private const int _InitialPosition = -1;
    private int _currentPosition { get; set; } = _InitialPosition;
    private readonly string[] words;

    public WordsEnumerator(string[] words)
    {
        this.words = words;
    }

    public object Current
    {
        get
        {
            try
            {
                return words[_currentPosition];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException($"{nameof(CustomCollection)}'s has reached", ex);
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
}
