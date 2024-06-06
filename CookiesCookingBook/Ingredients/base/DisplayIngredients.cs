using Ingredients.@base;

namespace Ingredients.@base
{
    public static class DisplayIngredients
    {
        public static void Show()
        {
            for (int i = 0; i < Ingredient.ingredients.Count; i++)
            {
                Console.WriteLine($"{Ingredient.ingredients[i].Id}. {Ingredient.ingredients[i].Name}");
            }
        }
    }
}

