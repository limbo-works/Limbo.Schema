using System.Collections.Generic;
using Limbo.Schema.Json;
using Limbo.Schema.Models.Addresses;
using Newtonsoft.Json;

namespace Limbo.Schema.Models.Organizations;

public interface IOrganizationProperties : IOrganization {

    [JsonProperty("logo", NullValueHandling = NullValueHandling.Ignore)]
    string? Logo { get; set; }

    [JsonConverter(typeof(SchemaJsonConverter))]
    [JsonProperty("address")]
    SchemaAddressList Addresses { get; }

    [JsonProperty("contactPoint")]
    List<SchemaContactPoint> ContactPoints { get; }

    [JsonProperty("parentOrganization")]
    SchemaOrganizationList ParentOrganizations { get; }

    [JsonProperty("subOrganization")]
    SchemaOrganizationList SubOrganizations { get; }

    [JsonConverter(typeof(SchemaJsonConverter))]
    [JsonProperty("department")]
    SchemaOrganizationList Departments { get; }

}