using Newtonsoft.Json;

namespace Limbo.Schema.Models.Keywords;

public interface IHasKeywords {

    [JsonProperty("keywords")]
    SchemaKeywordList Keywords { get; set; }

}