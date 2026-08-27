using System.Collections.Generic;

namespace Limbo.Schema.Models.Addresses;

public class SchemaAddressList : SchemaList<IAddress> {

    public SchemaAddressList() { }

    public SchemaAddressList(IEnumerable<IAddress> items) : base(items) { }

    public SchemaAddressList(IAddress item) {
        Add(item);
    }

    public static implicit operator SchemaAddressList(SchemaPostalAddress item) => new(item);

    public static implicit operator SchemaAddressList(SchemaText item) => new(item);

}