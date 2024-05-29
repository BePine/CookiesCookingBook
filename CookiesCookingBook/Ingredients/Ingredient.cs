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
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class BrownSugar : Ingredient
    {
        public BrownSugar()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 2;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class CocoaPowder : Ingredient
    {
        public CocoaPowder()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 3;
        public override string name { get;  } = "White Sugar";
        public override string instructions { get;  } = "Add 2 spoons to other ingredients.";
    }
    public class Flour : Ingredient
    {
        public Flour()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 4;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class Milk : Ingredient
    {
        public Milk()
        {
            this.AddThisIngredientToTheList();
        }
        public override int id { get; } = 5;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class Cinnamon : Ingredient
    {
        public Cinnamon()
        {
            this.AddThisIngredientToTheList();

        }
        public override int id { get; } = 6;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class Butter : Ingredient
    {
        public Butter()
        {
            this.AddThisIngredientToTheList();

        }
        public override int id { get; } = 7;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    
    public class Chocolate : Ingredient
    {
        public Chocolate()
        {
            this.AddThisIngredientToTheList();

        }
        public override int id { get; } = 8;
        public override string name { get; } = "White Sugar";
        public override string instructions { get; } = "Add 2 spoons to other ingredients.";
    }
    public class CreateIngredients
    {
        public void CreateIngredientsInstances()
        {

        }
    }

}

