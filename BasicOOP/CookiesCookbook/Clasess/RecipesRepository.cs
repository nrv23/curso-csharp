
using CookiesCookbook.Clasess.Ingredients;
using CookiesCookbook.Interfaces;

namespace CookiesCookbook.Clasess
{
    public class RecipesRepository: IRecipesRepository
    {   
        private readonly IStringsRepository _stringsRepository;
        private readonly IIngredientRegister _ingredientsRepository;
        private const string Separator = ",";

        public RecipesRepository(IStringsRepository stringsRepository, IIngredientRegister ingredientsRepository)
        {
            _stringsRepository = stringsRepository;
            _ingredientsRepository = ingredientsRepository;
        }

        public List<Recipe> Read(string filePath)
        {
            List<string> recipesFromFile = _stringsRepository.Read(filePath);
            var recipes = new List<Recipe>();   


            foreach(var recipeFromFile in recipesFromFile)
            {
                var recipe = RecipeFromString(recipeFromFile);
                if(recipe != null)
                {
                    recipes.Add(recipe);
                }
            }

            return recipes;
        }

        private Recipe RecipeFromString(string recipeFromFile)
        {
            var textualIds = recipeFromFile.Split(Separator);
            var ingredientIds = new List<Ingredient>();

            foreach(var textualId in textualIds)
            {
                var id = int.Parse(textualId);
                var ingredient = _ingredientsRepository.GetById(id);
                ingredientIds.Add(ingredient!);
            }

            return new Recipe(ingredientIds);
        }

        public void Write(string filePath, List<Recipe> allRecipes)
        {
            var recipesAsStrings = new List<string>();
            foreach (var recipe in allRecipes)
            {
                var allIds = new List<int>();
                foreach(var ingredient in recipe.Ingredients)
                {
                    allIds.Add(ingredient.ID);
                }

                recipesAsStrings.Add(string.Join(Separator, allIds));
            }
            _stringsRepository.Write(filePath, recipesAsStrings);
        }
    }
}