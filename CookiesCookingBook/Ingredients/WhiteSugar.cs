using Ingredients.@base;
namespace Ingredients
{
    public class WhiteSugar : Ingredient
    {
        public WhiteSugar()
        {
            AddThisIngredientToTheList();
        }

        public override int Id { get; } = 1;
        public override string Name { get; } = "White Sugar";
        public override string Instructions { get; } = "Add 2 spoons to the other ingredients.";

    }
}

