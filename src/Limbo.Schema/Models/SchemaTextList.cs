using System.Collections.Generic;

namespace Limbo.Schema.Models;

public class SchemaTextList : SchemaList<SchemaText> {

    public SchemaTextList() { }

    public SchemaTextList(IEnumerable<SchemaText> items) : base(items) { }

    public SchemaTextList(SchemaText item) {
        Add(item);
    }

    public static implicit operator SchemaTextList(SchemaText item) => new(item);

    public static implicit operator SchemaTextList(string text) => new(new SchemaText(text));

}