
using Ingredients.@base;
namespace Cookies
{
    public static class DisplayCookies
    {
        public static void Show()
        {
            for (int x = 0; x < SaveLoadCookie.cookies.Count(); x++)
            {
                List<Ingredient> currentCookie = SaveLoadCookie.cookies[x];
                for (int y = 0; y < currentCookie.Count; y++)
                {
                    Console.WriteLine($"{currentCookie[y].Name} {currentCookie[y].Instructions}");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
