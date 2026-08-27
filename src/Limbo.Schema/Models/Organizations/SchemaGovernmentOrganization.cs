namespace Limbo.Schema.Models.Organizations;

/// <summary>
/// A governmental organization or agency.
/// </summary>
/// <see href="https://schema.org/GovernmentOrganization"/>
public class SchemaGovernmentOrganization : SchemaOrganization {

    public new const string Type = "GovernmentOrganization";

    #region Constructors

    public SchemaGovernmentOrganization() : base(Type) { }

    #endregion

    #region Static methods

    public static new SchemaGovernmentOrganization Create() {
        return new SchemaGovernmentOrganization();
    }

    #endregion

}