using CookiesCookingBook.Ingredients;
using CookiesCookingBook.Recipes;
using CookiesCookingBook.Recipes.Ingredients;
var CookingBookApp = new CookingBookApp(
    new RecipesRepository(),
    new RecipesUserInteraction());
CookingBookApp.run();

public class CookingBookApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;
    private object filePath;

    public CookingBookApp(
        IRecipesRepository recipesRepository,
        IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void run() 
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintRecipes(allRecipes);

        _recipesUserInteraction.PromptCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadFromUser();
        if(ingredients.Count > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);
            _recipesUserInteraction.ShowMessage("Recipe created:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage("No ingredients were selected.");
        }
        _recipesUserInteraction.ExitApp();
    }

}




public interface IRecipesUserInteraction
{
    public void ShowMessage();
    public void ExitApp();
}

public class RecipesUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void ExitApp()
    {
        Console.WriteLine("Press any key to quit the app...");
        Console.ReadKey();
    }

    
}


public interface IRecipesRepository
{
    public List<Recipe> Read(string filepath);
}

public class RecipesRepository : IRecipesRepository
{
    public List<Recipe> Read(string filepath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>
            {
                new BrownSugar(),
                new WhiteSugar(),
                new CocoaPowder(),

            }),
            new Recipe(new List<Ingredient>
            {
                new Milk(),
                new Butter(),
                new Flour(),

            })
        };
    }
}


