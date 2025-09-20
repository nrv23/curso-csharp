using LINQ;
using LINQ.clasess;
using LINQ.examples;
using System.Collections.Generic;


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


//var words2 = new List<string> { "he", "WORLD", "LI", "cSharp", "JAVA", "python" };
//var words3 = new List<string>();
//var shortWords = words2.Where(word => word.Length < 3);
//words2.Add("AS");
//Console.WriteLine($"shortWords list {string.Join(",", shortWords)}");
//Console.WriteLine("First iteration of shortWords:");
//foreach (var word in shortWords) {
//    Console.WriteLine(word);
//}
//words2.Add("hi");
//words3 = words2;
//Console.WriteLine("Second iteration of shortWords after adding 'hi':");

//foreach (var word in shortWords)
//{
//    Console.WriteLine(word);
//}

//words2.Add("sis");
//words3 = words2;

//Console.WriteLine("Second iteration of shortWords after adding 'si':");
//foreach (var word in shortWords)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine($"original list {string.Join(",", words2)}");
//Console.WriteLine($"words3 list {string.Join(",", words3)}");


//// var peoples = new List<(string Name, int Age)> { declarar una interfaz anonima como se haria en Js

//var people = new List<Person> {
//    new Person { Name = "Alice", Country = "USA" },
//    new Person { Name = "Bob", Country = "UK" },
//    new Person { Name = "Charlie", Country = "Canada" },
//    new Person { Name = "David", Country = "Australia" },
//    new Person { Name = "Eve", Country = "France" }
//};
//// sino se usa un metodo de materializacion como ToList, ToArray, etc no se ejuta la consulta
//var allAmericans = people.Where(p => p.Country == "USA");
//var notAllAmericans = people.Take(100);

//var animals = new List<string> { "cat", "dog", "elephant", "tiger", "lion", "zebra" };
////var animalsWithA = animals.Where(a => a.StartsWith('a')); 
//var animalsWithA = animals.Where(a =>
//{   
//    Console.WriteLine($"Evaluating: {a}"); // para ver cuando se ejecuta la consulta
//    return a.StartsWith('d');
//});
//// la consulta se ejecuta aqui sino se usa un metodo de materializacion como ToList, ToArray, etc
//foreach (var animal in animalsWithA)
//{
//    Console.WriteLine($" animal : {animal}");
//}   

var numbers = new List<int> { 1, 2, 3, 11, 12, 13, 9, 75, 99, -9, -4, -5 };
var words1 = new List<string> { "hello", "world", "    ", "LINQ", "cSharp", "JAVA", "python" };
var numbersLargerThan10 = new Any().IsLargerThan10(numbers);

Console.WriteLine($"Are there any numbers larger than 10? {numbersLargerThan10}");

var petList = new[]
{
    new Pet(1, "Hannibal", PetType.Fish, 1.1f),
    new Pet(2, "Anthony", PetType.Cat, 2f),
    new Pet(3, "Ed", PetType.Cat, 0.7f),
    new Pet(4, "Taiga", PetType.Dog, 35f),
    new Pet(5, "Rex", PetType.Dog, 40f),
    new Pet(6, "Lucky", PetType.Dog, 5f),
    new Pet(7, "Storm", PetType.Cat, 0.9f),
    new Pet(8, "Nyan", PetType.Cat, 2.2f)
};

var isAnyPetWithNameEd = new Any().IsAnyPetWithNameEd<Pet>(petList);

Console.WriteLine($"Is there any pet with the name 'Ed'? {isAnyPetWithNameEd}");

var isAnyFishInCollection = new Any().IsAnyFishInCollection(petList);

Console.WriteLine($"Is there any fish in the collection? {isAnyFishInCollection}");

var isVerySpecificPet = new Any().IsVerySpecificPet(petList);

Console.WriteLine($"Is there any pet with a name longer than 6 characters and an even ID? {isVerySpecificPet}");

// validar con ANy si la coleccion no está vacia

var isCollectionAny = new Any().IsCollectionNotEmpty(petList);

Console.WriteLine($"Is the pet collection not empty? {isCollectionAny}");

var isAllNumbersLargerThan10 = new All().AreAllNumbersLargerThan10<Pet>(petList);    

Console.WriteLine($"Are all numbers larger than 10? {isAllNumbersLargerThan10}");

var isAllNumbersLargerThan0 = new All().AreAllNumbersLargerThan0<Pet>(petList);

Console.WriteLine($"Are all numbers larger than 0? {isAllNumbersLargerThan0}");

var areAllPetsCats = new All().AreAllPetsCats<Pet>(petList);

Console.WriteLine($"Are all pets cats? {areAllPetsCats}");

var isAllPetsHasNotEmptyNames = new All().IsAllPetsHasNotEmptyNames<Pet>(petList);

Console.WriteLine($"Is All Pets has Not Empty Names? {isAllPetsHasNotEmptyNames}");

var IsAnyWordWhiteSpace = new Any().IsAnyWordWhiteSpace(words1);
Console.WriteLine($"Is Any Word White Space? {IsAnyWordWhiteSpace}");


var countOfDogs = new Count().CountOfDogsInCollection<Pet>(petList);

Console.WriteLine($"How many dogs in collection {countOfDogs}");

var CountOfPetsWithIdLongerThan5 = new Count().CountOfPetsWithIdLongerThan5<Pet>(petList);

Console.WriteLine($"CountOfPetsWithIdLongerThan5 {CountOfPetsWithIdLongerThan5}");

var countOfAllSmallDogs = new Count().CountOfAllSmallDogs<Pet>(petList);

Console.WriteLine($"countOfAllSmallDogs {countOfAllSmallDogs}");

var itContains = new Contains().ItContains<int>(numbers, 2);

Console.WriteLine($"it contains 2 {itContains}");

var itContains2 = new Contains().ItContains<string>(words1, "hello");

Console.WriteLine($"it contains hello {itContains2}");

List<List<int>> list = new List<List<int>>()
{
    new List<int>() { 1, 2, 4, 5, 6,0 },
    new List<int>() { 1, 1, 1, 1, 2,1 },
    new List<int>() { 1, 2, 4, 5, 6,2 },
    new List<int>() { 1, 2, 4, 5, 6,1 }
};

var CountListsContainingZeroLongerThan = new Count().CountListsContainingZeroLongerThan(7, list);

Console.WriteLine($"{nameof(CountListsContainingZeroLongerThan)}: {CountListsContainingZeroLongerThan}");

var collecionOrderedByName = new OrderBy().Order(petList);

OrderBy.ToString(collecionOrderedByName);

var orderDescendingOrAscending = new OrderBy().OrderDescendingOrAscending(petList, 0);

OrderBy.ToString(orderDescendingOrAscending);

Console.WriteLine(string.Join(",", numbers.OrderBy(n => n)));

Console.WriteLine();

var OrderDescendingAndThen = (IEnumerable<Pet>) petList.OrderByDescending(p => p.PetType).ThenBy(pt => pt.Name);

Console.WriteLine($"{nameof(OrderDescendingAndThen)}");
OrderBy.ToString(OrderDescendingAndThen);


var firstElement = new First().GetFirstElement<int>(numbers, null);

Console.WriteLine($"{nameof(firstElement)}  {firstElement}");

var firstOddNumber = new First().GetFirstElement(numbers, n => n % 2 != 0);

Console.WriteLine($"{nameof(firstOddNumber)}  {firstOddNumber}");


var lastElement = new Last().GetLastElement(words1, null);

Console.WriteLine($"Last element in collection {nameof(words1)} is {lastElement}");

var lastElementWithContainsP = new Last().GetLastElement<string>(words1, w => w.Contains("p"));

Console.WriteLine($"{nameof(lastElementWithContainsP)} {lastElementWithContainsP} ");

var lastDogInPets = new Last().GetLastElement<Pet>(petList, p => p.PetType == PetType.Dog);

Console.WriteLine($" lastDogInPets:  {lastDogInPets} ");

var firstOrdefault = new First().GetFirstElementDefault<int>(new List<int>() { }, null);

Console.WriteLine($"{nameof(firstOrdefault)} {firstOrdefault}");

var firstOrdefaultString = new First().GetFirstElementDefault<string>(new List<string>() { }, null);

Console.WriteLine($"{nameof(firstOrdefaultString)} {firstOrdefaultString}");

var heaviestPet1 = petList.OrderByDescending(p => p.Weight).First();
var heaviestPet2 = petList.OrderBy(p => p.Weight).Last();

Console.WriteLine($"{nameof(heaviestPet1)} {heaviestPet1}");
Console.WriteLine($"{nameof(heaviestPet2)} {heaviestPet2}");

Console.ReadKey();

bool IsAllUpper(IEnumerable<string> words)
{

    //return words.Any(word => word.All(w => char.IsUpper(w)));
    return words.Any(word => word.All(char.IsUpper)); // version simplificada, en Js es como usar 
    // una funcion console.log en una funcion que retorna una promesa y quiero pintar lo que devuevl promesa
    // promise.then(console.log) 
}

