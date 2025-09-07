
using CookiesCookbook.Clasess.Ingredients;
using CookiesCookbook.Interfaces;

namespace CookiesCookbook.Clasess
{
    public class RecipesConsoleUserInteraction: IRecipesUserIntraction
    {
        private readonly IngredientRegister _ingredientRegister;

        public RecipesConsoleUserInteraction(IngredientRegister ingredientRegister)
        {
            _ingredientRegister = ingredientRegister;
        }

        public void Exit()
        {
            Console.WriteLine("Exiting the application. Press any key to close.");
            Console.ReadKey();
        }

        public void PrintExistingRecipes(IEnumerable<Recipe> recipes)
        {
            if(recipes.Count() > 0)
            {
                Console.WriteLine($"Existing recipes are:" + Environment.NewLine);
                var count = 1;
                foreach (var recipe in recipes)
                {
                    Console.WriteLine($"*****{count}*****");
                    Console.WriteLine(recipe);
                    Console.WriteLine();
                    count++;
                }
            }
        }

 

        public void PromptToCreateReciep()
        {
            Console.WriteLine(@"
                Create a new cookie recipe !
                Available ingredientes are:
            ");

            foreach(var ingredient in _ingredientRegister.All)
            {
                Console.WriteLine(ingredient.ToString());
            }

        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            bool shallStop = false;
            var ingredients = new List<Ingredient>();

            while (!shallStop)
            {
                Console.WriteLine("Type the name of the ingredient to add or type 'exit' to finish:");
                var userInput = Console.ReadLine();

                if(int.TryParse(userInput, out int ingredientid ))
                {

                    var ingredient = _ingredientRegister.GetById(ingredientid);

                    if( ingredient is not null)
                    {
                        ingredients.Add(ingredient);
                    }

                } else
                {
                    shallStop = true; // sino es un ingrediente valido, salimos
                }
                
            }

            return ingredients;
        }
    }
}