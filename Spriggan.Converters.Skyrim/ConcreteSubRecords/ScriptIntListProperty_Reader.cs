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

internal static class ScriptIntListProperty_Reader
{
    public static Mutagen.Bethesda.Skyrim.ScriptIntListProperty ReadInner(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        Mutagen.Bethesda.Skyrim.ScriptIntListProperty cls = new();
        while (true)
        {
            reader.Read();
            if (reader.TokenType == JsonTokenType.EndObject)
                break;
            var prop1 = reader.GetString();
            reader.Read();
            switch(prop1)
            {
                case "Data":
                    if (reader.TokenType != JsonTokenType.Null)
                    {
                        if (reader.TokenType != JsonTokenType.StartArray)
                            throw new JsonException();
                        while (true)
                        {
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.EndArray)
                                break;
                            Int32 itm2 = default;
                            itm2 = reader.GetInt32();
                            cls.Data.Add(itm2);
                        }
                    }
                    break;
                case "Name":
                    cls.Name = reader.GetString();
                    break;
                case "Flags":
                    cls.Flags = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.ScriptProperty.Flag>(ref reader, options);
                    break;
            }
        }
        return cls;
    }
}
