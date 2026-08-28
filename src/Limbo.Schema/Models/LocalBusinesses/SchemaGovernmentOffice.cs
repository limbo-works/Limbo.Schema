namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A government office—for example, an IRS or DMV office.
/// </summary>
/// <see href="https://schema.org/GovernmentOffice"/>
public class SchemaGovernmentOffice : SchemaLocalBusiness {

    public new const string Type = "GovernmentOffice";

    #region Constructors

    public SchemaGovernmentOffice() : base(Type) { }

    public SchemaGovernmentOffice(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaGovernmentOffice Create() {
        return new SchemaGovernmentOffice();
    }

    #endregion

}