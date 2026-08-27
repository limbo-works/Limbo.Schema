using Limbo.Schema.Models.Articles;

namespace Limbo.Schema.Extensions;

public static class SchemaArticleExtensions {

    public static T WithArticleBody<T>(this T thing, string? value) where T : SchemaArticle {
        thing.ArticleBody = value;
        return thing;
    }

    public static T WithArticleSection<T>(this T thing, string? value) where T : SchemaArticle {
        thing.ArticleSection = value;
        return thing;
    }

}