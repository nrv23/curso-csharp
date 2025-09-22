using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Clasess.Ingredients
{

    public class IngredientRegister : IIngredientRegister
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
            //var  countOfIngredientsWithTheSameId = All.Count(ig => ig.ID == id);
            //var  countOfIngredientsWithTheSameId = All.Where(ig => ig.ID == id).DistinctBy(p=> p.ID);
            var  countOfIngredientsWithTheSameId = All.Where(ig => ig.ID == id);

            // validar id actual si esta duplicado en la lista

            if (countOfIngredientsWithTheSameId.Count() > 1)
            {
                throw new InvalidOperationException($"ingredient with id {id} it is repeat");
            }
            // validar otros ids duplicados
            if(All.Select(ingredient => ingredient.ID).Distinct().Count() !=  All.Count())
            {
                throw new InvalidOperationException($"SOme ingredients are repeated");
            }

            //return All.FirstOrDefault(ig => ig.ID == id);
           return countOfIngredientsWithTheSameId.FirstOrDefault();
        }
    }
}
