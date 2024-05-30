namespace Ingredients
{
    public class Chocolate : Ingredient
    {
        public Chocolate()
        {
            AddThisIngredientToTheList();

        }
        public override int Id { get; } = 8;
        public override string Name { get; } = "Chocolate";
        public override string Instructions { get; } = "Add around 6 pieces of chocolate to the rest of the ingredients.";
    }
}

