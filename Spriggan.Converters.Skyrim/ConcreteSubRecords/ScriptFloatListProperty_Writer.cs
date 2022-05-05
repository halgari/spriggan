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

internal static class ScriptFloatListProperty_Writer
{
    public static void WriteInner(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.IScriptFloatListPropertyGetter? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteStartObject();
            
            // Data
            writer.WritePropertyName("Data");
            if (value.Data != null)
            {
                writer.WriteStartArray();
                foreach(var itm1 in value.Data)
                {
                    writer.WriteNumberValue(itm1);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNullValue();
            }
            
            // Name
            writer.WritePropertyName("Name");
            writer.WriteStringValue(value.Name);
            
            // Flags
            writer.WritePropertyName("Flags");
            writer.WriteEnum(value.Flags);
            writer.WriteEndObject();
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}
