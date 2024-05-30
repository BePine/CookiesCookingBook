namespace Ingredients
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

    public class WhiteSugar : Ingredient
    {
        public WhiteSugar()
        {
            AddThisIngredientToTheList();
        }

        public override int Id { get; } = 1;
        public override string Name { get; } = "White Sugar";
        public override string Instructions { get; } = "Add 2 spoons to the other ingredients.";

    }

    public class BrownSugar : Ingredient
    {
        public BrownSugar()
        {
            AddThisIngredientToTheList();
        }

        public override int Id { get; } = 2;
        public override string Name { get; } = "Brown Sugar";
        public override string Instructions { get; } = "Add 1.5 spoons to the other ingredients.";

    }

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

    public class Flour : Ingredient
    {
        public Flour()
        {
            AddThisIngredientToTheList();
        }
        public override int Id { get; } = 4;
        public override string Name { get; } = "Flour";
        public override string Instructions { get; } = "Add 3 spoons to the other ingredients.";
    }

    public class Milk : Ingredient
    {
        public Milk()
        {
            AddThisIngredientToTheList();
        }
        public override int Id { get; } = 5;
        public override string Name { get; } = "Milk";
        public override string Instructions { get; } = "Add half a glass.";
    }

    public class Cinnamon : Ingredient
    {
        public Cinnamon()
        {
            AddThisIngredientToTheList();

        }
        public override int Id { get; } = 6;
        public override string Name { get; } = "Cinnamon";
        public override string Instructions { get; } = "Add half of spoon to the other ingredients.";
    }

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

