using System.Collections.Generic;

namespace Limbo.Schema.Models.Places;

/// <summary>
/// Class representing a list of <see cref="IPlace"/> items.
/// </summary>
/// <see href="https://schema.org/Place"/>
public class SchemaPlaceList : SchemaList<IPlace> {

    public SchemaPlaceList() { }

    public SchemaPlaceList(IEnumerable<IPlace> items) : base(items) { }

    public SchemaPlaceList(IPlace item) {
        Add(item);
    }

    public static implicit operator SchemaPlaceList(SchemaPlace item) => new(item);

}