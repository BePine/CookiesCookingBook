namespace Ingredients.Ingredient
{

    
    public abstract class Ingredient
    {
        public virtual int id { get; } = 0;
        public virtual string name { get; } = "ingredient";
        public virtual string instructions { get; } = "instructions";
        public static List<Ingredient> ingredients = new List<Ingredient>();
        public virtual void Show()
        {
            Console.WriteLine($"{id}. {name}. {instructions}");
        }
        public static void CreateIngredients()
        {
            new WhiteSugar();
            new BrownSugar();
            new CocoaPowder();
            new Flour();
            new Milk();
            new Cinnamon();
            new Butter();
            new Chocolate();
        }
        public void AddThisIngredientToTheList()
        { 
            ingredients.Add( this );
        }
       
        
    }

    public class WhiteSugar : Ingredient
    {
        public WhiteSugar()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 1;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to the other ingredients.";
    }
    public class BrownSugar : Ingredient
    {
        public BrownSugar()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 2;
        public override string name { get; } = "Brown Sugar";
        public override string instructions { get; } = "Add 1.5 spoons to the other ingredients.";
    }
    public class CocoaPowder : Ingredient
    {
        public CocoaPowder()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 3;
        public override string name { get;  } = "Cocoa Powder";
        public override string instructions { get;  } = "Add 2.5 spoon to the other ingredients.";
    }
    public class Flour : Ingredient
    {
        public Flour()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 4;
        public override string name { get; } = "Flour";
        public override string instructions { get; } = "Add 3 spoons to the other ingredients.";
    }
    public class Milk : Ingredient
    {
        public Milk()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 5;
        public override string name { get; } = "Milk";
        public override string instructions { get; } = "Add half a glass.";
    }
    public class Cinnamon : Ingredient
    {
        public Cinnamon()
        {
            this.AddThisIngredientToTheList();

        }
        public override int id { get; } = 6;
        public override string name { get; } = "Cinnamon";
        public override string instructions { get; } = "Add half of spoon to the other ingredients.";
    }
    public class Butter : Ingredient
    {
        public Butter()
        {
            this.AddThisIngredientToTheList();

        }
        public override int id { get; } = 7;
        public override string name { get; } = "Butter";
        public override string instructions { get; } = "Add half of spoon to the other ingredients.";
    }
    
    public class Chocolate : Ingredient
    {
        public Chocolate()
        {
            this.AddThisIngredientToTheList();

        }
        public override int id { get; } = 8;
        public override string name { get; } = "Chocolate";
        public override string instructions { get; } = "Add around 6 pieces of chocolate to the rest of the ingredients.";
    }
}

