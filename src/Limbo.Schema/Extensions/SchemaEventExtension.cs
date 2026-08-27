using Limbo.Schema.Models;
using Limbo.Schema.Models.Events;
using Skybrud.Essentials.Time;

namespace Limbo.Schema.Extensions;

public static class SchemaEventExtension {

    public static T WithStartDate<T>(this T thing, EssentialsTime? value) where T : SchemaEvent {
        thing.StartDate = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithEndDate<T>(this T thing, EssentialsTime? value) where T : SchemaEvent {
        thing.EndDate = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

    public static T WithInLanguages<T>(this T thing, string? value) where T : SchemaEvent {
        thing.InLanguages = value is null ? [] : [new SchemaText(value)];
        return thing;
    }

    public static T WithLocation<T>(this T thing, ILocation? value) where T : SchemaEvent {
        thing.Location = value;
        return thing;
    }

    public static T WithOrganizer<T>(this T thing, IOrganizer? value) where T : SchemaEvent {
        thing.Organizer = value;
        return thing;
    }

}