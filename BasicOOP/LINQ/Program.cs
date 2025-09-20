


// funcion para saber si en una lista de palabra hay al menos una que sea toda mayuscula

//Console.WriteLine("---- Any with strings ----");
//var words = new List<string> { "hello", "WORLD", "LINQ", "cSharp", "JAVA", "python" };
//var numbers = new List<int> { 1, 2, 3, 11, 12, 13, 9, 75, 99, -9, -4, -5 };
//var wordsLongerThan3 = words.Where(word => word.Length > 3);
//var wordsLongerThan3Any = words.Any(word => word.Length > 3);// Any retorna bool

//var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
//var anyOddNumbers = numbers.Any(n => n % 2 != 0); // Any retorna bool

//Console.WriteLine($"Are there any words longer than 3 characters? {wordsLongerThan3Any}");
//Console.WriteLine($"Words longer than 3 characters: {wordsLongerThan3}");

//Console.WriteLine($"Is there any word that is all upper case? {IsAllUpper(words)}");
//Console.WriteLine($"Odd numbers: {string.Join(", ", oddNumbers)}");
using LINQ;

var words2 = new List<string> { "he", "WORLD", "LI", "cSharp", "JAVA", "python" };
var words3 = new List<string>();
var shortWords = words2.Where(word => word.Length < 3);
words2.Add("AS");
Console.WriteLine($"shortWords list {string.Join(",", shortWords)}");
Console.WriteLine("First iteration of shortWords:");
foreach (var word in shortWords) {
    Console.WriteLine(word);
}
words2.Add("hi");
words3 = words2;
Console.WriteLine("Second iteration of shortWords after adding 'hi':");

foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

words2.Add("sis");
words3 = words2;

Console.WriteLine("Second iteration of shortWords after adding 'si':");
foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

Console.WriteLine($"original list {string.Join(",", words2)}");
Console.WriteLine($"words3 list {string.Join(",", words3)}");


// var peoples = new List<(string Name, int Age)> { declarar una interfaz anonima como se haria en Js

var people = new List<Person> {
    new Person { Name = "Alice", Country = "USA" },
    new Person { Name = "Bob", Country = "UK" },
    new Person { Name = "Charlie", Country = "Canada" },
    new Person { Name = "David", Country = "Australia" },
    new Person { Name = "Eve", Country = "France" }
};
// sino se usa un metodo de materializacion como ToList, ToArray, etc no se ejuta la consulta
var allAmericans = people.Where(p => p.Country == "USA");
var notAllAmericans = people.Take(100);

var animals = new List<string> { "cat", "dog", "elephant", "tiger", "lion", "zebra" };
//var animalsWithA = animals.Where(a => a.StartsWith('a')); 
var animalsWithA = animals.Where(a =>
{   
    Console.WriteLine($"Evaluating: {a}"); // para ver cuando se ejecuta la consulta
    return a.StartsWith('d');
});
// la consulta se ejecuta aqui sino se usa un metodo de materializacion como ToList, ToArray, etc
foreach (var animal in animalsWithA)
{
    Console.WriteLine($" animal : {animal}");
}   

Console.ReadKey();

bool IsAllUpper(IEnumerable<string> words) {

    //return words.Any(word => word.All(w => char.IsUpper(w)));
    return words.Any(word => word.All(char.IsUpper)); // version simplificada, en Js es como usar 
    // una funcion console.log en una funcion que retorna una promesa y quiero pintar lo que devuevl promesa
    // promise.then(console.log) 
}

