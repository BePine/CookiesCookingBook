namespace Ingredient
{
    public abstract class Ingredient
    {
        public virtual int id { get; } = 0;
        public virtual string name { get; } = "ingredient";
        public virtual string instructions { get; } = "instructions";
        public virtual void Show()
        {
            Console.WriteLine($"{id}. {name}. {instructions}");
        }
        public static List<Ingredient> ConvertIngredientsToList()
        {
            List<Ingredient> result = new List<Ingredient>();   

            return result;
        }
    }

    public class WhiteSugar : Ingredient
    {
        public override int id { get; } = 1;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class BrownSugar : Ingredient
    {
        public override int id { get; } = 2;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class CocoaPowder : Ingredient
    {
        public override int id { get; } = 3;
        public override string name { get;  } = "White Sugar";
        public override string instructions { get;  } = "Add 2 spoons to other ingredients.";
    }
    public class Flour : Ingredient
    {
        public override int id { get; } = 4;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class Milk : Ingredient
    {
        public override int id { get; } = 5;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class Cinnamon : Ingredient
    {
        public override int id { get; } = 6;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class Butter : Ingredient
    {
        public override int id { get; } = 7;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class Chocolate : Ingredient
    {
        public override int id { get; } = 8;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }

}
public class ShowIngredients
{
    public void PrintAllIngredients()
    {
        for (int i = 0; i < 10; i++) { }
    }
}