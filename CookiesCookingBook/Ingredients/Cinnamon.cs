using Ingredients.@base;
namespace Ingredients
{
    public class Cinnamon : Ingredient
    {
        public Cinnamon()
        {

        }
        public override int Id { get; } = 6;
        public override string Name { get; } = "Cinnamon";
        public override string Instructions { get; } = "Take half a teaspoon. Add to other ingredients.";
    }
}

