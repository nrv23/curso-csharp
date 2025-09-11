using Exceptions.exercises;


// ExceptionsDivisionExercise.DivideNumbers(2, 2);



//try
//{

//    string input = Console.ReadLine();
//    int number = ParseStringToInt(input); // This will throw a FormatException
//    Console.WriteLine($"Is valid number. Result is {number}");
//}
//// generar varios tipos de excepciones
//catch (FormatException fex)
//{
//    Console.WriteLine($"Input string is not a sequence of digits. {fex.Message}");
//}
//catch (DivideByZeroException oex)
//{
//    Console.WriteLine($"Attempted to divide by zero. {oex.Message}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"General exception. {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Llegó al bloque FInally");
//}

//RecursiveMethod(1);

// exceptio filtering
try
{
    var dataFromWeb = SendHttpRequest("www.someAddress.com/get/someResource");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
    Console.WriteLine("It was forbidden to access the resource.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
    Console.WriteLine("The resource was not found.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message.StartsWith("4"))
{
    Console.WriteLine("Some kind of client error.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "500")
{
    Console.WriteLine("The server has experienced an internal error.");
    throw;
}

//try
//{
//  var result =  IsFirElementPositive(null);
//}
//catch(ArgumentNullException nex)
//{

//    //throw new ArgumentNullException($"Error: {nex.Message}");
//}
Console.ReadLine();
object SendHttpRequest(string url)
{
    //send the request
    return null;
}
int ParseStringToInt(string str) => int.Parse(str);


int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }
    throw new InvalidOperationException("The collection is null or empty.");
}

bool IsFirElementPositive(IEnumerable<int> numbers)
{
    try
    {
        int firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        return true;
    }
    catch(NullReferenceException nex)
    {   
        Console.WriteLine($"Unexpected Error: {nex.Message}");
        //throw nex;
        throw new ArgumentNullException($"Error: {nex.Message}");
    }
}
void RecursiveMethod(int count)
{
    if (count < 10)
    {
        RecursiveMethod(count + 1);
    }
    Console.WriteLine($"Recursion level: {count}");
    
}