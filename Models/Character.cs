// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace dev_rick_and_morty_api.Models;

public class Characters
{
    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name;

    [JsonProperty("status")]
    [JsonPropertyName("status")]
    public string Status;

    [JsonProperty("species")]
    [JsonPropertyName("species")]
    public string Species;

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type;

    [JsonProperty("gender")]
    [JsonPropertyName("gender")]
    public string Gender;

    [JsonProperty("origin")]
    [JsonPropertyName("origin")]
    public Origin Origin;

    [JsonProperty("location")]
    [JsonPropertyName("location")]
    public Location Location;

    [JsonProperty("image")]
    [JsonPropertyName("image")]
    public string Image;

    [JsonProperty("episode")]
    [JsonPropertyName("episode")]
    public List<Episodes> Episode;

    [JsonProperty("url")]
    [JsonPropertyName("url")]
    public string Url;

    [JsonProperty("created")]
    [JsonPropertyName("created")]
    public DateTime? Created;
}