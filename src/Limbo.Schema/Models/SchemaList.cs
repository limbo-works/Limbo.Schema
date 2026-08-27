using System.Collections.Generic;
using Limbo.Schema.Json;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

[JsonConverter(typeof(SchemaJsonConverter))]
public class SchemaList<T> : List<T> {

    public SchemaList() { }

    public SchemaList(IEnumerable<T> items) {
        AddRange(items);
    }

}