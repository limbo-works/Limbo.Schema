using System.Collections.Generic;

namespace Limbo.Schema.Models;

public abstract class SchemaObject {

    protected static bool ShouldSerialize<T>(ICollection<T> collection) => collection.Count > 0;

}