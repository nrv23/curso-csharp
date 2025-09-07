
using CookiesCookbook.Clasess.Ingredients;
using CookiesCookbook.Interfaces;

namespace CookiesCookbook.Clasess
{
    public class RecipesRepository: IRecipesRepository
    {   
        private readonly IStringsRepository _stringsRepository;

        public RecipesRepository(IStringsRepository stringsRepository)
        {
            _stringsRepository = stringsRepository;
        }

        public List<Recipe> Read(string filePath)
        {
            return new List<Recipe>() { 
                new Recipe(new List<Ingredient> { new Flour(), new Sugar(), new Butter() }),
                new Recipe(new List<Ingredient> { new SpealtFlour(), new CocoaPowder(), new Cinnamon() })
            };
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

                recipesAsStrings.Add(string.Join(",", allIds));
            }
            _stringsRepository.Write(filePath, recipesAsStrings);
        }
    }
}