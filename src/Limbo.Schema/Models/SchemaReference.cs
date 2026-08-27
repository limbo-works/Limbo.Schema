using System.Diagnostics.CodeAnalysis;
using Limbo.Schema.Models.Authors;
using Limbo.Schema.Models.Organizations;
using Limbo.Schema.Models.Publishers;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

public class SchemaReference : IAuthor, IOrganizer, IPartOf, IPublisher, IMainEntity, IOrganization {

    [JsonProperty("@id")]
    public required string Id { get; set; }

    public SchemaReference() { }

    [SetsRequiredMembers]
    public SchemaReference(string id) {
        Id = id;
    }

}