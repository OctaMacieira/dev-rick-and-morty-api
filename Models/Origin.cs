// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace dev_rick_and_morty_api.Models;

public class Origin
{
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name;

    [JsonProperty("url")]
    [JsonPropertyName("url")]
    public string Url;
}