using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesCookbook.Interfaces;

namespace CookiesCookbook.Clasess.Ingredients.Ingredients
{
    public class CookiesRecipesApp
    {

        private readonly IRecipesRepository _recipesRepository;
        private readonly IRecipesUserIntraction _recipesUserIntraction;
        public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserIntraction recipesUserInteraction)
        {
            _recipesRepository = recipesRepository;
            _recipesUserIntraction = recipesUserInteraction;
        }

        public void Run(string filePath)
        {
            Console.WriteLine("Welcome to the Cookies Recipes App!");
            
            var allRecipes = _recipesRepository.Read(filePath);
            _recipesUserIntraction.PrintExistingRecipes(allRecipes);
            _recipesUserIntraction.PromptToCreateReciep();

            var ingredients = _recipesUserIntraction.ReadIngredientsFromUser();

            if (ingredients.Count() > 0)
            {
                var recipes = new Recipe(ingredients);
                allRecipes.Add(recipes);
                _recipesRepository.Write(filePath, allRecipes);
                _recipesUserIntraction.ShowMessage("Recipe added successfully!");
                _recipesUserIntraction.ShowMessage(recipes.ToString());
            }
            else
            {
                _recipesUserIntraction.ShowMessage("No ingredients were provided. Exiting the application.");
            }
            _recipesUserIntraction.ShowMessage("Thank you for using the Cookies Recipes App. Goodbye!");
            _recipesUserIntraction.Exit();
        }
    }
}
