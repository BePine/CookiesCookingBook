using Ingredients.@base;
namespace Ingredients
{
    public class Flour : Ingredient
    {
        public Flour()
        {
            AddThisIngredientToTheList();
        }
        public override int Id { get; } = 4;
        public override string Name { get; } = "Flour";
        public override string Instructions { get; } = "Add 3 spoons to the other ingredients.";
    }
}

