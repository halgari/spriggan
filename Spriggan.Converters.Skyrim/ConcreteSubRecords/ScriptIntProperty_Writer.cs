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

internal static class ScriptIntProperty_Writer
{
    public static void WriteInner(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.IScriptIntPropertyGetter? value, JsonSerializerOptions options)
    {
        if (value != null)
        {
            writer.WriteStartObject();
            
            // Data
            writer.WritePropertyName("Data");
            writer.WriteNumberValue(value.Data);
            
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
