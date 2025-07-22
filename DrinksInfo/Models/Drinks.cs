using Newtonsoft.Json;

namespace DrinksInfo.Models;

public class Drinks
{
    [JsonProperty("drinks")]
    public List<Drink> DrinksList { get; set; }
}