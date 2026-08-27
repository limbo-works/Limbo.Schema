using System.Diagnostics.CodeAnalysis;
using Limbo.Schema.Models.Addresses;
using Limbo.Schema.Models.Keywords;

namespace Limbo.Schema.Models;

/// <see>
///     <cref>https://schema.org/URL</cref>
/// </see>
public class SchemaUrl : SchemaDataType, IAddress, IKeyword, IPartOf, ITarget, IMainEntity {

    public SchemaUrl() { }

    [SetsRequiredMembers]
    public SchemaUrl(string value) {
        Value = value;
    }

    public static implicit operator SchemaUrl(string value) => new() { Value = value };

}