using Ingredients.@base;
namespace Ingredients
{
    public class Butter : Ingredient
    {
        public Butter()
        {

        }
        public override int Id { get; } = 7;
        public override string Name { get; } = "Butter";
        public override string Instructions { get; } = "Melt on low heat. Add to other ingredients.";
    }
}

