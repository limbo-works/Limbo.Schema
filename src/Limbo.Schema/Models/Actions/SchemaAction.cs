using Newtonsoft.Json;

namespace Limbo.Schema.Models.Actions;

/// <summary>
/// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.
/// </summary>
/// <see href="https://schema.org/Action"/>
public class SchemaAction : SchemaThing {

    public new const string Type = "Action";

    /// <summary>
    /// Indicates a target <see cref="SchemaEntryPoint"/>, or <see cref="SchemaUrl"/>, for an Action.
    /// </summary>
    [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
    public ITarget? Target { get; set; }

    public SchemaAction() : base(Type) { }

    protected SchemaAction(string type) : base(type) { }

}