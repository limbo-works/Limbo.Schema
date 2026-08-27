using System;
using System.Collections.Generic;
using Limbo.Schema.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Strings;

namespace Limbo.Schema.Json;

public class SchemaJsonConverter : JsonConverter {

    /// <summary>
    /// Writes the JSON representation of the object.
    /// </summary>
    /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
    /// <param name="value">The value.</param>
    /// <param name="serializer">The calling serializer.</param>
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) {

        if (value == null) {
            writer.WriteNull();
            return;
        }

        if (value is DayOfWeek dayOfWeek) {
            writer.WriteValue(dayOfWeek);
            return;
        }

        if (value is SchemaDate date) {
            writer.WriteValue(JToken.FromObject(date.Value));
            return;
        }

        if (value is SchemaDateTime dateTime) {
            writer.WriteValue(JToken.FromObject(dateTime.Value));
            return;
        }

        if (value is SchemaDataType dt) {
            writer.WriteValue(dt.Value);
            return;
        }

        if (value is List<DayOfWeek> daysOfWeek) {
            if (daysOfWeek.Count == 1) {
                writer.WriteValue(daysOfWeek[0].ToString());
            } else {
                JArray array = [];
                foreach (DayOfWeek day in daysOfWeek) {
                    array.Add(day.ToString());
                }
                array.WriteTo(writer);
            }
            return;
        }

        if (IsSchemaListType(value.GetType())) {
            JArray array = [];
            foreach (object item in (IEnumerable<object>)value) {
                array.Add(JToken.FromObject(item));
            }
            if (array.Count == 1) {
                array[0].WriteTo(writer);
                return;
            }
            array.WriteTo(writer);
            return;
        }

        writer.WriteValue(StringUtils.ToUnderscore(value + "").Replace("_", " "));

    }

    /// <summary>
    /// Reads the JSON representation of the object.
    /// </summary>
    /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
    /// <param name="objectType">Type of the object.</param>
    /// <param name="existingValue">The existing value of object being read.</param>
    /// <param name="serializer">The calling serializer.</param>
    /// <returns>The object value.</returns>
    public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Determines whether this instance can convert the specified object type.
    /// </summary>
    /// <param name="objectType">Type of the object.</param>
    /// <returns><code>true</code> if this instance can convert the specified object type; otherwise
    /// <code>false</code>.</returns>
    public override bool CanConvert(Type objectType) {
        return objectType == typeof(Enum);
    }

    private static bool IsSchemaListType(Type? type) {

        while (type != null) {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(SchemaList<>)) {
                return true;
            }
            type = type.BaseType!;
        }

        return false;
    }

}