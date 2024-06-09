namespace CookiesCookingBook.Recipes.Ingredients;

public abstract class Meltable : Ingredient
{
    public override string Instructions =>
        $"Melt on low heat. {base.Instructions}";
}
