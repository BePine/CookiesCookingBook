using Ingredients;
using Cookies;
using Helpers;
Welcoming.Show();
CreateIngredients.Create();
DisplayIngredients.Show();

Cookie newCookie = new Cookie();
newCookie.ValidateInput();

