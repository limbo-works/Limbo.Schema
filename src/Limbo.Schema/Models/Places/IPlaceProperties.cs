using Limbo.Schema.Models.Addresses;
using Newtonsoft.Json;

namespace Limbo.Schema.Models.Places;

public interface IPlaceProperties : IPlace {

    [JsonProperty("address")]
    SchemaAddressList Addresses { get; }

    [JsonProperty("containsPlace")]
    SchemaPlaceList ContainsPlaces { get; }

}