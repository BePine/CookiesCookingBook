using Ingredients.@base;
namespace Ingredients
{
    public class BrownSugar : Ingredient
    {
        public BrownSugar()
        {
            AddThisIngredientToTheList();
        }

        public override int Id { get; } = 2;
        public override string Name { get; } = "Brown Sugar";
        public override string Instructions { get; } = "Add 1.5 spoons to the other ingredients.";

    }
}

