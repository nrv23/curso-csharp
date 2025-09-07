
using CookiesCookbook.Clasess;
using CookiesCookbook.Clasess.Ingredients;
using CookiesCookbook.Clasess.Ingredients.Ingredients;


var repository = new RecipesRepository(new StringTextualRepository());
var userInteraction = new RecipesConsoleUserInteraction(new IngredientRegister());

var cookiesRecipesApp = new CookiesRecipesApp(repository, userInteraction);

cookiesRecipesApp.Run("recipes.txt");