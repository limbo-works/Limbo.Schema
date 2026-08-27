using Newtonsoft.Json;

namespace Limbo.Schema.Models.Addresses;

/// <summary>
/// The mailing address.
/// </summary>
/// <see>
///     <cref>https://schema.org/PostalAddress</cref>
/// </see>
public class SchemaPostalAddress : SchemaContactPoint, IAddress, ILocation {

    [JsonProperty("streetAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string? StreetAddress { get; set; }

    [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
    public string? PostalCode { get; set; }

    [JsonProperty("addressLocality", NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressLocality { get; set; }

    [JsonProperty("addressRegion", NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressRegion { get; set; }

    [JsonProperty("addressCountry", NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressCountry { get; set; }

    [JsonProperty("extendedAddress", NullValueHandling = NullValueHandling.Ignore)]
    public string? ExtendedAddress { get; set; }

    [JsonProperty("postOfficeBoxNumber", NullValueHandling = NullValueHandling.Ignore)]
    public string? PostOfficeBoxNumber { get; set; }

    public SchemaPostalAddress() : base("PostalAddress") { }

}