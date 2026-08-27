using System.Collections.Generic;
using Limbo.Schema.Models.Organizations;

namespace Limbo.Schema.Models.Publishers;

public class SchemaPublisherList : SchemaList<IPublisher> {

    public SchemaPublisherList() { }

    public SchemaPublisherList(IEnumerable<IPublisher> items) : base(items) { }

    public SchemaPublisherList(IPublisher item) {
        Add(item);
    }

    public static implicit operator SchemaPublisherList(SchemaOrganization item) => new(item);

    public static implicit operator SchemaPublisherList(SchemaReference item) => new(item);

}