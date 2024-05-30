namespace Ingredients
{
    public class Butter : Ingredient
    {
        public Butter()
        {
            AddThisIngredientToTheList();

        }
        public override int Id { get; } = 7;
        public override string Name { get; } = "Butter";
        public override string Instructions { get; } = "Add half of spoon to the other ingredients.";
    }
}

