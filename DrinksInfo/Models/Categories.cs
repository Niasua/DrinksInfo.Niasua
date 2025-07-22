using Newtonsoft.Json;

namespace DrinksInfo.Models;

public class Categories
{
    [JsonProperty("drinks")]
    public List<Category> Drinks { get; set; }
}
