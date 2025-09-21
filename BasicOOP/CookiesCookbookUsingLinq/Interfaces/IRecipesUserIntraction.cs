using CookiesCookbook.Clasess;
using CookiesCookbook.Clasess.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Interfaces
{
    public interface IRecipesUserIntraction
    {
        void Exit();
        public void PrintExistingRecipes(IEnumerable<Recipe> recipes);
        void PromptToCreateReciep();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
        void ShowMessage(string v);
    }
}
