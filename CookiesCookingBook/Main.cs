using CookiesCookingBook.App;
using CookiesCookingBook.Recipes;
using CookiesCookingBook.Recipes.DataAccess;
using CookiesCookingBook.Recipes.Ingredients;
try
{
    var ingredientsRegister = new IngredientsRegister();
    var cookingBookApp = new CookingBookApp(
        new RecipesRepository(
            new StringsTextualRepository(),
            ingredientsRegister),
        new RecipesConsoleUserInteraction(
            ingredientsRegister));

    cookingBookApp.run("recipes.txt");
}
catch(Exception ex)
{
    Console.WriteLine("Sorry, the application encountered an unexpected error and will be closed." + ex.Message);
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
}






