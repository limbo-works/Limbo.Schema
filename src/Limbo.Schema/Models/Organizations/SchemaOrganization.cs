using System.Collections.Generic;
using Limbo.Schema.Json;
using Limbo.Schema.Models.Addresses;
using Newtonsoft.Json;

namespace Limbo.Schema.Models.Organizations;

/// <summary>
/// An organization such as a school, NGO, corporation, club, etc.
/// </summary>
/// <see href="https://schema.org/Organization"/>
public class SchemaOrganization : SchemaThing, IOrganization {

    public new const string Type = "Organization";

    #region Properties

    [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; }

    [JsonConverter(typeof(SchemaJsonConverter))]
    [JsonProperty("address")]
    public SchemaAddressList Addresses { get; set; } = [];

    [JsonProperty("contactPoint")]
    public List<SchemaContactPoint> ContactPoints { get; set; } = [];

    [JsonProperty("parentOrganization")]
    public SchemaOrganizationList ParentOrganizations { get; set; } = [];

    [JsonProperty("subOrganization")]
    public SchemaOrganizationList SubOrganizations { get; set; } = [];

    [JsonConverter(typeof(SchemaJsonConverter))]
    [JsonProperty("department")]
    public SchemaOrganizationList Departments { get; set; } = [];

    #endregion

    #region Constructors

    public SchemaOrganization() : base("Organization") { }

    public SchemaOrganization(string type) : base(type) { }

    #endregion

    #region Member methods

    public bool ShouldSerializeAddresses() => ShouldSerialize(Addresses);

    public bool ShouldSerializeContactPoints() {
        return ContactPoints.Count > 0;
    }

    public bool ShouldSerializeParentOrganizations() {
        return ParentOrganizations.Count > 0;
    }

    public bool ShouldSerializeSubOrganizations() {
        return SubOrganizations.Count > 0;
    }

    public bool ShouldSerializeDepartments() {
        return Departments.Count > 0;
    }

    #endregion

    #region Static methods

    public static SchemaOrganization Create() {
        return new SchemaOrganization();
    }

    #endregion

}