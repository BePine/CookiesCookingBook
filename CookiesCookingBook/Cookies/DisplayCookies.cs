
using Ingredients.@base;
namespace Cookies
{
    public class DisplayCookies
    {
        public void Show()
        {
            for (int x = 0; x < SaveLoadCookie.cookies.Count(); x++)
            {
                List<Ingredient> currentCookie = SaveLoadCookie.cookies[x];
                for (int y = 0; y < currentCookie.Count; y++)
                {
                    Console.WriteLine(currentCookie[y].Name + Environment.NewLine);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
