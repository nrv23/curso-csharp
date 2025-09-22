using CookiesCookbook.Clasess.Ingredients;

namespace CookiesCookbook.Clasess
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredientnts)
        {
            this.Ingredients = ingredientnts;
        }

        public override string ToString()
        {
            var steps = Ingredients.Select(ingredient => $"{ingredient.Name}  {ingredient.PreparationInstructions()}");
            return string.Join(Environment.NewLine, steps);
        }
    }
}
