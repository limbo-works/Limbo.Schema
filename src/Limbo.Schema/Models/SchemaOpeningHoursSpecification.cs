using System;
using System.Collections.Generic;
using Limbo.Schema.Json;
using Newtonsoft.Json;

namespace Limbo.Schema.Models;

public class SchemaOpeningHoursSpecification {

    [JsonProperty("@type")]
    public string Type => "OpeningHoursSpecification";

    [JsonProperty("dayOfWeek")]
    [JsonConverter(typeof(SchemaJsonConverter))]
    public List<DayOfWeek> DayOfWeek { get; set; }

    [JsonProperty("opens")]
    public string Opens { get; set; }

    [JsonProperty("closes")]
    public string Closes { get; set; }

    public SchemaOpeningHoursSpecification(DayOfWeek dayOfWeek, string opens, string closes) {
        DayOfWeek = [dayOfWeek];
        Opens = opens;
        Closes = closes;
    }

}