namespace CookiesCookingBook.Recipes.Ingredients;

public interface IIngredientsRegister
{
    IEnumerable<Ingredient> FullListOfIngredients { get; }

    Ingredient GetById(int id);
}
