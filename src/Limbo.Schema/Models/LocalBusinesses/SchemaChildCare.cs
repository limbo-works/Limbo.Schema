namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A Childcare center.
/// </summary>
/// <see href="https://schema.org/ChildCare"/>
public class SchemaChildCare : SchemaLocalBusiness {

    public new const string Type = "ChildCare";

    #region Constructors

    public SchemaChildCare() : base(Type) { }

    public SchemaChildCare(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaChildCare Create() {
        return new SchemaChildCare();
    }

    #endregion

}