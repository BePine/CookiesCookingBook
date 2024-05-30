using Ingredients.Ingredient;


Ingredient.CreateIngredients();
for(int i=0; i < Ingredient.ingredients.Count; i++)
{
    Console.WriteLine($"{Ingredient.ingredients[i].id}. {Ingredient.ingredients[i].name}");
}

Console.ReadKey();

