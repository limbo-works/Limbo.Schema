using Limbo.Schema.Models.Articles;
using Limbo.Schema.Models.Organizations;

namespace Limbo.Schema.Extensions;

public static class SchemaOrganizationExtensions {

    public static T WithArticleBody<T>(this T thing, string? value) where T : SchemaArticle {
        thing.ArticleBody = value;
        return thing;
    }

    public static T WithArticleSection<T>(this T thing, string? value) where T : SchemaArticle {
        thing.ArticleSection = value;
        return thing;
    }

    public static T AddParentOrganization<T>(this T thing, IOrganization? value) where T : SchemaOrganization {
        if (value is not null) thing.ParentOrganizations.Add(value);
        return thing;
    }

    public static T WithParentOrganization<T>(this T thing, IOrganization? value) where T : SchemaOrganization {
        thing.SubOrganizations.Clear();
        if (value is not null) thing.ParentOrganizations.Add(value);
        return thing;
    }

    public static T AddSubOrganization<T>(this T thing, IOrganization? value) where T : SchemaOrganization {
        if (value is not null) thing.SubOrganizations.Add(value);
        return thing;
    }

    public static T WithSubOrganization<T>(this T thing, IOrganization? value) where T : SchemaOrganization {
        thing.SubOrganizations.Clear();
        if (value is not null) thing.SubOrganizations.Add(value);
        return thing;
    }

}