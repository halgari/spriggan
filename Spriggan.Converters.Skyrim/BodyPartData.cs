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

public class IBodyPartDataGetter_Converter : JsonConverter<IBodyPartDataGetter>
{
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.IBodyPartDataGetter)) && !t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.BodyPartData));
    }
    public override IBodyPartDataGetter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
    public override void Write(Utf8JsonWriter writer, IBodyPartDataGetter value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteFormKeyHeader(value, options);
        
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
        
        // Parts
        writer.WritePropertyName("Parts");
        if (value.Parts != null)
        {
            writer.WriteStartArray();
            foreach(var itm2 in value.Parts)
            {
                if (itm2 != null)
                {
                    writer.WriteStartObject();
                    
                    // Name
                    writer.WritePropertyName("Name");
                    writer.WriteTranslatedString(itm2.Name, options);
                    
                    // PoseMatching
                    writer.WritePropertyName("PoseMatching");
                    writer.WriteStringValue(itm2.PoseMatching);
                    
                    // PartNode
                    writer.WritePropertyName("PartNode");
                    writer.WriteStringValue(itm2.PartNode);
                    
                    // VatsTarget
                    writer.WritePropertyName("VatsTarget");
                    writer.WriteStringValue(itm2.VatsTarget);
                    
                    // IkStartNode
                    writer.WritePropertyName("IkStartNode");
                    writer.WriteStringValue(itm2.IkStartNode);
                    
                    // DamageMult
                    writer.WritePropertyName("DamageMult");
                    writer.WriteNumberValue(itm2.DamageMult);
                    
                    // Flags
                    writer.WritePropertyName("Flags");
                    writer.WriteFlags(itm2.Flags);
                    
                    // Type
                    writer.WritePropertyName("Type");
                    writer.WriteEnum(itm2.Type);
                    
                    // HealthPercent
                    writer.WritePropertyName("HealthPercent");
                    writer.WriteNumberValue(itm2.HealthPercent);
                    
                    // ActorValue
                    writer.WritePropertyName("ActorValue");
                    writer.WriteEnum(itm2.ActorValue);
                    
                    // ToHitChance
                    writer.WritePropertyName("ToHitChance");
                    writer.WriteNumberValue(itm2.ToHitChance);
                    
                    // ExplodableExplosionChance
                    writer.WritePropertyName("ExplodableExplosionChance");
                    writer.WriteNumberValue(itm2.ExplodableExplosionChance);
                    
                    // ExplodableDebrisCount
                    writer.WritePropertyName("ExplodableDebrisCount");
                    writer.WriteNumberValue((uint)itm2.ExplodableDebrisCount);
                    
                    // ExplodableDebris
                    writer.WritePropertyName("ExplodableDebris");
                    writer.WriteStringValue(itm2.ExplodableDebris.FormKey.ToString());
                    
                    // ExplodableExplosion
                    writer.WritePropertyName("ExplodableExplosion");
                    writer.WriteStringValue(itm2.ExplodableExplosion.FormKey.ToString());
                    
                    // TrackingMaxAngle
                    writer.WritePropertyName("TrackingMaxAngle");
                    writer.WriteNumberValue(itm2.TrackingMaxAngle);
                    
                    // ExplodableDebrisScale
                    writer.WritePropertyName("ExplodableDebrisScale");
                    writer.WriteNumberValue(itm2.ExplodableDebrisScale);
                    
                    // SeverableDebrisCount
                    writer.WritePropertyName("SeverableDebrisCount");
                    writer.WriteNumberValue(itm2.SeverableDebrisCount);
                    
                    // SeverableDebris
                    writer.WritePropertyName("SeverableDebris");
                    writer.WriteStringValue(itm2.SeverableDebris.FormKey.ToString());
                    
                    // SeverableExplosion
                    writer.WritePropertyName("SeverableExplosion");
                    writer.WriteStringValue(itm2.SeverableExplosion.FormKey.ToString());
                    
                    // SeverableDebrisScale
                    writer.WritePropertyName("SeverableDebrisScale");
                    writer.WriteNumberValue(itm2.SeverableDebrisScale);
                    
                    // GorePositioning
                    writer.WritePropertyName("GorePositioning");
                    writer.WriteP3Float(itm2.GorePositioning, options);
                    
                    // GoreRotation
                    writer.WritePropertyName("GoreRotation");
                    writer.WriteP3Float(itm2.GoreRotation, options);
                    
                    // SeverableImpactData
                    writer.WritePropertyName("SeverableImpactData");
                    writer.WriteStringValue(itm2.SeverableImpactData.FormKey.ToString());
                    
                    // ExplodableImpactData
                    writer.WritePropertyName("ExplodableImpactData");
                    writer.WriteStringValue(itm2.ExplodableImpactData.FormKey.ToString());
                    
                    // SeverableDecalCount
                    writer.WritePropertyName("SeverableDecalCount");
                    writer.WriteNumberValue(itm2.SeverableDecalCount);
                    
                    // ExplodableDecalCount
                    writer.WritePropertyName("ExplodableDecalCount");
                    writer.WriteNumberValue(itm2.ExplodableDecalCount);
                    
                    // Unknown
                    writer.WritePropertyName("Unknown");
                    writer.WriteNumberValue((uint)itm2.Unknown);
                    
                    // LimbReplacementScale
                    writer.WritePropertyName("LimbReplacementScale");
                    writer.WriteNumberValue(itm2.LimbReplacementScale);
                    
                    // LimbReplacementModel
                    writer.WritePropertyName("LimbReplacementModel");
                    writer.WriteStringValue(itm2.LimbReplacementModel);
                    
                    // GoreTargetBone
                    writer.WritePropertyName("GoreTargetBone");
                    writer.WriteStringValue(itm2.GoreTargetBone);
                    
                    // TextureFilesHashes
                    writer.WritePropertyName("TextureFilesHashes");
                    if (itm2.TextureFilesHashes == null)
                        writer.WriteNullValue();
                    else
                    {
                        writer.WriteBase64StringValue(itm2.TextureFilesHashes.Value);
                    }
                    
                    // BPNDDataTypeState
                    writer.WritePropertyName("BPNDDataTypeState");
                    writer.WriteFlags(itm2.BPNDDataTypeState);
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
        
        // Version2
        writer.WritePropertyName("Version2");
        writer.WriteNumberValue((uint)value.Version2);
        
        // VersionControl
        writer.WritePropertyName("VersionControl");
        writer.WriteNumberValue(value.VersionControl);
        writer.WriteEndObject();
    }
}
public class BodyPartData_Converter : JsonConverter<Mutagen.Bethesda.Skyrim.BodyPartData>
{
    private IBodyPartDataGetter_Converter _getterConverter;
    public BodyPartData_Converter()
    {
        _getterConverter = new IBodyPartDataGetter_Converter();
    }
    public override bool CanConvert(Type t)
    {
        return t.InheritsFrom(typeof(Mutagen.Bethesda.Skyrim.BodyPartData));
    }
    public override void Write(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.BodyPartData value, JsonSerializerOptions options)
    {
        _getterConverter.Write(writer, (IBodyPartDataGetter)value, options);
    }
    public override Mutagen.Bethesda.Skyrim.BodyPartData Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();
        reader.Read();
        Mutagen.Bethesda.Skyrim.BodyPartData retval = new Mutagen.Bethesda.Skyrim.BodyPartData(SerializerExtensions.ReadFormKeyHeader(ref reader, options), SkyrimRelease.SkyrimSE);
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
                            var prop3 = reader.GetString();
                            reader.Read();
                            switch(prop3)
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
                                            Mutagen.Bethesda.Skyrim.AlternateTexture itm4 = new Mutagen.Bethesda.Skyrim.AlternateTexture();
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
                                                        case "Name":
                                                            itm4.Name = reader.GetString();
                                                            break;
                                                        case "NewTexture":
                                                            itm4.NewTexture.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                                            break;
                                                        case "Index":
                                                            itm4.Index = reader.GetInt32();
                                                            break;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                reader.Skip();
                                            }
                                            retval.Model.AlternateTextures.Add(itm4);
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
                case "Parts":
                    if (reader.TokenType != JsonTokenType.Null)
                    {
                        if (reader.TokenType != JsonTokenType.StartArray)
                            throw new JsonException();
                        while (true)
                        {
                            reader.Read();
                            if (reader.TokenType == JsonTokenType.EndArray)
                                break;
                            Mutagen.Bethesda.Skyrim.BodyPart itm6 = new Mutagen.Bethesda.Skyrim.BodyPart();
                            if (reader.TokenType != JsonTokenType.Null)
                            {
                                if (reader.TokenType != JsonTokenType.StartObject)
                                    throw new JsonException();
                                while (true)
                                {
                                    reader.Read();
                                    if (reader.TokenType == JsonTokenType.EndObject)
                                        break;
                                    var prop7 = reader.GetString();
                                    reader.Read();
                                    switch(prop7)
                                    {
                                        case "Name":
                                            itm6.Name ??= new TranslatedString(Language.English);
                                            SerializerExtensions.ReadTranslatedString(ref reader, itm6.Name, options);
                                            break;
                                        case "PoseMatching":
                                            itm6.PoseMatching = reader.GetString();
                                            break;
                                        case "PartNode":
                                            itm6.PartNode = reader.GetString();
                                            break;
                                        case "VatsTarget":
                                            itm6.VatsTarget = reader.GetString();
                                            break;
                                        case "IkStartNode":
                                            itm6.IkStartNode = reader.GetString();
                                            break;
                                        case "DamageMult":
                                            itm6.DamageMult = reader.GetSingle();
                                            break;
                                        case "Flags":
                                            itm6.Flags = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.BodyPart.Flag>(ref reader, options);
                                            break;
                                        case "Type":
                                            itm6.Type = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.BodyPart.PartType>(ref reader, options);
                                            break;
                                        case "HealthPercent":
                                            itm6.HealthPercent = reader.GetByte();
                                            break;
                                        case "ActorValue":
                                            itm6.ActorValue = SerializerExtensions.ReadEnum<Mutagen.Bethesda.Skyrim.ActorValue>(ref reader, options);
                                            break;
                                        case "ToHitChance":
                                            itm6.ToHitChance = reader.GetByte();
                                            break;
                                        case "ExplodableExplosionChance":
                                            itm6.ExplodableExplosionChance = reader.GetByte();
                                            break;
                                        case "ExplodableDebrisCount":
                                            itm6.ExplodableDebrisCount = reader.GetUInt16();
                                            break;
                                        case "ExplodableDebris":
                                            itm6.ExplodableDebris.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                            break;
                                        case "ExplodableExplosion":
                                            itm6.ExplodableExplosion.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                            break;
                                        case "TrackingMaxAngle":
                                            itm6.TrackingMaxAngle = reader.GetSingle();
                                            break;
                                        case "ExplodableDebrisScale":
                                            itm6.ExplodableDebrisScale = reader.GetSingle();
                                            break;
                                        case "SeverableDebrisCount":
                                            itm6.SeverableDebrisCount = reader.GetInt32();
                                            break;
                                        case "SeverableDebris":
                                            itm6.SeverableDebris.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                            break;
                                        case "SeverableExplosion":
                                            itm6.SeverableExplosion.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                            break;
                                        case "SeverableDebrisScale":
                                            itm6.SeverableDebrisScale = reader.GetSingle();
                                            break;
                                        case "GorePositioning":
                                            itm6.GorePositioning = SerializerExtensions.ReadP3Float(ref reader, options);
                                            break;
                                        case "GoreRotation":
                                            itm6.GoreRotation = SerializerExtensions.ReadP3Float(ref reader, options);
                                            break;
                                        case "SeverableImpactData":
                                            itm6.SeverableImpactData.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                            break;
                                        case "ExplodableImpactData":
                                            itm6.ExplodableImpactData.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));
                                            break;
                                        case "SeverableDecalCount":
                                            itm6.SeverableDecalCount = reader.GetByte();
                                            break;
                                        case "ExplodableDecalCount":
                                            itm6.ExplodableDecalCount = reader.GetByte();
                                            break;
                                        case "Unknown":
                                            itm6.Unknown = reader.GetUInt16();
                                            break;
                                        case "LimbReplacementScale":
                                            itm6.LimbReplacementScale = reader.GetSingle();
                                            break;
                                        case "LimbReplacementModel":
                                            itm6.LimbReplacementModel = reader.GetString();
                                            break;
                                        case "GoreTargetBone":
                                            itm6.GoreTargetBone = reader.GetString();
                                            break;
                                        case "TextureFilesHashes":
                                            if (reader.TokenType != JsonTokenType.Null)
                                            {
                                                itm6.TextureFilesHashes = reader.GetBytesFromBase64();
                                            }
                                            break;
                                        case "BPNDDataTypeState":
                                            itm6.BPNDDataTypeState = SerializerExtensions.ReadFlags<Mutagen.Bethesda.Skyrim.BodyPart.BPNDDataType>(ref reader, options);
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                reader.Skip();
                            }
                            retval.Parts.Add(itm6);
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
                default:
                    reader.Skip();
                    break;
            }
        }
        return retval;
    }
}
