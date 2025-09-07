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
            var steps = new List<string>();

            foreach(var ingredient in Ingredients)
            {
                steps.Add($"{ingredient.Name}  {ingredient.PreparationInstructions()}");
            }

            return string.Join(Environment.NewLine, steps);
        }
    }
}
