using System.Collections.Generic;
using Limbo.Schema.Json;
using Limbo.Schema.Models.Addresses;
using Limbo.Schema.Models.Organizations;
using Limbo.Schema.Models.Places;
using Newtonsoft.Json;

namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A particular physical business or branch of an organization. Examples of <c>LocalBusiness</c> include a restaurant,
/// a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
/// </summary>
/// <see href="https://schema.org/LocalBusiness"/>
public class SchemaLocalBusiness : SchemaThing, IOrganization, IPlaceProperties {

    public new const string Type = "LocalBusiness";

    #region Properties

    [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; }

    [JsonProperty("contactPoint")]
    public List<SchemaContactPoint> ContactPoints { get; set; } = [];

    [JsonProperty("parentOrganization")]
    public SchemaOrganizationList ParentOrganizations { get; set; } = [];

    [JsonProperty("subOrganization")]
    public SchemaOrganizationList SubOrganizations { get; set; } = [];

    [JsonConverter(typeof(SchemaJsonConverter))]
    [JsonProperty("department")]
    public SchemaOrganizationList Departments { get; set; } = [];

    [JsonProperty("address")]
    public SchemaAddressList Addresses { get; set; } = [];

    [JsonProperty("containsPlace")]
    public SchemaPlaceList ContainsPlaces { get; set; } = [];

    #endregion

    #region Constructors

    public SchemaLocalBusiness() : base(Type) { }

    public SchemaLocalBusiness(string type) : base(type) { }

    #endregion

    #region Static methods

    public static SchemaLocalBusiness Create() {
        return new SchemaLocalBusiness();
    }

    #endregion

}