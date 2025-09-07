using CookiesCookbook.Clasess.Ingredients;

public class Spice: Ingredient
{
    public override string PreparationInstructions() => $"Grind. {base.PreparationInstructions()}";
}
