using CookiesCookingBook.Recipes.Ingredients;
using CookiesCookingBook.Recipes;

namespace CookiesCookingBook.App;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IIngredientsRegister _ingredientsRegister;
    public RecipesConsoleUserInteraction(
        IIngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void ExitApp()
    {
        Console.WriteLine("Press any key to quit the app...");
        Console.ReadKey();
    }

    public void PrintRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are: " + Environment.NewLine);

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"{counter}. {Environment.NewLine}{recipe}{Environment.NewLine}");
                ++counter;
            }

        }
    }

    public void PromptCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe!" + Environment.NewLine + "avalaible ingredients are:");
        foreach (var ingredient in _ingredientsRegister.FullListOfIngredients)
        {
            Console.WriteLine(ingredient);
        }
    }

    public IEnumerable<Ingredient> ReadFromUser()
    {
        bool shallStop = false;
        var ingredients = new List<Ingredient>();

        while (!shallStop)
        {
            Console.WriteLine("Add an ingredient by its ID, or type anything else if finished.");

            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int id))
            {
                var selectedIngredient = _ingredientsRegister.GetById(id);
                if (selectedIngredient is not null)
                {
                    ingredients.Add(selectedIngredient);
                }
            }
            else
            {
                shallStop = true;
            }
        }
        return ingredients;
    }
}
