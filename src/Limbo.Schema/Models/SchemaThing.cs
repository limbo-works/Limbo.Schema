using Limbo.Schema.Models.Actions;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

/// <summary>
/// The most generic type of item.
/// </summary>
/// <see href="https://schema.org/Thing"/>
public abstract class SchemaThing : SchemaObject {

    #region Properties

    [JsonProperty("@id", Order = -999, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; }

    [JsonProperty("@type", Order = -998)]
    public string Type { get; }

    [JsonProperty("url", Order = -599, NullValueHandling = NullValueHandling.Ignore)]
    public SchemaUrl? Url { get; set; }

    [JsonProperty("name", Order = -598, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("alternateName", Order = -597, NullValueHandling = NullValueHandling.Ignore)]
    public SchemaTextList AlternateNames { get; set; } = [];

    [JsonProperty("description", Order = -596, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("identifier")]
    public SchemaIdentifierList Identifiers { get; set; } = [];

    [JsonProperty("sameAs")]
    public SchemaUrlList SameAs { get; set; } = [];

    [JsonProperty("potentialAction")]
    public SchemaActionList PotentialActions { get; set; } = [];

    [JsonProperty("mainEntityOfPage", NullValueHandling = NullValueHandling.Ignore)]
    public IMainEntity? MainEntityOfPage { get; set; }

    #endregion

    #region Constructors

    protected SchemaThing(string type) {
        Type = type;
    }

    #endregion

    #region Member methods

    public bool ShouldSerializeIdentifiers() => ShouldSerialize(Identifiers);

    public bool ShouldSerializeSameAs() => ShouldSerialize(SameAs);

    public bool ShouldSerializePotentialActions() => ShouldSerialize(PotentialActions);

    public bool ShouldSerializeAlternateNames() => ShouldSerialize(AlternateNames);

    #endregion

}