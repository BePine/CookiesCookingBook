namespace CookiesCookingBook.Helpers
{
    public class Validate
    {
        public string ValidateUserInput(string input)
        {

            if (input != "")
            {
                var parsingChoice = new Parsing(input);
                var idNumber = parsingChoice.Number - 1;
                if (parsingChoice.IsNumber)
                {
                    if (idNumber <= Ingredient.ingredients.Count && idNumber > 0)
                    {
                        return "ok";
                    }
                    return "wrongNumber";

                }
                return "notANumber";

            }
            return "emptyString";

        }
        public string ValidateListCount(List<Ingredient> givenList)
        {
            if(givenList.Count != 0)
            {
                return "notEmpty";
            }
            return "empty";
        }

    }
}

