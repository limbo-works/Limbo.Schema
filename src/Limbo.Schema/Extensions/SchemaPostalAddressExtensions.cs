using Limbo.Schema.Models.Addresses;
using Skybrud.Essentials.Strings.Extensions;

namespace Limbo.Schema.Extensions;

public static class SchemaPostalAddressExtensions {

    public static T WithStreetAddress<T>(this T thing, string? value) where T : SchemaPostalAddress {
        thing.StreetAddress = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithPostalCode<T>(this T thing, string? value) where T : SchemaPostalAddress {
        thing.PostalCode = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithAddressLocality<T>(this T thing, string? value) where T : SchemaPostalAddress {
        thing.AddressLocality = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithAddressRegion<T>(this T thing, string? value) where T : SchemaPostalAddress {
        thing.AddressRegion = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithAddressCountry<T>(this T thing, string? value) where T : SchemaPostalAddress {
        thing.AddressCountry = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithExtendedAddress<T>(this T thing, string? value) where T : SchemaPostalAddress {
        thing.ExtendedAddress = value.NullIfWhiteSpace();
        return thing;
    }

    public static T WithPostOfficeBoxNumber<T>(this T thing, string? value) where T : SchemaPostalAddress {
        thing.PostOfficeBoxNumber = value.NullIfWhiteSpace();
        return thing;
    }

}