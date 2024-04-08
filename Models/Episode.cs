// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace dev_rick_and_morty_api.Models;

public class Episodes
{
    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name;

    [JsonProperty("air_date")]
    [JsonPropertyName("air_date")]
    public string AirDate;

    [JsonProperty("episode")]
    [JsonPropertyName("episode")]
    public string Episode;

    [JsonProperty("characters")]
    [JsonPropertyName("characters")]
    public List<Character> Characters;

    [JsonProperty("url")]
    [JsonPropertyName("url")]
    public string Url;

    [JsonProperty("created")]
    [JsonPropertyName("created")]
    public DateTime? Created;
}