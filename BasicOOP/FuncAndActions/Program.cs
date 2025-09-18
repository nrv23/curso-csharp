
using FuncAndActions.clasess;
//var numbers = new List<int> { 1, 2, 3, 11, 12, 13 };

//// usar el func para obtener si algun numero es mayor a 10

//Func<int, bool> FnIsLargerThan10 = IsLargerThanTen;
//Func<int, bool> FnIsEven = IsEven;

//Console.WriteLine($"IsLargerThanTen: {isAny(numbers, FnIsLargerThan10)}"); 
//Console.WriteLine($"IsEven: {isAny(numbers, FnIsEven)}");

//// paasar las funciones directamente como parametros 

//Console.WriteLine("---- Directly passing the functions as parameters ----");

//Console.WriteLine($"IsLargerThanTen: {isAny(numbers, IsLargerThanTen)}");
//Console.WriteLine($"IsEven: {isAny(numbers, IsEven)}");


//var countryToCurrencyMapping1 = new Dictionary<string, string>
//{
//    // iniciar la lista con algunos paises y sus monedas directo
//    { "USA", "USD" },
//    { "Canada", "CAD" },
//    { "Mexico", "MXN" },
//    { "UK", "GBP" },
//    { "France", "EUR" },
//    { "Germany", "EUR" },
//    { "Italy", "EUR" },
//    { "Spain", "EUR" },
//    { "Japan", "JPY" },
//    { "China", "CNY" }
//};

//var countryToCurrencyMapping2 = new Dictionary<string, string>();
//countryToCurrencyMapping2.Add("USA", "USD");
//countryToCurrencyMapping2.Add("Canada", "CAD");
//countryToCurrencyMapping2.Add("Mexico", "MXN");
//countryToCurrencyMapping2.Add("UK", "GBP");
//// obtener un valor de un diccionario usando GetValueOrDefault
//Console.WriteLine($"USD Currency {countryToCurrencyMapping2.GetValueOrDefault<string, string>("Canada")}");
//// usando indexador
//Console.WriteLine($"China Currency {countryToCurrencyMapping2["UK"]}");
//// asignar un valor a un diccionario usando el indexador
//countryToCurrencyMapping2["Germany"] = "GER";
//Console.WriteLine($"Germany Currency {countryToCurrencyMapping2["Germany"]}");

//Console.WriteLine(System.Text.Json.JsonSerializer.Serialize<Dictionary<string, string>>(countryToCurrencyMapping2));

////Console.WriteLine($"valor no encontrado {countryToCurrencyMapping2["CRC"]}"); 
//// si el key no existe lanza una excepcion si se lee desde el indexador

//Console.WriteLine($"valor no encontrado {countryToCurrencyMapping2.GetValueOrDefault<string, string>("CRC") is null}");
//// si se usa GetValueOrDefault y el key no existe, devuelve null

//// usando elmetodo containsKey
//Console.WriteLine($"La llave CRC existe? {countryToCurrencyMapping2.ContainsKey("CRC")}");

//// imprimir todas las llaves y valores del diccionario 
//foreach (var kvp in countryToCurrencyMapping2)
//{
//    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//}
//Console.ReadKey();
//bool isAny(IEnumerable<int> numbers, Func<int, bool> predicate)
//{
//    foreach (var number in numbers)
//    {
//        if (predicate(number)) // aqui es donde el func hace su magia, el predicate es una funcion que recibe como parametro un int y devuelve un bool
//        {
//            return true;
//        }
//    }
//    return false;
//}

var numbers = new List<int> { 1, 2, 3, 11, 12, 13, 9,75,99, -9,-4,-5 };
var filter = new Filter();
var filteringType = ReadUserInput();
var predicate = FilteringStratgeySelector.GetFilteringStrategy(filteringType);
var filteredNumbers = filter.FilterElements<int>(numbers, predicate);
PrintNumbers(filteredNumbers);

string ReadUserInput()
{
       Console.WriteLine($"Enter a filtering type ({string.Join(Environment.NewLine,new FilteringStratgeySelector().FilteringStrategiesNames)}):");
       return Console.ReadLine() ?? string.Empty;
}


void PrintNumbers(IEnumerable<int> numbers)
{
    Console.WriteLine($"Numbers: {string.Join(",", numbers)}");
}




var pets = new List<Pet>
{
    // Dogs
    new Pet(PetType.Dog, 12),
    new Pet(PetType.Dog, 22),
    new Pet(PetType.Dog, 45),
    new Pet(PetType.Dog, 33),

    // Cats
    new Pet(PetType.Cat, 5),
    new Pet(PetType.Cat, 2),
    new Pet(PetType.Cat, 7),
    new Pet(PetType.Cat, 3.5),

    // Fish
    new Pet(PetType.Fish, 0.02),
    new Pet(PetType.Fish, 0.5),
    new Pet(PetType.Fish, 0.9),
    new Pet(PetType.Fish, 0.3)
};


var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500 ),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Nisha Patel", "Machanics", 21000),
    new Employee("Gustavo Sanchez", "Machanics", 20000),
};
Console.WriteLine($"Average salary per department:{System.Text.Json.JsonSerializer.Serialize(CalculateAverageSalaryPerDeparment(employees))}");


//System.Text.Json.JsonSerializer.Serialize(
Console.WriteLine($"Max weight per pet type: {System.Text.Json.JsonSerializer.Serialize(Pet.FindMaxWeights(pets))}");
Console.ReadKey();

Dictionary<string, decimal>? CalculateAverageSalaryPerDeparment(IEnumerable<Employee> employes)
{
    var employeesPerDepartment = new Dictionary<string, List<Employee>>();

    foreach(var employee in employes)
    {
        if(!employeesPerDepartment.ContainsKey(employee.Department))
        {
            employeesPerDepartment[employee.Department] = new List<Employee>(); // lista vacia 
        }

        employeesPerDepartment[employee.Department].Add(employee);
    }

    var averageSalaryPerDepartment = new Dictionary<string, decimal>();

    foreach(var department in employeesPerDepartment) // este diccionario tiene como key el nombre del departamento y como value la lista de empleados de ese departamento
    {
        decimal sumOfSalaries = 0;

        foreach(var dataEmployee in department.Value) // employee.Value es la lista de empleados de ese departamento
        {
            sumOfSalaries += dataEmployee.MontlhySalary;
        }

        var averageSalary = sumOfSalaries / department.Value.Count;
        // asignar de dos formas
        //averageSalaryPerDepartment.Add(department.Key, averageSalary); // employee.Key es el nombre del departamento
        averageSalaryPerDepartment[department.Key] = averageSalary;
    }

    return averageSalaryPerDepartment;
}

bool IsLargerThanTen(int number) => number > 10;
bool IsEven(int number) => number % 2 == 0;