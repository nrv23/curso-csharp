using CookiesCookbook.Clasess.Ingredients;

public class Flour : Ingredient
{
    public override string PreparationInstructions() => $"Sieve. {base.PreparationInstructions()}";

}
