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

public class ICameraPathGetter_Converter : JsonConverter<ICameraPathGetter>
{
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.ICameraPathGetter)) && !t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.CameraPath));
    }
    public override ICameraPathGetter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer, ICameraPathGetter value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteFormKeyHeader(value, options);
        
        // Conditions
        writer.WritePropertyName("Conditions");
        if (value.Conditions != null)
        {
            writer.WriteStartArray();
            foreach(var itm1 in value.Conditions)
            {
                IConditionGetter_Writer.WriteOuter(writer, itm1, options);
            }
            writer.WriteEndArray();
        }
        else
        {
            writer.WriteNullValue();
        }
        
        // EditorID
        writer.WritePropertyName("EditorID");
        writer.WriteStringValue(value.EditorID);
        
        // IsCompressed
        writer.WritePropertyName("IsCompressed");
        writer.WriteBooleanValue(value.IsCompressed);
        
        // IsDeleted
        writer.WritePropertyName("IsDeleted");
        writer.WriteBooleanValue(value.IsDeleted);
        
        // MajorRecordFlagsRaw
        writer.WritePropertyName("MajorRecordFlagsRaw");
        writer.WriteNumberValue(value.MajorRecordFlagsRaw);
        
        // RelatedPaths
        writer.WritePropertyName("RelatedPaths");
        if (value.RelatedPaths != null)
        {
            writer.WriteStartArray();
            foreach(var itm2 in value.RelatedPaths)
            {
                writer.WriteStringValue(itm2.FormKey.ToString());
            }
            writer.WriteEndArray();
        }
        else
        {
            writer.WriteNullValue();
        }
        
        // Shots
        writer.WritePropertyName("Shots");
        if (value.Shots != null)
        {
            writer.WriteStartArray();
            foreach(var itm3 in value.Shots)
            {
                writer.WriteStringValue(itm3.FormKey.ToString());
            }
            writer.WriteEndArray();
        }
        else
        {
            writer.WriteNullValue();
        }
        
        // Version2
        writer.WritePropertyName("Version2");
        writer.WriteNumberValue((uint)value.Version2);
        
        // VersionControl
        writer.WritePropertyName("VersionControl");
        writer.WriteNumberValue(value.VersionControl);
        
        // Zoom
        writer.WritePropertyName("Zoom");
        writer.WriteFlags(value.Zoom);
        
        // ZoomMustHaveCameraShots
        writer.WritePropertyName("ZoomMustHaveCameraShots");
        writer.WriteBooleanValue(value.ZoomMustHaveCameraShots);
        writer.WriteEndObject();
    }
}
public class CameraPath_Converter : JsonConverter<Mutagen.Bethesda.Skyrim.CameraPath>
{
    private ICameraPathGetter_Converter _getterConverter;
    public CameraPath_Converter()
    {
        _getterConverter = new ICameraPathGetter_Converter();
    }
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.CameraPath));
    }
    public override void Write(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.CameraPath value, JsonSerializerOptions options)
    {
        _getterConverter.Write(writer, (ICameraPathGetter)value, options);
    }
    public override Mutagen.Bethesda.Skyrim.CameraPath Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();
        reader.Read();
        Mutagen.Bethesda.Skyrim.CameraPath retval = new Mutagen.Bethesda.Skyrim.CameraPath(SerializerExtensions.ReadFormKeyHeader(ref reader, options), SkyrimRelease.SkyrimSE);
        while (true)
        {
            reader.Read();
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                reader.Read();
                break;
            }
            var prop = reader.GetString();
            reader.Read();
            switch (prop)
            {
                case "Conditions":
                    if (reader.TokenType != JsonTokenType.Null)
                    {
                        if (reader.TokenType != JsonTokenType.StartArray)
                            throw new JsonException();
                        while (true)
                        {
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.EndArray)
                                break;
                            Condition itm4 = default;
                            retval.Conditions.Add(itm4);
                        }
                    }
                    break;
                case "EditorID":
                    retval.EditorID = reader.GetString();
                    break;
                case "FormVersion":
                    retval.FormVersion = reader.GetUInt16();
                    break;
                case "IsCompressed":
                    retval.IsCompressed = reader.GetBoolean();
                    break;
                case "IsDeleted":
                    retval.IsDeleted = reader.GetBoolean();
                    break;
                case "MajorRecordFlagsRaw":
                    retval.MajorRecordFlagsRaw = reader.GetInt32();
                    break;
                case "RelatedPaths":
                    if (reader.TokenType != JsonTokenType.Null)
                    {
                        if (reader.TokenType != JsonTokenType.StartArray)
                            throw new JsonException();
                        while (true)
                        {
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.EndArray)
                                break;
                            retval.RelatedPaths.Add(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                        }
                    }
                    break;
                case "Shots":
                    if (reader.TokenType != JsonTokenType.Null)
                    {
                        if (reader.TokenType != JsonTokenType.StartArray)
                            throw new JsonException();
                        while (true)
                        {
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.EndArray)
                                break;
                            retval.Shots.Add(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                        }
                    }
                    break;
                case "SkyrimMajorRecordFlags":
                    retval.SkyrimMajorRecordFlags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.SkyrimMajorRecord.SkyrimMajorRecordFlag>(ref reader, options);
                    break;
                case "Version2":
                    retval.Version2 = reader.GetUInt16();
                    break;
                case "VersionControl":
                    retval.VersionControl = reader.GetUInt32();
                    break;
                case "Zoom":
                    retval.Zoom = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.CameraPath.ZoomType>(ref reader, options);
                    break;
                case "ZoomMustHaveCameraShots":
                    retval.ZoomMustHaveCameraShots = reader.GetBoolean();
                    break;
                default:
                    reader.Skip();
                    break;
            }
        }
        return retval;
    }
}
