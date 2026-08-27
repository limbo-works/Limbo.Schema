using System.Collections.Generic;

namespace Limbo.Schema.Models.Actions;

/// <summary>
/// Class representing a list of <see cref="SchemaAction"/> objects.
/// </summary>
public class SchemaActionList : SchemaList<SchemaAction> {

    /// <summary>
    /// Initializes a new, empty instance of the <see cref="SchemaActionList"/> class.
    /// </summary>
    public SchemaActionList() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaActionList"/> class containing the specified schema actions.
    /// </summary>
    /// <param name="items">The collection of schema actions used to populate the list.</param>
    public SchemaActionList(IEnumerable<SchemaAction> items) : base(items) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaActionList"/> class containing the specified schema action.
    /// </summary>
    /// <param name="item">The schema action to add to the list.</param>
    public SchemaActionList(SchemaAction item) {
        Add(item);
    }

    /// <summary>
    /// Implicitly converts a <see cref="SchemaAction"/> to a <see cref="SchemaActionList"/> containing the specified schema action.
    /// </summary>
    /// <param name="item">The schema action to convert.</param>
    /// <returns>
    /// A new <see cref="SchemaActionList"/> containing the specified schema action.
    /// </returns>
    public static implicit operator SchemaActionList(SchemaAction item) => new(item);

}