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

internal static class ScriptObjectListProperty_Writer
{
    public static void WriteInner(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.IScriptObjectListPropertyGetter? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteStartObject();
            
            // Objects
            writer.WritePropertyName("Objects");
            if (value.Objects != null)
            {
                writer.WriteStartArray();
                foreach(var itm1 in value.Objects)
                {
                    if (itm1 != null)
                    {
                        writer.WriteStartObject();
                        
                        // Object
                        writer.WritePropertyName("Object");
                        writer.WriteStringValue(itm1.Object.FormKey.ToString());
                        
                        // Alias
                        writer.WritePropertyName("Alias");
                        writer.WriteNumberValue(itm1.Alias);
                        
                        // Unused
                        writer.WritePropertyName("Unused");
                        writer.WriteNumberValue((uint)itm1.Unused);
                        
                        // Name
                        writer.WritePropertyName("Name");
                        writer.WriteStringValue(itm1.Name);
                        
                        // Flags
                        writer.WritePropertyName("Flags");
                        writer.WriteEnum(itm1.Flags);
                        writer.WriteEndObject();
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }
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
