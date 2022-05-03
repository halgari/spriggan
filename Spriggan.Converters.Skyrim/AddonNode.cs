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

public class IAddonNodeGetter_Converter : JsonConverter<IAddonNodeGetter>
{
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.IAddonNodeGetter));
    }
    public override IAddonNodeGetter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer, IAddonNodeGetter value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteFormKeyHeader(value, options);
        
        // AlwaysLoaded
        writer.WritePropertyName("AlwaysLoaded");
        writer.WriteBooleanValue(value.AlwaysLoaded);
        
        // DNAMDataTypeState
        writer.WritePropertyName("DNAMDataTypeState");
        writer.WriteFlags(value.DNAMDataTypeState);
        
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
        writer.WriteNumberValue((long)value.MajorRecordFlagsRaw);
        
        // MasterParticleSystemCap
        writer.WritePropertyName("MasterParticleSystemCap");
        writer.WriteNumberValue((uint)value.MasterParticleSystemCap);
        
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
                        writer.WriteNumberValue((long)itm1.Index);
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
        
        // NodeIndex
        writer.WritePropertyName("NodeIndex");
        writer.WriteNumberValue((long)value.NodeIndex);
        
        // ObjectBounds
        writer.WritePropertyName("ObjectBounds");
        if (value.ObjectBounds != null)
        {
            writer.WriteStartObject();
            
            // First
            writer.WritePropertyName("First");
            writer.WriteP3Int16(value.ObjectBounds.First, options);
            
            // Second
            writer.WritePropertyName("Second");
            writer.WriteP3Int16(value.ObjectBounds.Second, options);
            writer.WriteEndObject();
        }
        else
        {
            writer.WriteNullValue();
        }
        
        // Sound
        writer.WritePropertyName("Sound");
        if (value.Sound.IsNull)
            writer.WriteNullValue();
        else
            writer.WriteStringValue(value.Sound.FormKey.ToString());
        
        // Version2
        writer.WritePropertyName("Version2");
        writer.WriteNumberValue((uint)value.Version2);
        
        // VersionControl
        writer.WritePropertyName("VersionControl");
        writer.WriteNumberValue((long)value.VersionControl);
        writer.WriteEndObject();
    }
}
public class AddonNode_Converter : JsonConverter<Mutagen.Bethesda.Skyrim.AddonNode>
{
    private IAddonNodeGetter_Converter _getterConverter;
    public AddonNode_Converter()
    {
        _getterConverter = new IAddonNodeGetter_Converter();
    }
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.AddonNode));
    }
    public override void Write(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.AddonNode value, JsonSerializerOptions options)
    {
        _getterConverter.Write(writer, (IAddonNodeGetter)value, options);
    }
    public override Mutagen.Bethesda.Skyrim.AddonNode Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();
        reader.Read();
        var retval = new Mutagen.Bethesda.Skyrim.AddonNode(SerializerExtensions.ReadFormKeyHeader(ref reader, options), SkyrimRelease.SkyrimSE);
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
                case "AlwaysLoaded":
                    retval.AlwaysLoaded = reader.GetBoolean();
                    break;
                case "DNAMDataTypeState":
                    retval.DNAMDataTypeState = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.AddonNode.DNAMDataType>(ref reader, options);
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
                case "MasterParticleSystemCap":
                    retval.MasterParticleSystemCap = reader.GetUInt16();
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
                case "NodeIndex":
                    retval.NodeIndex = reader.GetInt32();
                    break;
                case "ObjectBounds":
                    retval.ObjectBounds = new Mutagen.Bethesda.Skyrim.ObjectBounds();
                    if (reader.TokenType != JsonTokenType.Null)
                    {
                        if (reader.TokenType != JsonTokenType.StartObject)
                            throw new JsonException();
                        while (true)
                        {
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.EndObject)
                                break;
                            var prop5 = reader.GetString();
                            reader.Read();
                            switch(prop5)
                            {
                                case "First":
                                    retval.ObjectBounds.First = SerializerExtensions.ReadP3Int16(ref reader, options);
                                    break;
                                case "Second":
                                    retval.ObjectBounds.Second = SerializerExtensions.ReadP3Int16(ref reader, options);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        reader.Skip();
                    }
                    break;
                case "SkyrimMajorRecordFlags":
                    retval.SkyrimMajorRecordFlags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.SkyrimMajorRecord.SkyrimMajorRecordFlag>(ref reader, options);
                    break;
                case "Sound":
                    if (reader.TokenType != JsonTokenType.Null)
                        retval.Sound.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
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
