
using CookiesCookbook.Clasess;
using CookiesCookbook.Clasess.Ingredients;
using CookiesCookbook.Clasess.Ingredients.Ingredients;
using CookiesCookbook.Enums;

try
{
    const FileFormat Format = FileFormat.json;
    const string filePath = "recipes";
    IStringsRepository jsonStringRepository = Format == FileFormat.json
        ? new JSONStringsRepository()
        : new StringTextualRepository();

    var ingredientRegister = new IngredientRegister();
    var repository = new RecipesRepository(jsonStringRepository, ingredientRegister);
    var userInteraction = new RecipesConsoleUserInteraction(ingredientRegister);
    var cookiesRecipesApp = new CookiesRecipesApp(repository, userInteraction);

    cookiesRecipesApp.Run(new FileMetaData(filePath, Format).GetPath());
}
catch(Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
finally
{   
    Console.WriteLine("The application has finished.");
    Console.ReadLine();
}