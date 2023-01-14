using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace dev_rick_and_morty_api.Models;

public class Location
{
    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int? Id;

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name;

    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public string Type;

    [JsonProperty("dimension")]
    [JsonPropertyName("dimension")]
    public string Dimension;

    [JsonProperty("residents")]
    [JsonPropertyName("residents")]
    public List<Characters> Characters;

    [JsonProperty("url")]
    [JsonPropertyName("url")]
    public string Url;

    [JsonProperty("created")]
    [JsonPropertyName("created")]
    public DateTime? Created;
}