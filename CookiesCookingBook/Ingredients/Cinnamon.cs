using Ingredients.@base;
namespace Ingredients
{
    public class Cinnamon : Ingredient
    {
        public Cinnamon()
        {
            AddThisIngredientToTheList();

        }
        public override int Id { get; } = 6;
        public override string Name { get; } = "Cinnamon";
        public override string Instructions { get; } = "Add half of spoon to the other ingredients.";
    }
}

