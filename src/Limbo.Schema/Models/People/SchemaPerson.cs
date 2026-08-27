using Limbo.Schema.Models.Authors;

namespace Limbo.Schema.Models.People;

public class SchemaPerson : SchemaThing, IAuthor {

    public new const string Type = "Person";

    public SchemaPerson() : base(Type) { }

}