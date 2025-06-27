using Calculator.clasess;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var calculator = new Calculate();

Console.WriteLine("Sum: " + Calculate.Sum(5, 3));
Console.WriteLine("Subtract: " + Calculate.Subtract(5, 3));
Console.WriteLine("Multiply: " + Calculate.Multiply(5, 3));
Console.WriteLine("Divide: " + Calculate.Divide(5, 3));
 
Console.WriteLine("Press any key to exit...");
Console.ReadKey();