using System.Diagnostics.CodeAnalysis;
using Limbo.Schema.Json;
using Newtonsoft.Json;
using Skybrud.Essentials.Time;

namespace Limbo.Schema.Models;

/// <summary>
/// A combination of date and time of day.
/// </summary>
/// <see>
///     <cref>https://schema.org/DateTime</cref>
/// </see>
[JsonConverter(typeof(SchemaJsonConverter))]
public class SchemaDateTime : IDate {

    public required EssentialsTime Value { get; set; }

    public SchemaDateTime() { }

    [SetsRequiredMembers]
    public SchemaDateTime(EssentialsTime value) {
        Value = value;
    }

    public static implicit operator SchemaDateTime(EssentialsTime value) => new(value);

}