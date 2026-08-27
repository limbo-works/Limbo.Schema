using Newtonsoft.Json;

namespace Limbo.Schema.Models.Articles;

/// <summary>
/// Class representing an article, which is a type of creative work that is typically published in a magazine, newspaper, or online platform. It contains properties specific to articles, such as the body of the article and the section it belongs to.
/// </summary>
/// <see href="https://schema.org/Article"/>
public class SchemaArticle : SchemaCreativeWork {

    public new const string Type = "Article";

    #region Properties

    /// <summary>
    /// Gets or sets the main textual content of the article.
    /// </summary>
    /// <see href="https://schema.org/articleBody"/>
    [JsonProperty("articleBody", NullValueHandling = NullValueHandling.Ignore)]
    public string? ArticleBody { get; set; }

    /// <summary>
    /// Represents the section of the article. Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
    /// </summary>
    /// <see href="https://schema.org/articleSection"/>
    [JsonProperty("articleSection", NullValueHandling = NullValueHandling.Ignore)]
    public string? ArticleSection { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaArticle"/> class.
    /// </summary>
    public SchemaArticle() : base(Type) { }

    /// <summary>
    /// Initializes a new instance of the SchemaArticle class with the specified type.
    /// </summary>
    /// <remarks>Intended for use by derived types.</remarks>
    /// <param name="type">The schema type identifier.</param>
    protected SchemaArticle(string type) : base(type) { }

    #endregion

    #region Static methods

    /// <summary>
    /// Creates a new <see cref="SchemaArticle"/> instance.
    /// </summary>
    /// <returns>A new instance of <see cref="SchemaArticle"/>.</returns>
    public static new SchemaArticle Create() {
        return new SchemaArticle();
    }

    #endregion

}