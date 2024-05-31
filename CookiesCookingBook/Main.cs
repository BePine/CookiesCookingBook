using Cookies;
using Helpers;
using Ingredients.@base;


SaveLoadCookie.Load();
DisplayCookies.Show();

CreateIngredients createIngredients = new CreateIngredients();
createIngredients.AddToList();

Welcome.Show();
DisplayIngredients.Show();

Cookie newCookie = new Cookie();
newCookie.CreateCookie();

