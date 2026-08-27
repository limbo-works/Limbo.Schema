namespace Limbo.Schema.Models.Articles;

/// <summary>
/// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
/// </summary>
/// <see href="https://schema.org/NewsArticle"/>
public class SchemaNewsArticle : SchemaArticle {

    public new const string Type = "NewsArticle";

    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaNewsArticle"/> class.
    /// </summary>
    public SchemaNewsArticle() : base(Type) { }

    /// <summary>
    /// Creates a new <see cref="SchemaNewsArticle"/> instance.
    /// </summary>
    /// <returns>A new instance of <see cref="SchemaNewsArticle"/>.</returns>
    public static new SchemaNewsArticle Create() {
        return new SchemaNewsArticle();
    }

}