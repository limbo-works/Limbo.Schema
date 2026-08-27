using System;
using System.Collections.Generic;
using Limbo.Schema.Models.Languages;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

/// <summary>
/// A contact point—for example, a Customer Complaints department.
/// </summary>
/// <see href="https://schema.org/ContactPoint"/>
public class SchemaContactPoint : SchemaThing {

    #region Properties

    [JsonProperty("contactType", NullValueHandling = NullValueHandling.Ignore)]
    public string? ContactType { get; set; }

    [JsonProperty("telephone", NullValueHandling = NullValueHandling.Ignore)]
    public string? Telephone { get; set; }

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; }

    [JsonProperty("availableLanguage", NullValueHandling = NullValueHandling.Ignore)]
    public SchemaLanguageList AvailableLanguages { get; set; } = [];

    [JsonProperty("hoursAvailable", NullValueHandling = NullValueHandling.Ignore)]
    public List<SchemaOpeningHoursSpecification> HoursAvailable { get; set; } = [];

    #endregion

    public SchemaContactPoint() : base("ContactPoint") { }

    public SchemaContactPoint(string type) : base(type) { }

    public SchemaContactPoint AddOpeningHours(DayOfWeek dayOfWeek, string opens, string closes) {
        HoursAvailable.Add(new SchemaOpeningHoursSpecification(dayOfWeek, opens, closes));
        return this;
    }

    public bool ShouldSerializeAvailableLanguages() => ShouldSerialize(AvailableLanguages);

    public bool ShouldSerializeHoursAvailable() => ShouldSerialize(HoursAvailable);

}