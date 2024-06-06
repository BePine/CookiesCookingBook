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
    }

}
