namespace Ingredients.@base
{
    public abstract class Ingredient
    {
        public virtual int Id { get; } = 0;
        public virtual string Name { get; } = "ingredient";
        public virtual string Instructions { get; } = "instructions";

        public static List<Ingredient> ingredients = new List<Ingredient>();


        public virtual void Show()
        {
            Console.WriteLine($"{Id}. {Name}. {Instructions}");
        }

        public void AddThisIngredientToTheList()
        {
            ingredients.Add(this);
        }

    }
}

