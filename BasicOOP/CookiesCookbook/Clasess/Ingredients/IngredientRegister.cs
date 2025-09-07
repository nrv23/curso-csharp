using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Clasess.Ingredients
{
    public class IngredientRegister
    {
        public IEnumerable<Ingredient> All { get; } = new List<Ingredient> { 
        
            new WheatFlour(),
            new SpealtFlour(),
            new Butter(),
            new ChocolateChips(),
            new Sugar(),
            new Cardamom(),
            new Cinnamon(),
            new CocoaPowder()
        };

        public Ingredient? GetById(int id)
        {
            Ingredient? result = null;
            foreach (var ingredient in All)
            {
                if (ingredient.ID != id) continue ;
                result = ingredient;
            }

            return result;
        }
    }
}
