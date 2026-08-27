using System.Diagnostics.CodeAnalysis;
using Limbo.Schema.Json;
using Newtonsoft.Json;
using Skybrud.Essentials.Time;

namespace Limbo.Schema.Models;

/// <summary>
/// A date value in ISO 8601 date format.
/// </summary>
/// <see>
///     <cref>https://schema.org/Date</cref>
/// </see>

[JsonConverter(typeof(SchemaJsonConverter))]
public class SchemaDate : IDate {

    public required EssentialsDate Value { get; set; }

    public SchemaDate() { }

    [SetsRequiredMembers]
    public SchemaDate(EssentialsDate value) {
        Value = value;
    }

    public static implicit operator SchemaDate(EssentialsDate value) => new() { Value = value };

}