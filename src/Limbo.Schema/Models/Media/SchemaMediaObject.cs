using Newtonsoft.Json;

namespace Limbo.Schema.Models.Media;

/// <summary>
/// A media object, such as an image, video, audio, or text object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
/// </summary>
/// <see href="https://schema.org/MediaObject"/>
/// <see cref="SchemaImageObject"/>
public class SchemaMediaObject : SchemaCreativeWork, ICaption {

    public new const string Type = "MediaObject";

    #region Properties

    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; }

    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    public int? Height { get; set; }

    #endregion

    #region Constructors

    public SchemaMediaObject() : base(Type) { }

    protected SchemaMediaObject(string type) : base(type) { }

    #endregion

    #region Static methods

    public static new SchemaMediaObject Create() {
        return new SchemaMediaObject();
    }

    #endregion

}