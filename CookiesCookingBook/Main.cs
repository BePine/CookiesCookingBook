using Ingredients.Ingredient;

WhiteSugar whiteSugar = new WhiteSugar();
whiteSugar.Show();
for(int i=0; i > Ingredient.ingredients.Count; i++)
{
    Console.WriteLine($"{Ingredient.ingredients[i].id}. {Ingredient.ingredients[i].name}");
}
Console.ReadKey();

