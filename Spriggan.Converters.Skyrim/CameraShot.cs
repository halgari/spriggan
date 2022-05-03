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

public class ICameraShotGetter_Converter : JsonConverter<ICameraShotGetter>
{
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.ICameraShotGetter)) && !t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.CameraShot));
    }
    public override ICameraShotGetter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer, ICameraShotGetter value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteFormKeyHeader(value, options);
        
        // Action
        writer.WritePropertyName("Action");
        writer.WriteEnum(value.Action);
        
        // DATADataTypeState
        writer.WritePropertyName("DATADataTypeState");
        writer.WriteFlags(value.DATADataTypeState);
        
        // EditorID
        writer.WritePropertyName("EditorID");
        writer.WriteStringValue(value.EditorID);
        
        // Flags
        writer.WritePropertyName("Flags");
        writer.WriteFlags(value.Flags);
        
        // ImageSpaceModifier
        writer.WritePropertyName("ImageSpaceModifier");
        if (value.ImageSpaceModifier.IsNull)
            writer.WriteNullValue();
        else
            writer.WriteStringValue(value.ImageSpaceModifier.FormKey.ToString());
        
        // IsCompressed
        writer.WritePropertyName("IsCompressed");
        writer.WriteBooleanValue(value.IsCompressed);
        
        // IsDeleted
        writer.WritePropertyName("IsDeleted");
        writer.WriteBooleanValue(value.IsDeleted);
        
        // Location
        writer.WritePropertyName("Location");
        writer.WriteEnum(value.Location);
        
        // MajorRecordFlagsRaw
        writer.WritePropertyName("MajorRecordFlagsRaw");
        writer.WriteNumberValue(value.MajorRecordFlagsRaw);
        
        // MaxTime
        writer.WritePropertyName("MaxTime");
        writer.WriteNumberValue(value.MaxTime);
        
        // MinTime
        writer.WritePropertyName("MinTime");
        writer.WriteNumberValue(value.MinTime);
        
        // Model
        writer.WritePropertyName("Model");
        if (value.Model != null)
        {
            writer.WriteStartObject();
            
            // AlternateTextures
            writer.WritePropertyName("AlternateTextures");
            if (value.Model.AlternateTextures != null)
            {
                writer.WriteStartArray();
                foreach(var itm1 in value.Model.AlternateTextures)
                {
                    if (itm1 != null)
                    {
                        writer.WriteStartObject();
                        
                        // Name
                        writer.WritePropertyName("Name");
                        writer.WriteStringValue(itm1.Name);
                        
                        // NewTexture
                        writer.WritePropertyName("NewTexture");
                        writer.WriteStringValue(itm1.NewTexture.FormKey.ToString());
                        
                        // Index
                        writer.WritePropertyName("Index");
                        writer.WriteNumberValue(itm1.Index);
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
            
            // File
            writer.WritePropertyName("File");
            writer.WriteStringValue(value.Model.File);
            
            // Data
            writer.WritePropertyName("Data");
            if (value.Model.Data == null)
                writer.WriteNullValue();
            else
            {
                writer.WriteBase64StringValue(value.Model.Data.Value);
            }
            writer.WriteEndObject();
        }
        else
        {
            writer.WriteNullValue();
        }
        
        // NearTargetDistance
        writer.WritePropertyName("NearTargetDistance");
        writer.WriteNumberValue(value.NearTargetDistance);
        
        // Target
        writer.WritePropertyName("Target");
        writer.WriteEnum(value.Target);
        
        // TargetPercentBetweenActors
        writer.WritePropertyName("TargetPercentBetweenActors");
        writer.WriteNumberValue(value.TargetPercentBetweenActors);
        
        // TimeMultiplierGlobal
        writer.WritePropertyName("TimeMultiplierGlobal");
        writer.WriteNumberValue(value.TimeMultiplierGlobal);
        
        // TimeMultiplierPlayer
        writer.WritePropertyName("TimeMultiplierPlayer");
        writer.WriteNumberValue(value.TimeMultiplierPlayer);
        
        // TimeMultiplierTarget
        writer.WritePropertyName("TimeMultiplierTarget");
        writer.WriteNumberValue(value.TimeMultiplierTarget);
        
        // Version2
        writer.WritePropertyName("Version2");
        writer.WriteNumberValue((uint)value.Version2);
        
        // VersionControl
        writer.WritePropertyName("VersionControl");
        writer.WriteNumberValue(value.VersionControl);
        writer.WriteEndObject();
    }
}
public class CameraShot_Converter : JsonConverter<Mutagen.Bethesda.Skyrim.CameraShot>
{
    private ICameraShotGetter_Converter _getterConverter;
    public CameraShot_Converter()
    {
        _getterConverter = new ICameraShotGetter_Converter();
    }
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.CameraShot));
    }
    public override void Write(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.CameraShot value, JsonSerializerOptions options)
    {
        _getterConverter.Write(writer, (ICameraShotGetter)value, options);
    }
    public override Mutagen.Bethesda.Skyrim.CameraShot Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();
        reader.Read();
        var retval = new Mutagen.Bethesda.Skyrim.CameraShot(SerializerExtensions.ReadFormKeyHeader(ref reader, options), SkyrimRelease.SkyrimSE);
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
                case "Action":
                    retval.Action = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.CameraShot.ActionType>(ref reader, options);
                    break;
                case "DATADataTypeState":
                    retval.DATADataTypeState = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.CameraShot.DATADataType>(ref reader, options);
                    break;
                case "EditorID":
                    retval.EditorID = reader.GetString();
                    break;
                case "Flags":
                    retval.Flags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.CameraShot.Flag>(ref reader, options);
                    break;
                case "FormVersion":
                    retval.FormVersion = reader.GetUInt16();
                    break;
                case "ImageSpaceModifier":
                    if (reader.TokenType != JsonTokenType.Null)
                        retval.ImageSpaceModifier.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                    break;
                case "IsCompressed":
                    retval.IsCompressed = reader.GetBoolean();
                    break;
                case "IsDeleted":
                    retval.IsDeleted = reader.GetBoolean();
                    break;
                case "Location":
                    retval.Location = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.CameraShot.LocationType>(ref reader, options);
                    break;
                case "MajorRecordFlagsRaw":
                    retval.MajorRecordFlagsRaw = reader.GetInt32();
                    break;
                case "MaxTime":
                    retval.MaxTime = reader.GetSingle();
                    break;
                case "MinTime":
                    retval.MinTime = reader.GetSingle();
                    break;
                case "Model":
                    retval.Model = new Mutagen.Bethesda.Skyrim.Model();
                    if (reader.TokenType != JsonTokenType.Null)
                    {
                        if (reader.TokenType != JsonTokenType.StartObject)
                            throw new JsonException();
                        while (true)
                        {
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.EndObject)
                                break;
                            var prop2 = reader.GetString();
                            reader.Read();
                            switch(prop2)
                            {
                                case "AlternateTextures":
                                    if (reader.TokenType != JsonTokenType.Null)
                                    {
                                        retval.Model.AlternateTextures ??= new();
                                        if (reader.TokenType != JsonTokenType.StartArray)
                                            throw new JsonException();
                                        while (true)
                                        {
                                            reader.Read();
                                            if (reader.TokenType == JsonTokenType.EndArray)
                                                break;
                                            var itm3 = new Mutagen.Bethesda.Skyrim.AlternateTexture();
                                            if (reader.TokenType != JsonTokenType.Null)
                                            {
                                                if (reader.TokenType != JsonTokenType.StartObject)
                                                    throw new JsonException();
                                                while (true)
                                                {
                                                    reader.Read();
                                                    if (reader.TokenType == JsonTokenType.EndObject)
                                                        break;
                                                    var prop4 = reader.GetString();
                                                    reader.Read();
                                                    switch(prop4)
                                                    {
                                                        case "Name":
                                                            itm3.Name = reader.GetString();
                                                            break;
                                                        case "NewTexture":
                                                            itm3.NewTexture.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                                            break;
                                                        case "Index":
                                                            itm3.Index = reader.GetInt32();
                                                            break;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                reader.Skip();
                                            }
                                            retval.Model.AlternateTextures.Add(itm3);
                                        }
                                    }
                                    break;
                                case "File":
                                    retval.Model.File = reader.GetString();
                                    break;
                                case "Data":
                                    if (reader.TokenType != JsonTokenType.Null)
                                    {
                                        retval.Model.Data = reader.GetBytesFromBase64();
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        reader.Skip();
                    }
                    break;
                case "NearTargetDistance":
                    retval.NearTargetDistance = reader.GetSingle();
                    break;
                case "SkyrimMajorRecordFlags":
                    retval.SkyrimMajorRecordFlags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.SkyrimMajorRecord.SkyrimMajorRecordFlag>(ref reader, options);
                    break;
                case "Target":
                    retval.Target = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.CameraShot.TargetType>(ref reader, options);
                    break;
                case "TargetPercentBetweenActors":
                    retval.TargetPercentBetweenActors = reader.GetSingle();
                    break;
                case "TimeMultiplierGlobal":
                    retval.TimeMultiplierGlobal = reader.GetSingle();
                    break;
                case "TimeMultiplierPlayer":
                    retval.TimeMultiplierPlayer = reader.GetSingle();
                    break;
                case "TimeMultiplierTarget":
                    retval.TimeMultiplierTarget = reader.GetSingle();
                    break;
                case "Version2":
                    retval.Version2 = reader.GetUInt16();
                    break;
                case "VersionControl":
                    retval.VersionControl = reader.GetUInt32();
                    break;
                default:
                    reader.Skip();
                    break;
            }
        }
        return retval;
    }
}
