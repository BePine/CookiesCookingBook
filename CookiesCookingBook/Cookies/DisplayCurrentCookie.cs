using Helpers;
using Ingredients.@base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    public class DisplayCurrentCookie
    {
        bool isEmpty = true;
        Validate validate = new Validate();
        public void Show(List<Ingredient> currentCookie)
        {
            isEmpty = validate.ValidateListIsEmpty(currentCookie);
            if (!isEmpty)
            {
                Console.WriteLine("Recipe Added:");
            }
            for (int y = 0; y < currentCookie.Count; y++)
            {
                Console.WriteLine($"{currentCookie[y].Name} {currentCookie[y].Instructions}");
            }
        }
        
    }
}
