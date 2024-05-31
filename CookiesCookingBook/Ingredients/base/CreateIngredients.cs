using Ingredients;

namespace Ingredients.@base
{
    public class CreateIngredients
    {
        List<Ingredient> newIngredientsList = new List<Ingredient> { 
            new WhiteSugar(),
            new BrownSugar(),
            new CocoaPowder(),
            new Flour(),
            new Milk(),
            new Cinnamon(),
            new Butter(),
            new Chocolate()
        };

        public void AddToList()
        {
            for (int i = 0; i < newIngredientsList.Count; i++)
            {
                newIngredientsList[i].AddThisIngredientToTheList();
            }
            
        }
    }
}

