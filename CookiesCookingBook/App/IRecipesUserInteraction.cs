using CookiesCookingBook.Recipes.Ingredients;
using CookiesCookingBook.Recipes;

namespace CookiesCookingBook.App;

public interface IRecipesUserInteraction
{
    public void ShowMessage(string message);
    public void ExitApp();
    void PrintRecipes(IEnumerable<Recipe> allRecipes);
    void PromptCreateRecipe();
    IEnumerable<Ingredient> ReadFromUser();
}
