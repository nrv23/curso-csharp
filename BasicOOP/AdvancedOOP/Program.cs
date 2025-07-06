



var pizza = new Pizza();    
pizza.addIngredient(new Cheddar ());
pizza.addIngredient(new TomatoSauce());
pizza.addIngredient(new Mozzarella());

// aplicando herencia  

var cheddar = new Cheddar();

var igredients = new  Cheddar();

cheddar.Methods();
cheddar.PublicField = 1;

Console.WriteLine($"Cheddar public field: {cheddar.PublicField}");
Console.WriteLine($"Cheddar name: {cheddar.Name}");
Console.WriteLine("Ingredient Name: " + igredients.Name);

var ingredientsList = new List<Ingredients>
{
    new Cheddar(),
    new TomatoSauce(),
    new Mozzarella()
};

foreach (var ingredient in ingredientsList)
{
    Console.WriteLine($"Ingredient: {ingredient.Name}");
}
Console.ReadKey();
public class Pizza
{
    private List<Ingredients> _ingredients = new List<Ingredients>();


    public void addIngredient(Ingredients ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe() => $"This pizza is made with the following ingredients:\n {string.Join(",", _ingredients)}";
}
 

public class Ingredients

{

    public int PublicField;

    public virtual string Name { get; } = "Ingredients";
    public string PublicMethod() => "This is a public method in Ingredients class.";
   private string PrivateMethod() => "This is a Private method in Ingredients class.";
   protected string ProtectedMethod() => "This is a Protected method in Ingredients class.";
}



public class Cheddar : Ingredients
{
    public override string Name { get; } = "Cheddar Cheese";
    public int AgedForMonths { get; }

    public void Methods() {
          Console.WriteLine(PublicMethod());
          Console.WriteLine(ProtectedMethod());
    }
}

public class TomatoSauce: Ingredients
{
       public override string Name { get;} = "Tomato Sauce";
    public int TomatosIn100Grams { get;  }
}

public  class Mozzarella: Ingredients
{
   

    public  string Name => "Mozzarella";
    public bool IsLight { get; }

    public  void Prepare() =>
        Console.WriteLine("Slice thinly and place on top of the pizza.");
}
