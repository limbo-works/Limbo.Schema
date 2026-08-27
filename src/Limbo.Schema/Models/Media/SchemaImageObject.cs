using Newtonsoft.Json;

namespace Limbo.Schema.Models.Media;

/// <summary>
/// Class representing an image object.
/// </summary>
/// <see href="https://schema.org/ImageObject"/>
public class SchemaImageObject : SchemaMediaObject {

    public new const string Type = "ImageObject";

    #region Properties

    /// <summary>
    /// Gets or sets the caption for this object.
    /// </summary>
    /// <see href="https://schema.org/caption"/>
    [JsonProperty("caption", NullValueHandling = NullValueHandling.Ignore)]
    public ICaption? Caption { get; set; }

    #endregion

    #region Constructors

    public SchemaImageObject() : base(Type) { }

    protected SchemaImageObject(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaImageObject Create() {
        return new SchemaImageObject();
    }

    #endregion

}