using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesCookingBook.Recipes.Ingredients;

namespace CookiesCookingBook.Recipes
{
    public class Recipe
    {
        IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
        public override string ToString()
        {
            var tempList = new List<string>();
            foreach(var ingredient in Ingredients) 
            {
                tempList.Add($"{ingredient.Name}. {ingredient.Instructions}");
            }
            return string.Join(Environment.NewLine, tempList);
        }
    }

}
