using CookiesCookbook.Clasess.Ingredients;

public class ChocolateChips : Ingredient
{
    public override Int16 ID => 4;
    public override string Name => "Chocolate Chips";
    public override string PreparationInstructions() =>  $"Meal in water batch. {base.PreparationInstructions()}";
    
}
