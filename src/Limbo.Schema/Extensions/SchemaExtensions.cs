using Limbo.Schema.Models;
using Limbo.Schema.Models.Actions;
using Skybrud.Essentials.Strings.Extensions;

namespace Limbo.Schema.Extensions;

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

    public static T WithMainEntityOfPage<T>(this T thing, IMainEntity? value) where T : SchemaThing {
        thing.MainEntityOfPage = value;
        return thing;
    }

    public static T AddPotentialAction<T>(this T thing, SchemaAction? action) where T : SchemaThing {
        if (action is not null) thing.PotentialActions.Add(action);
        return thing;
    }

}