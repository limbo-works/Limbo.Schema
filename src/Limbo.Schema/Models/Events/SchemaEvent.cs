using Limbo.Schema.Models.Keywords;
using Limbo.Schema.Models.Languages;
using Newtonsoft.Json;

namespace Limbo.Schema.Models.Events;

/// <summary>
/// An event happening at a certain time and location, such as a concert, lecture, or festival.
/// </summary>
/// <see href="https://schema.org/Event"/>
public class SchemaEvent : SchemaThing, IHasKeywords {

    public new const string Type = "Event";

    #region Properties

    /// <summary>
    /// The start date and time of the item.
    /// </summary>
    [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? StartDate { get; set; }

    /// <summary>
    /// The end date and time of the item.
    /// </summary>
    [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
    public IDate? EndDate { get; set; }

    /// <summary>
    /// The location of, for example, where an event is happening, where an organization is located, or where an action takes place.
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public ILocation? Location { get; set; }

    /// <summary>
    /// An organizer of an Event.
    /// </summary>
    [JsonProperty("organizer", NullValueHandling = NullValueHandling.Ignore)]
    public IOrganizer? Organizer { get; set; }

    /// <summary>
    /// The language of the content or performance or used in an action.
    /// </summary>
    [JsonProperty("inLanguage")]
    public SchemaLanguageList InLanguages { get; set; } = [];

    /// <summary>
    /// Keywords or tags used to describe some item.
    /// </summary>
    [JsonProperty("keywords")]
    public SchemaKeywordList Keywords { get; set; } = [];

    #endregion

    #region Constructors

    public SchemaEvent() : base("Event") { }

    #endregion

    #region Member methods

    public bool ShouldSerializeInLanguages() {
        return InLanguages.Count > 0;
    }

    public bool ShouldSerializeInKeywords() {
        return Keywords.Count > 0;
    }

    #endregion

    #region Static methods

    public static SchemaEvent Create() {
        return new SchemaEvent();
    }

    #endregion

}