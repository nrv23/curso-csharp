using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Clasess
{
    public class CookiesRecipesApp
    {

        private readonly RecipesRepository _recipesRepository;
        private readonly RecipesUserInteraction _recipesUserInteraction;
        public CookiesRecipesApp(RecipesRepository recipesRepository,RecipesUserInteraction recipesUserInteraction)
        {
            _recipesRepository = recipesRepository;
            _recipesUserInteraction = recipesUserInteraction;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Cookies Recipes App!");
            
            var allRecipes = _recipesRepository.Read(filePath);
            _recipesUserInteraction.PrintExistingRecipes(allRecipes);
            _recipesUserInteraction.PromptToCreateReciep();
        }
    }
}
