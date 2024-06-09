namespace CookiesCookingBook.Recipes.Ingredients;

public class Flour : Ingredient
{
    public override int Id => 4;
    public override string Name => "Flour";
    public override string Instructions =>
        $"Sieve. {base.Instructions}";
}
