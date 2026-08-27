using System.Collections.Generic;

namespace Limbo.Schema.Models.Organizations;

/// <summary>
/// Class representing a list of <see cref="IOrganization"/> items.
/// </summary>
/// <see href="https://schema.org/Organization"/>
public class SchemaOrganizationList : SchemaList<IOrganization> {

    public SchemaOrganizationList() { }

    public SchemaOrganizationList(IEnumerable<IOrganization> items) : base(items) { }

    public SchemaOrganizationList(IOrganization item) {
        Add(item);
    }

    public static implicit operator SchemaOrganizationList(SchemaOrganization item) => new(item);

}