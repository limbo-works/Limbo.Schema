using Limbo.Schema.Models;
using Limbo.Schema.Models.Publishers;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Essentials.Time;

namespace Limbo.Schema.Extensions;

public static class SchemaCreativeWorkExtensions {

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

    public static T WithCreditText<T>(this T thing, string? value) where T : SchemaCreativeWork {
        thing.CreditText = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithIsPartOf<T>(this T thing, IPartOf? value) where T : SchemaCreativeWork {
        thing.IsPartOf.Clear();
        if (value is not null) thing.IsPartOf = [value];
        return thing;
    }

}
