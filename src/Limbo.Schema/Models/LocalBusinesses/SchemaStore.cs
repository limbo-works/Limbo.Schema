namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A retail good store.
/// </summary>
/// <see href="https://schema.org/Store"/>
public class SchemaStore : SchemaLocalBusiness {

    public new const string Type = "Store";

    #region Constructors

    public SchemaStore() : base(Type) { }

    public SchemaStore(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaStore Create() {
        return new SchemaStore();
    }

    #endregion

}