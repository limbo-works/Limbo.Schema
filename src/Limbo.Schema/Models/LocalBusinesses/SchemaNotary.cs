namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A notary.
/// </summary>
/// <see href="https://schema.org/Notary"/>
public class SchemaNotary : SchemaLegalService {

    public new const string Type = "Notary";

    #region Constructors

    public SchemaNotary() : base(Type) { }

    public SchemaNotary(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaNotary Create() {
        return new SchemaNotary();
    }

    #endregion

}