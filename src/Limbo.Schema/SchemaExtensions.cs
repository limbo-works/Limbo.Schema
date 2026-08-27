using System.Collections.Generic;
using System.Linq;
using Limbo.Schema.Models;
using Limbo.Schema.Models.Actions;
using Limbo.Schema.Models.Addresses;
using Limbo.Schema.Models.Articles;
using Limbo.Schema.Models.Jobs;
using Limbo.Schema.Models.Keywords;
using Limbo.Schema.Models.Organizations;
using Limbo.Schema.Models.Places;
using Limbo.Schema.Models.Publishers;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Essentials.Time;

namespace Limbo.Schema;

public static class SchemaExtensions {

    public static T WithId<T>(this T thing, string? id) where T : SchemaThing {
        thing.Id = id.NullIfWhiteSpace();
        return thing;
    }

    public static T WithName<T>(this T thing, string? value) where T : SchemaThing {
        thing.Name = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithDescription<T>(this T thing, string? value) where T : SchemaThing {
        thing.Description = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithUrl<T>(this T thing, string? url) where T : SchemaThing {
        thing.Url = string.IsNullOrWhiteSpace(url) ? null : new SchemaUrl(url);
        return thing;
    }

    public static T WithHeadline<T>(this T thing, string? value) where T : SchemaCreativeWork {
        thing.Headline = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithDateCreated<T>(this T thing, EssentialsDate? value) where T : SchemaCreativeWork {
        thing.DateCreated = value is null ? null : new SchemaDate(value);
        return thing;
    }

    public static T WithDateCreated<T>(this T thing, EssentialsTime? value) where T : SchemaCreativeWork {
        thing.DateCreated = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithDateModified<T>(this T thing, EssentialsDate? value) where T : SchemaCreativeWork {
        thing.DateModified = value is null ? null : new SchemaDate(value);
        return thing;
    }

    public static T WithDateModified<T>(this T thing, EssentialsTime? value) where T : SchemaCreativeWork {
        thing.DateModified = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithDatePublished<T>(this T thing, EssentialsDate? value) where T : SchemaCreativeWork {
        thing.DatePublished = value is null ? null : new SchemaDate(value);
        return thing;
    }

    public static T WithDatePublished<T>(this T thing, EssentialsTime? value) where T : SchemaCreativeWork {
        thing.DatePublished = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithExpires<T>(this T thing, EssentialsDate? value) where T : SchemaCreativeWork {
        thing.Expires = value is null ? null : new SchemaDate(value);
        return thing;
    }

    public static T WithExpires<T>(this T thing, EssentialsTime? value) where T : SchemaCreativeWork {
        thing.Expires = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithPublisher<T>(this T thing, IPublisher? value) where T : SchemaCreativeWork {
        thing.Publishers = value is null ? [] : [value];
        return thing;
    }

    public static T WithInLanguages<T>(this T thing, string? value) where T : SchemaCreativeWork {
        thing.InLanguages = value is null ? [] : [new SchemaText(value)];
        return thing;
    }

    public static T WithKeywords<T>(this T thing, IEnumerable<string>? value) where T : IHasKeywords {
        thing.Keywords = value is null ? [] : [.. value.Select(x => new SchemaText(x))];
        return thing;
    }

    public static T WithKeywords<T>(this T thing, IEnumerable<IKeyword>? value) where T : IHasKeywords {
        thing.Keywords = value is null ? [] : [.. value];
        return thing;
    }

    public static T WithAddress<T>(this T thing, string? value) where T : SchemaPlace {
        thing.Addresses.Clear();
        if (!string.IsNullOrWhiteSpace(value)) thing.Addresses.Add(new SchemaText(value));
        return thing;
    }

    public static T WithAddress<T>(this T thing, IAddress? value) where T : SchemaPlace {
        thing.Addresses.Clear();
        if (value is not null) thing.Addresses.Add(value);
        return thing;
    }

    public static T WithMainEntityOfPage<T>(this T thing, IMainEntity? value) where T : SchemaThing {
        thing.MainEntityOfPage = value;
        return thing;
    }

    public static T WithArticleBody<T>(this T thing, string? value) where T : SchemaArticle {
        thing.ArticleBody = value;
        return thing;
    }

    public static T WithArticleSection<T>(this T thing, string? value) where T : SchemaArticle {
        thing.ArticleSection = value;
        return thing;
    }

    public static T WithTitle<T>(this T thing, string? value) where T : SchemaJobPosting {
        thing.Title = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithDatePosted<T>(this T thing, EssentialsDate? value) where T : SchemaJobPosting {
        thing.DatePosted = value is null ? null : new SchemaDate(value);
        return thing;
    }

    public static T WithDatePosted<T>(this T thing, EssentialsTime? value) where T : SchemaJobPosting {
        thing.DatePosted = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithEmploymentType<T>(this T thing, string? value) where T : SchemaJobPosting {
        thing.EmploymentType = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithEmploymentUnit<T>(this T thing, IOrganization? value) where T : SchemaJobPosting {
        thing.EmploymentUnit = value;
        return thing;
    }

    public static T WithHiringOrganization<T>(this T thing, IOrganization? value) where T : SchemaJobPosting {
        thing.HiringOrganization = value;
        return thing;
    }

    public static T WithJobStartDate<T>(this T thing, EssentialsDate? value) where T : SchemaJobPosting {
        thing.JobStartDate = value is null ? null : new SchemaDate(value);
        return thing;
    }

    public static T WithJobStartDate<T>(this T thing, EssentialsTime? value) where T : SchemaJobPosting {
        thing.JobStartDate = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithJobLocation<T>(this T thing, string? value) where T : SchemaJobPosting {
        thing.JobLocation.Clear();
        if (!string.IsNullOrWhiteSpace(value)) thing.JobLocation.Add(SchemaPlace.Create().WithName(value));
        return thing;
    }

    public static T WithJobLocation<T>(this T thing, SchemaPlace? value) where T : SchemaJobPosting {
        thing.JobLocation.Clear();
        if (value is not null) thing.JobLocation.Add(value);
        return thing;
    }

    public static T WithJobLocation<T>(this T thing, IEnumerable<SchemaPlace>? value) where T : SchemaJobPosting {
        thing.JobLocation.Clear();
        if (value is not null) thing.JobLocation.AddRange(value);
        return thing;
    }

    public static T WithValidThrough<T>(this T thing, EssentialsTime? value) where T : SchemaJobPosting {
        thing.ValidThrough = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T AddPotentialAction<T>(this T thing, SchemaAction? action) where T : SchemaThing {
        if (action is not null) thing.PotentialActions.Add(action);
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