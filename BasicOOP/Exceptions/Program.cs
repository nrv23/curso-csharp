
string input ="Hello, World!";
int number = ParseStringToInt(input); // This will throw a FormatException


int ParseStringToInt(string str)
{
        return int.Parse(str);
    
    
}
Console.WriteLine("This line will not be executed due to the exception above.");