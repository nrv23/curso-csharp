////See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

string userInput = "A";
Console.WriteLine(userInput);



//userInput = "ABC";
//Console.WriteLine(userInput);

//int nummber;
// Console.WriteLine(nummber); // error de compilacion por variable sin valor definido
//nummber = 9;

//Console.WriteLine(nummber);

// multiples variables en una sola linea

//int a = 1, b = 2, c = 3;
//string s, t, u;

// nombrar variables 

//string fullName = "John Smith";
//Console.WriteLine(fullName);

//fullName = "Anna Smith";
//Console.WriteLine(fullName);

// operadores 

//int n = 15, l = 9;

//Console.WriteLine("BASIC OPERATIONS");


//Console.WriteLine($"ADD {n + l}");
//Console.WriteLine($"SUB {n - l}");
//Console.WriteLine($"MULT {n * l}");
//Console.WriteLine($"DIV {n / l}");

// valor implicito en las variables 

// declaracion de tipo de dato explicito
string word = "ABC";
int number = 20;

//declaracion de tipo de dato implicito, funciona igual que en typescript
var word1 = "ABC";
var number1 = 0;
//int someNumber = 8; // generar un error de scope global
// lectura de datos por consola
string userChoice = Console.ReadLine();
Console.WriteLine($"user input: {userChoice}");

//valores booleanos

bool someBoolean = true;
var someOtherBoolean = false;

bool isUserInputAbc = userChoice == "ABC";
bool isUserInputNotAbc = userChoice != "ABC";
bool isUserInputNotAbc2 = !(userChoice == "ABC");

Console.WriteLine($"isUserInputAbc {isUserInputAbc}");
Console.WriteLine($"isUserInputNotAbc {isUserInputNotAbc}");
Console.WriteLine($"isUserInputNotAbc2 {isUserInputNotAbc2}");

var isLargerThan5 = number > 5;
var isSmallerThan10 = number < 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;

Console.WriteLine($"isLargerThan5 {isLargerThan5}");
Console.WriteLine($"isSmallerThan10 {isSmallerThan10}");
Console.WriteLine($"isLargerOrEqualTo10 {isLargerOrEqualTo10}");
Console.WriteLine($"isSmallerOrEqualTo6 {isSmallerOrEqualTo6}");

var is10Module3EqualTo1 = 10 % 3 == 1;

Console.WriteLine($"is10Module3EqualTo1 {is10Module3EqualTo1}");

// operadores AND y OR


//comparison and modulo operators
//###################
var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6 = number == 2 || number > 6;
var isEqualTo2OrLargerThan6OrSmallerThan200 =
    number == 2 || number > 6 || number < 200;
var isEqualto123OrEvenAndSmallerThan20 =
    number == 123 || (number % 2 == 0 && number < 20);
var isLargerThan5OrSmallerThan0 = number > 5 || number < 5; //the second conditin will not be evaluated due to short-circuiting
var isSmallerThanZeroAndEven = number < 0 && number % 2 == 0; //the second conditin will not be evaluated due to short-circuiting




//###################
//if/else statements
//###################
if (userChoice.Length <= 3)
{
    Console.WriteLine("Short answer");
}
else if (userChoice.Length < 10)
{
    Console.WriteLine("Medium answer");
}
else
{
    Console.WriteLine("Long answer");
}



//###################
//Scopes
//###################
if (userChoice.Length == 0)
{ // scope local
    Console.WriteLine("Empty choice");
    var word2 = "ABC";
    int someNumber = 5;
    if (word2.Length > 0)
    {
        Console.WriteLine(someNumber); //someNumber is available here
    }
}
else
{// scope local
    int someNumber = 6; //named the same as the variable inside the "if". It is fine, because those variables live in different scopes
    Console.WriteLine("Your choice is: " + userInput);
    Console.WriteLine(someNumber); //will not compile; someNumber is not available here
}
Console.WriteLine("Your choice is: " + userInput);




//###################
//Methods - part 1 - void methods
//###################
//See 1_TodoList project for more about methods
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

//###################
//Methods - part 2 - non-void methods
//###################
//See 1_TodoList project for more about methods
int Add(int a, int b)
{
    return a + b;
}

bool IsLong(string input)
{
    return input.Length > 10;
}


//###################
//Parsing a string to an int
//###################
string numberAsText = "123";
bool randomNumber = int.TryParse(numberAsText, out int result);


//while loop

int count = 0;
while (count < 10)

{
    Console.WriteLine($"count {count}");
    count++;
}
string word3 = "";

while (word3.Length < 15)
{

    Console.WriteLine("Ingrese una palabra ");
    word3 = Console.ReadLine();
}

string userInputString;


do
{
    Console.WriteLine("Ingrese una palabra2");
    userInputString = Console.ReadLine();

} while (userInputString.Length <= 10);



Console.ReadKey();


string RepeatCharacter(char character, int targetLength)
{
    string result = "";

    if (targetLength < 1) return Convert.ToString(character);
    do
    {
        result += character;
    } while (result.Length < targetLength);

    return result;
}


//###################
//For loop
//###################
for (int i = 0; i < 5; ++i)
{
    Console.WriteLine("Loop run " + i);
}
for (int i = 10; i >= 5; --i)
{
    Console.WriteLine("Loop run " + i);
}
Console.WriteLine("The loop is finished");


//###################
//Break and continue
//###################
for (int i = 0; i < 100; ++i)
{
    if (i > 25)
    {
        break;
    }
    //Console.WriteLine("Loop run " + i);
}

int userNumber;
do
{
    Console.WriteLine(
        "Enter a number larger than 10.");
    var input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }
    bool isParsableToInt = input.All(char.IsDigit);
    if (!isParsableToInt)
    {
        userNumber = 0;
        continue;
    }
    userNumber = int.Parse(input);
} while (userNumber <= 10);

for (int i = 0; i < 20; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Pasa a la siguiente iteración");
        continue;
    }
    Console.WriteLine("Completó la iteración");
}


//###################
//Nested loops
//###################
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(
            $"i is {i}, j is {j}");
    }
}





//###################
//Arrays
//###################
var numbers = new int[] { 1, 2, 4, 7, 2 };
numbers[2] = 10;
var firstFromEnd1 = numbers[numbers.Length - 1];
var firstFromEnd2 = numbers[^1];
var secondFromEnd1 = numbers[numbers.Length - 2];
var secondFromEnd2 = numbers[^2];

int sumOfNumbers = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sumOfNumbers += numbers[i];
}



//###################
//Multi-dimensional arrays
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
var words = new string[] { "one", "two", "three" };
foreach (var word12 in words)
{
    Console.WriteLine(word12);
}


Console.WriteLine(RepeatCharacter('a', 4));




//###################
//Lists
//###################
var someWords = new List<string>
{
    "one", "two"
};
someWords.Add("three");
someWords.AddRange(new[] { "four", "five" });
someWords.Remove("three");
someWords.RemoveAt(0);
var indexOfFive = someWords.IndexOf("five");
bool containsOne = someWords.Contains("one");
someWords.Clear();



//###################
//Out parameter
//###################
var variousNumbers = new int[] { 10, -8, 2, 12, -17 };
int countOfNonPositiveNumbers;
var onlyPositive = GetOnlyPositive(
    numbers, out countOfNonPositiveNumbers);

List<int> GetOnlyPositive(
    int[] numbers, out int countOfNonPositive)
{
    var result = new List<int>();
    countOfNonPositive = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            ++countOfNonPositive;
        }
    }
    return result;
}

Console.ReadKey();