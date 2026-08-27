namespace Limbo.Schema.Models;

public class SchemaWebPage : SchemaCreativeWork {

    public new const string Type = "WebPage";

    #region Constructors

    public SchemaWebPage() : base(Type) { }

    #endregion

    #region Static methods

    public static new SchemaWebPage Create() {
        return new SchemaWebPage();
    }

    #endregion

}