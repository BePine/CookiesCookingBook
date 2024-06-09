using CookiesCookingBook.App;
using CookiesCookingBook.Recipes;
using CookiesCookingBook.Recipes.DataAccess;
using CookiesCookingBook.Recipes.Ingredients;

var ingredientsRegister = new IngredientsRegister();
var cookingBookApp = new CookingBookApp(
    new RecipesRepository(
        new StringsTextualRepository(),
        ingredientsRegister),
    new RecipesConsoleUserInteraction(
        ingredientsRegister));

cookingBookApp.run("recipes.txt");







