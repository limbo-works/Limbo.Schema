namespace Limbo.Schema.Models.LocalBusinesses;

/// <summary>
/// A food-related business.
/// </summary>
/// <see href="https://schema.org/FoodEstablishment"/>
public class SchemaFoodEstablishment : SchemaLocalBusiness {

    public new const string Type = "FoodEstablishment";

    #region Constructors

    public SchemaFoodEstablishment() : base(Type) { }

    public SchemaFoodEstablishment(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaFoodEstablishment Create() {
        return new SchemaFoodEstablishment();
    }

    #endregion

}