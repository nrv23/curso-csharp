


using System.Text.Json;
using AdvancedOOP.Extensions;
using AdvancedOOP.Exercises;
using AdvancedOOP.Examples;

var numberTransform = NumberTransformation.Transform(4);


var person = new Person
{
    FirstName = "Jose",
    LastName = "Perez",
    YearOfBirth = 1990
};

var asJson = JsonSerializer.Serialize(person);

var personaJson = "{\"FirstName\":\"Jose\",\"LastName\":\"Perez\",\"YearOfBirth\":1990}";
var personFromJson = JsonSerializer.Deserialize<Person>(personaJson);
Console.WriteLine($"As JSOn {asJson}");
Console.WriteLine($"is instance of person {personFromJson is Person}");
Console.WriteLine($"First Name {personFromJson?.FirstName}");

//var pizza = new Pizza();
//pizza.addIngredient(new Cheddar(1,1));
//pizza.addIngredient(new TomatoSauce(1));
//pizza.addIngredient(new Mozzarella(1));

//Console.WriteLine(pizza.number);
//Console.WriteLine(pizza.date); 
//Console.WriteLine(pizza.ingredients is null );

//Console.WriteLine(pizza.Describe());

//// aplicando herencia  

//var cheddar = new Cheddar();

//var igredients = new  Cheddar();

//cheddar.Methods();
//cheddar.PublicField = 1;

//Console.WriteLine($"Cheddar public field: {cheddar.PublicField}");
//Console.WriteLine($"Cheddar name: {cheddar.Name}");
//Console.WriteLine("Ingredient Name: " + igredients.Name);

//var ingredientsList = new List<Ingredients>
//{
//    new Cheddar(),
//    new TomatoSauce(),
//    new Mozzarella()
//};

//foreach (var ingredient in ingredientsList)
//{
//    Console.WriteLine($"Ingredient: {ingredient.Name}");
//}

// var ingredient = new Ingredients(1);
// var cheddar = new Cheddar(2,12);

// Console.WriteLine(cheddar);

//decimal a = 10.99m; 
//int b = 1;
//decimal c = b;
//int d = (int) a; // esta conversion solo quita la parte despues del punto,
//int e = Convert.ToInt32(a); // esta conversion redondea el numero al convertirlo a int
//int seasonNumber = 0;
//Season season = (Season) seasonNumber; // conversion explicita
//Console.WriteLine(season);
//Console.WriteLine(a);
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);

//var cheddar = new Cheddar(1, 13);
//Console.WriteLine($"is Object {cheddar is Object}");
//Console.WriteLine($"is Ingredient {cheddar is Ingredients}");
//Console.WriteLine($"is Cheddar {cheddar is Cheddar}");
//Console.WriteLine($"is Mozzarella {cheddar is Mozzarella}");
//Console.WriteLine($"is Pizza {cheddar is Pizza}");
//Console.WriteLine($"is TomatoSauce {cheddar is TomatoSauce}");

//Ingredients randomIngredient = GenerateRandomIngredient();
//Cheddar cheddar = randomIngredient as Cheddar; // el as intenta convertir el objeto a la clase especificada, sino puede devuelve null
//Console.WriteLine($"random ingredient {randomIngredient.Name}");
//Console.WriteLine($"cheddar ingredient {cheddar?.Name}");

//if(cheddar is null) {
//    Console.WriteLine("The ingredient is not a cheddar");
//}
//else
//{
//    Console.WriteLine("The ingredient is a cheddar");
//}

//if (randomIngredient is Cheddar c)
//{
//    c = (Cheddar)randomIngredient;
//    Console.WriteLine("Ingrendient is Cheddar");
//    Console.WriteLine($"cheddar ingredient {c}");
//}


//Ingredients GenerateRandomIngredient()
//{
//    var rnd = new Random();
//    int num = rnd.Next(1, 4);

//    switch (num)
//    {
//        case 1:
//            return new Ingredients(1);
//        case 2:
//            return new Mozzarella(1);
//        default:
//            return new Cheddar(1, 2);
//    }
//}



//var ingredientsArray = new List<Ingredients> {  new Cheddar(1, 12),
//new TomatoSauce(1),
//new Mozzarella(1) };


//foreach (var ingredient in ingredientsArray)
//{
//    ingredient.Prepare();
//}

//var list = new List<int> { 1, 5, 10, 8, 12, 4, 5 };
//var newList = list.TakeEverySecond();
//Console.WriteLine($"new  list: {string.Join(", ",newList)}");

//var multlineString = @"aaaa
//bbbb
//cccc
//dddd
//eeee
//";

//Console.WriteLine($"The string has {multlineString.CountLines()} lines.");

//Season season = (Season) 0;

//Console.WriteLine($"Next season {season.Next()}");

Console.ReadKey();




public enum Season // se obtiene por indices empezando desde el 0
{
    Spring, // como el seasonNumber es 0 toma la primer opcion o sea Spring
    Summer,
    Autum,
    Winter
}

public class Pizza
{
    private List<Ingredients> _ingredients = new List<Ingredients>();
    public int number;
    public DateTime date;
    public Ingredients ingredients;  

    public void addIngredient(Ingredients ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe() => $"This pizza is made with the following ingredients:\n {string.Join(",", _ingredients)}";
}
 

public abstract class Ingredients


{

    public Ingredients(int _PrinceIfExtraTopping)
    {
        PrinceIfExtraTopping = _PrinceIfExtraTopping;
        Console.WriteLine("Constructor Ingredients");
    }
    public int PrinceIfExtraTopping {  get; }
    public override string ToString() => Name;

    public int PublicField;

    public virtual string Name { get; } = "Ingredients";
    public string PublicMethod() => "This is a public method in Ingredients class.";
   private string PrivateMethod() => "This is a Private method in Ingredients class.";
   protected string ProtectedMethod() => "This is a Protected method in Ingredients class.";

    public abstract void Prepare();
}



public class Cheddar : Ingredients
{
    public Cheddar(int priceIfExtraTopping, int ageForMonths): base(priceIfExtraTopping) // cuando se hereda de una clase y el constructor de la
        // clase base ocupa que se le envie parametros requeridos, base representa el constructor de la clase padre
    {
        Console.WriteLine("Constructor Cheddar");
        AgedForMonths = ageForMonths;
        
    }
    public override string Name => $"{base.Name} more specifilly a cheddar chesse aged for {AgedForMonths} months";
    public int AgedForMonths { get; }

    public void Methods() {
          Console.WriteLine(PublicMethod());
          Console.WriteLine(ProtectedMethod());
    }

    public override void Prepare()
    {
        Console.WriteLine("Grate the cheddar cheese and sprinkle it over the pizza.");
    }
}

public class TomatoSauce: Ingredients
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }
    public override string Name { get;} = "Tomato Sauce";
    public int TomatosIn100Grams { get;  }

    public sealed override void Prepare() => Console.WriteLine("Spread a generous layer of tomato sauce over the pizza dough.");
    
}

public sealed  class Mozzarella: Ingredients
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
        
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }

    public override void Prepare() =>
        Console.WriteLine("Slice thinly and place on top of the pizza.");
}

public class SpecialTomatoSauce: TomatoSauce {

    public SpecialTomatoSauce(int number): base(number)
    {
        
    }
    // los metodos sealed de clases base no pueden ser sobreescritos en clases derivadas
    //public override Prepare() => Console.WriteLine("Spread a special layer of tomato sauce over the pizza dough.");
}

//public class Parmesan: Mozzarella
//{
   
//}
