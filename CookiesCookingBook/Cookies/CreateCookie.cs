using Helpers;
using Ingredients.@base;
using Ingredients;
namespace Cookies
{
    public class Cookie
    {
        public List<Ingredient> CreateCookie()
        {
            List<Ingredient> createdCookie = new List<Ingredient>();
            DisplayCurrentCookie displayCurrentCookie = new DisplayCurrentCookie(); 
            bool creationStatus = true;
            while (creationStatus)
            {
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
                
                Validate validation = new Validate();
                string selectedNumber = Console.ReadLine();
                string validationResult = validation.ValidateUserInput(selectedNumber);
                switch (validationResult)
                {
                    case "ok":
                        int idAsNumber = int.Parse(selectedNumber) - 1;
                        createdCookie.Add(Ingredient.ingredients[idAsNumber]);
                        break;
                    case "wrongNumber":
                        Console.WriteLine("type in a number that's assigned to one of the ingredients");
                        break;
                    case "notANumber":
                        Console.WriteLine("Please type in a number");
                        break;
                    case "emptyString":
                        displayCurrentCookie.Show(createdCookie);
                        Console.ReadLine();
                        SaveLoadCookie.Save(createdCookie);
                        creationStatus = false;
                        break;
                }
               
            }
            return createdCookie;
        }
        
    }
}

