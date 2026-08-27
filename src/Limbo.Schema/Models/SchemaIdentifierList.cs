using System.Collections.Generic;

namespace Limbo.Schema.Models;

public class SchemaIdentifierList : SchemaList<SchemaIdentifier> {

    public SchemaIdentifierList() { }

    public SchemaIdentifierList(IEnumerable<SchemaIdentifier> items) : base(items) { }

    public SchemaIdentifierList(SchemaIdentifier item) {
        Add(item);
    }

    public static implicit operator SchemaIdentifierList(SchemaIdentifier item) => new(item);

}