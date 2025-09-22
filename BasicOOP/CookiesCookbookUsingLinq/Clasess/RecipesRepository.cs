
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
            return _stringsRepository.Read(filePath).Select(RecipeFromString).ToList();
        }

        private Recipe RecipeFromString(string recipeFromFile)
        {

            var ingredients = recipeFromFile.Split(Separator) // genera la lista de ids numericos
                .Select(int.Parse) // convierte a int cada id
                .Select(_ingredientsRepository.GetById); // obtiene los productos por id 
            // y devuelve una lista de ingredientes
                                     
            // el Select devuelve una lista
            return new Recipe(ingredients); // devuelve la lista
        }

        public void Write(string filePath, List<Recipe> allRecipes)
        {
            var recipesAsStrings = allRecipes.Select(recipe => {
                var allIds = recipe.Ingredients.Select(i => i.ID);
                return string.Join(Separator, allIds);
            });
            _stringsRepository.Write(filePath, recipesAsStrings.ToList());
        }
    }
}