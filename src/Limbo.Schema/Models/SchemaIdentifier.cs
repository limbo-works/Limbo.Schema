using Newtonsoft.Json;

namespace Limbo.Schema.Models;

public class SchemaIdentifier {

    [JsonProperty("@type")]
    public string Type => "PropertyValue";

    [JsonProperty("propertyID")]
    public required string PropertyId { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("value")]
    public required string Value { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; }

}