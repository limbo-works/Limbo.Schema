using Limbo.Schema.Json;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

[JsonConverter(typeof(SchemaJsonConverter))]
public abstract class SchemaDataType {

    public required string Value { get; set; }

    protected SchemaDataType() { }

    protected SchemaDataType(string value) {
        Value = value;
    }

}