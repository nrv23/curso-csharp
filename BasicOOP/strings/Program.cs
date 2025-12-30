// See https://aka.ms/new-console-template for more information
using Strings.Exercises;
using System.Text;

Console.WriteLine("Hello, World!");

//var currentEnconding = Console.OutputEncoding; //  ver la codificación actual
Console.OutputEncoding = System.Text.Encoding.UTF8; // cambiar la codificación a UTF8

// CHAR
char letter = 'A';
char digit = '1';
char symbol = '#';
char newLine = '\n';

// metods for char
bool isLetter = char.IsLetter(letter); // true
bool isDigit = char.IsDigit(digit);   // true
bool isSymbol = char.IsSymbol(symbol); // true
char upperLetter = char.ToUpper(letter); // 'A'
char lowerLetter = char.ToLower(letter); // 'a'
var isWhiteSpace = char.IsWhiteSpace(newLine); // true

Console.WriteLine();    
// pintar en consola los resultados
Console.WriteLine($"Is '{letter}' a letter? {isLetter}");
Console.WriteLine($"Is '{digit}' a digit? {isDigit}");
Console.WriteLine($"Is '{symbol}' a symbol? {isSymbol}");
Console.WriteLine($"Uppercase of '{letter}': {upperLetter}");
Console.WriteLine($"Lowercase of '{letter}': {lowerLetter}");
Console.WriteLine($"Is new line a whitespace? {isWhiteSpace}");

// convertir char a int y viceversa
char charToInt = (char)100; // 65
int asInt = (int)letter; // 65

for(char c = 'A'; c <= 'z'; c++)
{
    Console.Write(c + ", ");
}

Console.WriteLine();

Console.WriteLine($"Character for int 100: {charToInt}");
Console.WriteLine($"Integer value of '{letter}': {asInt}");

// pintar en consola la letra omega 
char omega = 'Ω'; // letra griega omega mayúscula
int omegaAsInt = (int)omega;

// STRINGS

string text = "abc";
text += "def"; // concatenación

var upperCase = text.ToUpper();
Console.WriteLine(text);
Console.WriteLine(upperCase);

var test = new TestStruct
{
    TestString = "Hello, Struct!"
};

var other = test;

other.TestString = "Changed String";
Console.WriteLine(test.TestString);
Console.WriteLine(other.TestString);

// medir el rendimiento de la concatenación de strings usando stopwatch


const int COUNT = 200_000;
var text2 = string.Empty;

var stopwatch = System.Diagnostics.Stopwatch.StartNew();


for (int i = 0; i < COUNT; i++)
{
    text2 += "A"; // concatenación ineficiente
}
stopwatch.Stop();
Console.WriteLine($"Time taken for string concatenation: {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();

// armando strings con StringBuilder
var stringBuilder = new StringBuilder(COUNT); // capacidad inicial,opcional

for (int i = 0; i < COUNT; i++)
{
    stringBuilder.Append("A");
}
 
stopwatch.Stop();
Console.WriteLine($"Time taken for StringBuilder: {stopwatch.ElapsedMilliseconds} ms");
var text3 = stringBuilder.ToString();

Console.WriteLine(text3);


Console.WriteLine(new ReverseStringBuilder("Hello, StringBuilder!").Reverse());

Console.ReadKey();

public struct TestStruct
{
    public string TestString { get; set; }
}



