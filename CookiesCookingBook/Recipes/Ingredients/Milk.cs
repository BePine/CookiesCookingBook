namespace CookiesCookingBook.Recipes.Ingredients
{
    public class Milk : Ingredient
    {
        public override int Id => 5;
        public override string Name => "Milk";
        public override string Instructions =>
            $"Add half a glass and mix by kneading.";
    }

}
