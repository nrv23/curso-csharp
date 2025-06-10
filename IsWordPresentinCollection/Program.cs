// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
{
    bool result = false;
    for (int i = 0; i < words.Length; i++)
    {

        if (words[i] != wordToBeChecked) continue;
        result = true;
        break;
    }

    return result;
}

//###################
char[,] letters = new char[2, 3];
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';


var letters2 = new char[,]
{
    {'A', 'B','C' },
    {'D', 'E','F' },
};

var height = letters.GetLength(0); // obtiene el tamaño de un array dependiendo de la dimension
var width = letters.GetLength(1);

Console.WriteLine($"height {height}");
Console.WriteLine($"width {width}");

for (int i = 0; i < height; i++)
{
    Console.WriteLine($"i is {i}");
    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"j is {j}");
        Console.WriteLine(
            $"element is {letters[i, j]}");
    }
}


//###################
//Foreach loop
//###################
var words = new string[] { "23", "23", "23" };
foreach (var word in words)
{
    Console.WriteLine(word);
}


bool IsAnyWordLongerThan(int length, string[] words)
{
    bool result = false;

    foreach (var word in words)
    {
        if(word.Length > length) result = true;
        continue;
    }

    return result;
}


Console.WriteLine($"IsAnyWordLongerThan {IsAnyWordLongerThan(2, words)}");

Console.ReadKey();