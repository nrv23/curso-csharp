namespace CookiesCookbook.Clasess.Ingredients
{
    public interface IIngredientRegister
    {
        IEnumerable<Ingredient> All { get; }

        Ingredient? GetById(int id);
    }
}
