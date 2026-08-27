using System.Collections.Generic;
using Limbo.Schema.Models.Organizations;
using Limbo.Schema.Models.People;

namespace Limbo.Schema.Models.Authors;

public class SchemaAuthorList : SchemaList<IAuthor> {

    public SchemaAuthorList() { }

    public SchemaAuthorList(IEnumerable<IAuthor> items) : base(items) { }

    public SchemaAuthorList(IAuthor item) {
        Add(item);
    }

    public static implicit operator SchemaAuthorList(SchemaOrganization item) => new(item);

    public static implicit operator SchemaAuthorList(SchemaPerson item) => new(item);

    public static implicit operator SchemaAuthorList(SchemaReference item) => new(item);

}