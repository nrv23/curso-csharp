using Exceptions.exercises;


 ExceptionsDivisionExercise.DivideNumbers(2, 2);

Console.WriteLine($"Result is {result}");

try
{

    string input = Console.ReadLine();
    int number = ParseStringToInt(input); // This will throw a FormatException
    Console.WriteLine($"Is valid number. Result is {number}");
}
// generar varios tipos de excepciones
catch (FormatException fex)
{
    Console.WriteLine($"Input string is not a sequence of digits. {fex.Message}");
}
catch (DivideByZeroException oex)
{
    Console.WriteLine($"Attempted to divide by zero. {oex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"General exception. {ex.Message}");
}
finally
{
    Console.WriteLine("Llegó al bloque FInally");
}


Console.ReadLine();

int ParseStringToInt(string str) => int.Parse(str);


int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The collection is null or empty.");
}