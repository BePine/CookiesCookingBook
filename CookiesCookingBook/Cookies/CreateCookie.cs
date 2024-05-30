using Ingredients;
using System.Numerics;
namespace Cookies
{
    public class Cookie
    {

        public void ValidateInput()
        {
            var input = Console.ReadLine();


            if (input != "")
            {
                var parsingChoice = new Parsing(input);
                if (parsingChoice.IsNumber)
                {
                    if(parsingChoice.Number >= Ingredient.ingredients.Count && parsingChoice.Number > 0)
                    {

                    }
                }

                else
                {
                    Console.WriteLine("Please type in a number");
                }
            }

            else
            {
                Console.WriteLine("its empty;");
            }
            
            Console.ReadLine();
        }
    }
    public class Parsing
    {
        public bool IsNumber { get; private set; }
        public int Number { get; private set; } = 0;
        public Parsing(string inputNumber)
        {
            
            IsNumber = ParseChoice(inputNumber);
            if (IsNumber) 
            {
                Number = int.Parse(inputNumber); 
            }
        }
        public bool ParseChoice(string input) => int.TryParse(input, out int number);

    }
}

