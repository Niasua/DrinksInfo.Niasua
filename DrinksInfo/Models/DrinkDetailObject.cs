using DrinksInfo.Models;
using Newtonsoft.Json;

namespace DrinksInfo.Models;

internal class DrinkDetailObject
{
    [JsonProperty("drinks")]
    public List<DrinkDetail> DrinkDetailList { get; set; }
}