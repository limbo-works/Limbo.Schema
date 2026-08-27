using System.Collections.Generic;

namespace Limbo.Schema.Models;

public class SchemaUrlList : SchemaList<SchemaUrl> {

    public SchemaUrlList() { }

    public SchemaUrlList(IEnumerable<SchemaUrl> items) : base(items) { }

    public SchemaUrlList(SchemaUrl item) {
        Add(item);
    }

    public static implicit operator SchemaUrlList(SchemaUrl item) => new(item);

    public static implicit operator SchemaUrlList(string url) => new(new SchemaUrl(url));

}