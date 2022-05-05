// THIS FILE IS AUTOGENERATED DO NOT EDIT BY HAND
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using Mutagen.Bethesda.Skyrim;
using Spriggan.Converters.Base;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Strings;
using Microsoft.Extensions.DependencyInjection;
using Mutagen.Bethesda.Plugins.Records;
using System.Globalization;
using Mutagen.Bethesda.Plugins;
using Noggog;

internal static class ScriptProperty_Reader
{
    public static Mutagen.Bethesda.Skyrim.ScriptProperty ReadOuter(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.Null)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();
            switch(SerializerExtensions.ReadTag(ref reader, $"$type", options))
            {
                case "ScriptObjectProperty":
                    return ScriptObjectProperty_Reader.ReadInner(ref reader, options);
                case "ScriptStringProperty":
                    return ScriptStringProperty_Reader.ReadInner(ref reader, options);
                case "ScriptIntProperty":
                    return ScriptIntProperty_Reader.ReadInner(ref reader, options);
                case "ScriptFloatProperty":
                    return ScriptFloatProperty_Reader.ReadInner(ref reader, options);
                case "ScriptBoolProperty":
                    return ScriptBoolProperty_Reader.ReadInner(ref reader, options);
                case "ScriptObjectListProperty":
                    return ScriptObjectListProperty_Reader.ReadInner(ref reader, options);
                case "ScriptIntListProperty":
                    return ScriptIntListProperty_Reader.ReadInner(ref reader, options);
                case "ScriptFloatListProperty":
                    return ScriptFloatListProperty_Reader.ReadInner(ref reader, options);
                case "ScriptBoolListProperty":
                    return ScriptBoolListProperty_Reader.ReadInner(ref reader, options);
                case "ScriptStringListProperty":
                    return ScriptStringListProperty_Reader.ReadInner(ref reader, options);
                default:
                    reader.Skip();
                    break;
            }
        }
        else
        {
            reader.Skip();
        }
        return default;
    }
}