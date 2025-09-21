using CookiesCookbook.Clasess.Ingredients;

public class Butter : Ingredient
{
    public override Int16 ID => 3;
    public override string Name => "Butter";
    public override string PreparationInstructions() =>  $"Melt in low heat. {base.PreparationInstructions()}";
    
}
