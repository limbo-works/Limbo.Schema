using Newtonsoft.Json;

namespace Limbo.Schema.Models.Actions;

/// <summary>
/// Class representing the act of searching for an object.
/// </summary>
/// <see>
///     <cref>https://schema.org/SearchAction</cref>
/// </see>
public class SchemaSearchAction : SchemaAction {

    public new const string Type = "SearchAction";

    [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
    public SchemaText? Query { get; set; }

    /// <summary>
    /// ¯\_(ツ)_/¯
    /// </summary>
    /// <remarks>
    /// <para>This isn't part of the specification, but is used in some places to represent the input for a query action.</para>
    /// <para>ChatGPT says: <c>query-input</c> is still part of Schema.org, still valid, but no longer SEO-impactful for Google specifically. It’s now mostly useful for completeness rather than rankings or rich features.</para>
    /// </remarks>
    [JsonProperty("query-input", NullValueHandling = NullValueHandling.Ignore)]
    public string? QueryInput { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaSearchAction"/> class.
    /// </summary>
    public SchemaSearchAction() : base(Type) { }

}