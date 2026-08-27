using System.Collections.Generic;
using Limbo.Schema.Models;
using Limbo.Schema.Models.Jobs;
using Limbo.Schema.Models.Organizations;
using Limbo.Schema.Models.Places;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Essentials.Time;

namespace Limbo.Schema.Extensions;

public static class SchemaJobPostingExtension {

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

    public static T WithValidThrough<T>(this T thing, EssentialsDate? value) where T : SchemaJobPosting {
        thing.ValidThrough = value is null ? null : new SchemaDate(value);
        return thing;
    }

    public static T WithValidThrough<T>(this T thing, EssentialsTime? value) where T : SchemaJobPosting {
        thing.ValidThrough = value is null ? null : new SchemaDateTime(value);
        return thing;
    }

}