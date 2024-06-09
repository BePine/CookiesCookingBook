using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookingBook.Recipes.DataAccess;

public interface IStringsRepository
{
    public List<string> Read(string filePath);
    public void Write(string filePath, List<string> strings);
}
