namespace CookiesCookingBook.Recipes.Ingredients;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> FullListOfIngredients { get; } = new List<Ingredient>
{
    new WhiteSugar(),
    new BrownSugar(),
    new CocoaPowder(),
    new Flour(),
    new Milk(),
    new Cinnamon(),
    new Butter(),
    new Chocolate()

};

    public Ingredient GetById(int id)
    {
        foreach (var ingredient in FullListOfIngredients)
        {
            if (ingredient.Id == id)
            {
                return ingredient;
            }
        }
        return null;
    }
}
