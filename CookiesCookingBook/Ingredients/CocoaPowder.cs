namespace Ingredients
{
    public class CocoaPowder : Ingredient
    {
        public CocoaPowder()
        {
            AddThisIngredientToTheList();
        }
        public override int Id { get; } = 3;
        public override string Name { get; } = "Cocoa Powder";
        public override string Instructions { get; } = "Add 2.5 spoon to the other ingredients.";
    }
}

