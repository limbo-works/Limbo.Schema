using System.Collections.Generic;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

public class SchemaGraph : SchemaObject {

    [JsonProperty("@graph")]
    public List<SchemaThing> Items { get; } = [];

}