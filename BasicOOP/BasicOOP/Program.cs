
using BasicOOP.clasess;
using BasicOOP.exercises;

var internationPizzaDay23 = new DateTime(2023, 9, 2,12,34,11);   

Console.WriteLine($"International Pizza Day 2023: {internationPizzaDay23}");

Console.WriteLine($" dia de la semana {internationPizzaDay23.DayOfWeek}");

// agregar un dia  a la fecha actual 

var internationPizzaDay23Plus1 = internationPizzaDay23.AddYears(1);

Console.WriteLine($"International Pizza Day 2024: {internationPizzaDay23Plus1}");

var rectangle = new Rectangle(6, 20);
var calculator = new ShapesMeasurementsCalcultator();
var person = new Person
{
    Name = "John Doe",
    YearOfBirth = 1990
};
person.Name = "Jane Doe"; // Using property to set name
//person.YearOfBirth = 1985; // Using init-only property to set year of birth
rectangle.Width = -1; // Using property to set width
//rectangle.Height = -1; // Using property to set width

Console.WriteLine($"Rectangle created with width: {rectangle.Width} and height: {rectangle.Height}");

Console.WriteLine($"Area: {calculator.CalculateArea(rectangle)}");

Console.WriteLine($"Circumference: {calculator.CalculateCircumference(rectangle)}");

Console.ReadKey();