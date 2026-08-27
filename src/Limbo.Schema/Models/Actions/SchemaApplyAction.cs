namespace Limbo.Schema.Models.Actions;

/// <summary>
/// The act of registering to an organization/service without the guarantee to receive it.
/// </summary>
/// <see href="https://schema.org/ApplyAction"/>
public class SchemaApplyAction : SchemaAction {

    public new const string Type = "ApplyAction";

    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaApplyAction"/> class.
    /// </summary>
    public SchemaApplyAction() : base(Type) { }

    /// <summary>
    /// Creates a new instance of the <see cref="SchemaApplyAction"/> class with the specified target.
    /// </summary>
    /// <param name="target">The target of the action.</param>
    /// <returns>A new instance of the <see cref="SchemaApplyAction"/> class.</returns>
    public static SchemaApplyAction Create(ITarget? target = null) {
        return new SchemaApplyAction {
            Target = target
        };
    }

}