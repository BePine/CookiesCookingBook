using System.Reflection;
using Helpers;
using Ingredients.@base;
using Newtonsoft.Json;

namespace Cookies
{

    public static class SaveLoadCookie
    {
        

        public static List<List<Ingredient>> cookies = new List<List<Ingredient>>();
        public static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static void Save(List<Ingredient> currentCookie)
        {
            Validate newValidation = new Validate();
            bool isEmpty = newValidation.ValidateListIsEmpty(currentCookie);
            if (!isEmpty)
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
                serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
                serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
                cookies.Add(currentCookie);
                using (StreamWriter sw = new StreamWriter(@$"{directory}\..\..\..\data\data.json"))
                using (Newtonsoft.Json.JsonWriter writer = new Newtonsoft.Json.JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, cookies, typeof(List<List<Ingredient>>));
                }
                    
            }
        }
        public static void Load()
        {
            var path = @$"{directory}\..\..\..\data\data.json";

            if (File.Exists(path))
            {
                
                cookies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<Ingredient>>>(File.ReadAllText(path), new Newtonsoft.Json.JsonSerializerSettings
                {
                    TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto,
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                });
            }
        }
    }
}
