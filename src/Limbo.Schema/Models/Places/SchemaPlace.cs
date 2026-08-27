using Limbo.Schema.Models.Addresses;
using Newtonsoft.Json;

namespace Limbo.Schema.Models.Places;

/// <summary>
/// Entities that have a somewhat fixed, physical extension.
/// </summary>
/// <see href="https://schema.org/Place"/>
public class SchemaPlace : SchemaThing, IPlace {

    #region Properties

    [JsonProperty("address")]
    public SchemaAddressList Addresses { get; set; } = [];

    [JsonProperty("containsPlace")]
    public SchemaPlaceList ContainsPlaces { get; set; } = [];

    #endregion

    #region Constructors

    public SchemaPlace() : base("Place") { }

    public SchemaPlace(string type) : base(type) { }

    #endregion

    #region Member methods

    public bool ShouldSerializeAddresses() => ShouldSerialize(Addresses);

    public bool ShouldSerializeContainsPlaces() => ShouldSerialize(ContainsPlaces);

    #endregion

    #region Static methods

    public static SchemaPlace Create() {
        return new SchemaPlace();
    }

    #endregion

}