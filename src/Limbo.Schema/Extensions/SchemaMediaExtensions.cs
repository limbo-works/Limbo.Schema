using Limbo.Schema.Models;
using Limbo.Schema.Models.Media;

namespace Limbo.Schema.Extensions;

public static class SchemaMediaExtensions {

    public static T WithWidth<T>(this T thing, int? width) where T : SchemaMediaObject {
        thing.Width = width;
        return thing;
    }

    public static T WithHeight<T>(this T thing, int? height) where T : SchemaMediaObject {
        thing.Height = height;
        return thing;
    }

    public static T WithCaption<T>(this T thing, string? value) where T : SchemaImageObject {
        if (string.IsNullOrWhiteSpace(value)) return thing;
        thing.Caption = new SchemaText(value);
        return thing;
    }

    public static T WithCaption<T>(this T thing, ICaption? value) where T : SchemaImageObject {
        thing.Caption = value;
        return thing;
    }

}