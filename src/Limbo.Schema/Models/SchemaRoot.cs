using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Limbo.Schema.Models;

public class SchemaRoot {

    public string? Hid { get; set; }

    public required SchemaThing Value { get; set; }

    public SchemaRoot() { }

    [SetsRequiredMembers]
    public SchemaRoot(string hid, SchemaThing value) {
        Hid = hid;
        Value = value;
    }

    public string GetInnerHtml() {
        JObject json = JObject.FromObject(Value);
        json.AddFirst(new JProperty("@context", "http://schema.org"));
        return json.ToString(Formatting.Indented);
    }

}