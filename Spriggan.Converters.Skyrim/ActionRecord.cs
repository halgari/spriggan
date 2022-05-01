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

public class IActionRecordGetter_Converter : JsonConverter<IActionRecordGetter>
{
  public override IActionRecordGetter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    throw new NotImplementedException();
  }
  public override void Write(Utf8JsonWriter writer, IActionRecordGetter value, JsonSerializerOptions options)
  {
    writer.WriteStartObject();
    writer.WriteFormKeyHeader(value, options);
    
    // Color
    writer.WritePropertyName("Color");
    if (value.Color == null)
      writer.WriteNullValue();
    else
    {
      writer.WriteStringValue(value.Color.Value.ToArgb().ToString("x8"));
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
    writer.WriteNumberValue((long)value.MajorRecordFlagsRaw);
    
    // Version2
    writer.WritePropertyName("Version2");
    writer.WriteNumberValue((uint)value.Version2);
    
    // VersionControl
    writer.WritePropertyName("VersionControl");
    writer.WriteNumberValue((long)value.VersionControl);
    writer.WriteEndObject();
  }
}
public class ActionRecord_Converter : JsonConverter<Mutagen.Bethesda.Skyrim.ActionRecord>
{
  private IActionRecordGetter_Converter _getterConverter;
  public ActionRecord_Converter()
  {
    _getterConverter = new IActionRecordGetter_Converter();
  }
  public override void Write(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.ActionRecord value, JsonSerializerOptions options)
  {
    _getterConverter.Write(writer, (IActionRecordGetter)value, options);
  }
  public override Mutagen.Bethesda.Skyrim.ActionRecord Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
  {
    if (reader.TokenType != JsonTokenType.StartObject)
        throw new JsonException();
    reader.Read();
    var retval = new Mutagen.Bethesda.Skyrim.ActionRecord(SerializerExtensions.ReadFormKeyHeader(ref reader, options), SkyrimRelease.SkyrimSE);
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
        case "Color":
          if (reader.TokenType != JsonTokenType.Null) {
            retval.Color = Color.FromArgb(int.Parse(reader.GetString()));
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
