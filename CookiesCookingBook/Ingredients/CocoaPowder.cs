using Ingredients.@base;
namespace Ingredients
{
    public class CocoaPowder : Ingredient
    {
        public CocoaPowder()
        {

        }
        public override int Id { get; } = 3;
        public override string Name { get; } = "Cocoa Powder";
        public override string Instructions { get; } = "Take half a teaspoon. Add to other ingredients.";
    }
}

