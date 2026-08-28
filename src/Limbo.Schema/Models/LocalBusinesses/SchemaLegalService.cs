namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A <c>LegalService</c> is a business that provides legally-oriented services, advice and representation, e.g. law firms.
/// </summary>
/// <see href="https://schema.org/LegalService"/>
public class SchemaLegalService : SchemaLocalBusiness {

    public new const string Type = "LegalService";

    #region Constructors

    public SchemaLegalService() : base(Type) { }

    public SchemaLegalService(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaLegalService Create() {
        return new SchemaLegalService();
    }

    #endregion

}