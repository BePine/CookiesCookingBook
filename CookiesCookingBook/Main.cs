using Cookies;
using Helpers;
using Ingredients.@base;
SaveLoadCookie.Load();

DisplayCookies displayCookies = new DisplayCookies();
displayCookies.Show();

Welcome.Show();
CreateIngredients.Create();
DisplayIngredients.Show();

Cookie newCookie = new Cookie();
newCookie.CreateCookie();

