using CookiesCookingBook.Recipes;
using CookiesCookingBook.Recipes.Ingredients;
var CookingBookApp = new CookingBookApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction(
        new IngredientsRegister()));
CookingBookApp.run("recipes.txt");

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
    public void run(string filePath) 
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintRecipes(allRecipes);

        _recipesUserInteraction.PromptCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadFromUser();
        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            //_recipesRepository.Write(filePath, allRecipes);
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
    public void ShowMessage(string message);
    public void ExitApp();
    void PrintRecipes(IEnumerable<Recipe> allRecipes);
    void PromptCreateRecipe();
    IEnumerable<Ingredient> ReadFromUser();
}

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IngredientsRegister _ingredientsRegister;
    public RecipesConsoleUserInteraction(
        IngredientsRegister ingredientsRegister)
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
            foreach(var recipe in allRecipes)
            {
                Console.WriteLine($"{counter}. {recipe}{Environment.NewLine}");
                ++counter;
            }
            
        }
    }

    public void PromptCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe!" +  "avalaible ingredients are:");
        foreach(var ingredient in _ingredientsRegister.FullListOfIngredients)
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
                if(selectedIngredient is not null)
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

public class IngredientsRegister
{
    public IEnumerable<Ingredient> FullListOfIngredients { get;  } = new List<Ingredient>
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
        foreach(var ingredient in FullListOfIngredients) 
        { 
        if(ingredient.Id== id)
            {
                return ingredient;
            }
        }
        return null;
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


