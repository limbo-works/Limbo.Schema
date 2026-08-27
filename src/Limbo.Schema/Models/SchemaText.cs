using System.Diagnostics.CodeAnalysis;
using Limbo.Schema.Models.Addresses;
using Limbo.Schema.Models.Keywords;
using Limbo.Schema.Models.Languages;
using Limbo.Schema.Models.Media;

namespace Limbo.Schema.Models;

public class SchemaText : SchemaDataType, IAddress, ICaption, IKeyword, ILanguage {

    public SchemaText() { }

    [SetsRequiredMembers]
    public SchemaText(string value) {
        Value = value;
    }

    public static implicit operator SchemaText(string value) => new() { Value = value };

}