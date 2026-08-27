namespace Limbo.Schema.Models.Languages;

/// <summary>
/// Natural languages such as Spanish, Tamil, Hindi, English etc.
/// </summary>
/// <see href="https://schema.org/Language"/>
/// <see cref="ILanguage"/>
/// <see cref="SchemaLanguageList"/>
public class SchemaLanguage : SchemaThing, ILanguage {

    public SchemaLanguage() : base("Language") { }

}