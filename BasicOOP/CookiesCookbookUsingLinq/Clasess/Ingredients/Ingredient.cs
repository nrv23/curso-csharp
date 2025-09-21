namespace CookiesCookbook.Clasess.Ingredients
{
    public abstract class Ingredient
    {
        public virtual short ID { get; }
        public virtual string Name { get; } = "Unknown Ingredient";
        public virtual string PreparationInstructions() => $"Add to others ingredients";

        public override string ToString() => $"{ID}. {Name}";
    }
}
