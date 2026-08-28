namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A library.
/// </summary>
/// <see href="https://schema.org/Library"/>
public class SchemaLibrary : SchemaLocalBusiness {

    public new const string Type = "Library";

    #region Constructors

    public SchemaLibrary() : base(Type) { }

    public SchemaLibrary(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaLibrary Create() {
        return new SchemaLibrary();
    }

    #endregion

}