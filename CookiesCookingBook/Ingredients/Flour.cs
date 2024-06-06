using Ingredients.@base;
namespace Ingredients
{
    public class Flour : Ingredient
    {
        public Flour()
        {

        }
        public override int Id { get; } = 4;
        public override string Name { get; } = "Flour";
        public override string Instructions { get; } = "Sieve. Add to other ingredients.";
    }
}

