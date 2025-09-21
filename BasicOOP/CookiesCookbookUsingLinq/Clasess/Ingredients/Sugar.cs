using CookiesCookbook.Clasess.Ingredients;

public class Sugar : Ingredient
{
    public override Int16 ID => 5;
    public override string Name => "Sugar";
    public override string PreparationInstructions() =>  $"{base.PreparationInstructions()}";
    
}
