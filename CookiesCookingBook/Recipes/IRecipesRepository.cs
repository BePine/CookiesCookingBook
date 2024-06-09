namespace CookiesCookingBook.Recipes;

public interface IRecipesRepository
{
    public List<Recipe> Read(string filepath);
    void Write(string filePath, List<Recipe> allRecipes);
}
