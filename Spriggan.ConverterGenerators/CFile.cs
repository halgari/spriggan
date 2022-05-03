using System.Drawing;
using System.Reactive.Disposables;
using System.Reflection;
using Loqui;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Strings;
using Noggog;
using Noggog.StructuredStrings;
using Spriggan.TupleGen;

namespace Spriggan.ConverterGenerators;

using System.IO;
using System.Text;

public record struct Context(bool IsSettable, bool IsNullable, bool IsConstructed)
{
    
}

public class CFile
{
    public StructuredStringBuilder SB { get; } = new();
    private int _indent;


    private Dictionary<Type, Action<Type, string, Context>> _writerEmitters;
    private Dictionary<Type, Action<Type, string, Context>> _readerEmitters;
    private readonly GameRelease _game;
    private int genSym = 0;


    public CFile(GameRelease game)
    {
        _game = game;
        _writerEmitters = new()
        {
            {typeof(IFormLinkNullableGetter<>), IFormLinkNullableWriter},
            {typeof(IFormLinkGetter<>), IFormLinkWriter},
            {typeof(IReadOnlyList<>), IReadOnlyListWriter},
            {typeof(IGenderedItemGetter<>), GenderedItemGetterWriter},
            {typeof(float), PrimitiveWriter<float>},
            {typeof(int), PrimitiveWriter<int>},
            {typeof(uint), PrimitiveWriter<uint>},
            {typeof(short), PrimitiveWriter<short>},
            {typeof(ushort), PrimitiveWriter<ushort>},
            {typeof(byte), PrimitiveWriter<byte>},
            {typeof(bool), PrimitiveWriter<bool>},
            {typeof(string), PrimitiveWriter<string>},
            {typeof(P3Int16), PrimitiveWriter<P3Int16>},
            {typeof(P2Int), PrimitiveWriter<P2Int>},
            {typeof(P3Float), PrimitiveWriter<P3Float>},
            {typeof(ILoquiObject), LoquiObjectWriter},
            {typeof(Enum), EnumWriter},
            {typeof(Nullable<>), NullableWriter},
            {typeof(ReadOnlyMemorySlice<byte>), MemorySliceWriter},
            {typeof(ITranslatedStringGetter), TranslatedStringWriter},
            {typeof(Color), PrimitiveWriter<Color>}
        };

        _readerEmitters = new()
        {
            {typeof(IFormLinkNullable<>), IFormLinkNullableReader},
            {typeof(IFormLink<>), IFormLinkReader},
            {typeof(ExtendedList<>), ExtendedListReader},
            {typeof(IGenderedItem<>), GenderedItemReader},
            {typeof(float), PrimitiveReader<float>},
            {typeof(int), PrimitiveReader<int>},
            {typeof(uint), PrimitiveReader<uint>},
            {typeof(short), PrimitiveReader<short>},
            {typeof(ushort), PrimitiveReader<ushort>},
            {typeof(byte), PrimitiveReader<byte>},
            {typeof(bool), PrimitiveReader<bool>},
            {typeof(string), PrimitiveReader<string>},
            {typeof(P3Int16), PrimitiveReader<P3Int16>},
            {typeof(P2Int), PrimitiveReader<P2Int>},
            {typeof(P3Float), PrimitiveReader<P3Float>},
            {typeof(Color), PrimitiveReader<Color>},
            {typeof(ILoquiObject), LoquiObjectReader},
            {typeof(Enum), EnumReader},
            {typeof(Nullable<>), NullableReader},
            {typeof(MemorySlice<>), MemorySliceReader},
            {typeof(TranslatedString), TranslatedStringReader},
            {typeof(IFormLinkNullableGetter<>), IFormLinkNullableGetterReader}

        };

        SB.AppendLine("// THIS FILE IS AUTOGENERATED DO NOT EDIT BY HAND");
        SB.AppendLine("using System;");
        SB.AppendLine("using System.Text.Json;");
        SB.AppendLine("using System.Text.Json.Serialization;");
        SB.AppendLine("using System.Drawing;");
        SB.AppendLine("using Mutagen.Bethesda.Skyrim;");
        SB.AppendLine("using Spriggan.Converters.Base;");
        SB.AppendLine("using Mutagen.Bethesda;");
        SB.AppendLine("using Mutagen.Bethesda.Strings;");
        SB.AppendLine("using Microsoft.Extensions.DependencyInjection;");
        SB.AppendLine("using Mutagen.Bethesda.Plugins.Records;");
        SB.AppendLine("using System.Globalization;");
        SB.AppendLine("using Mutagen.Bethesda.Plugins;");
        SB.AppendLine("using Noggog;");
        SB.AppendLine();
    }

    private void GenderedItemReader(Type type, string getter, Context ctx)
    {
        var itype = type.GetGenericArguments()[0];
        if (itype.InheritsFrom(typeof(IFormLinkNullableGetter<>)))
        {
            GenderedFormLinkNullableGetterReader(type, getter, ctx);
            return;
        }
            
        SB.AppendLine("if (reader.TokenType != JsonTokenType.Null)");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("if (reader.TokenType != JsonTokenType.StartObject)");
            using (var _ = SB.IncreaseDepth())
                SB.AppendLine("throw new JsonException();");

            if (ctx.IsSettable)
                SB.AppendLine($"{getter} = new GenderedItem<{TypeToCS(itype)}>(default, default);");


            SB.AppendLine("while(true)");
            using (SB.CurlyBrace())
            {


                var prop = GetProp();
                SB.AppendLine("reader.Read();");
                SB.AppendLine("if (reader.TokenType == JsonTokenType.EndObject)");
                using (SB.CurlyBrace())
                {
                    SB.AppendLine("break;");
                }
                SB.AppendLine($"var {prop} = reader.GetString();");
                SB.AppendLine("reader.Read();");
                SB.AppendLine($"switch({prop})");
                using (SB.CurlyBrace())
                {
                    SB.AppendLine("case \"Male\":");
                    using (SB.IncreaseDepth())
                    {
                        EmitReader(itype, $"{getter}.Male", ctx with { IsSettable = true });
                        SB.AppendLine("break;");
                    }



                    SB.AppendLine("case \"Female\":");
                    using (SB.IncreaseDepth())
                    {
                        EmitReader(itype, $"{getter}.Female", ctx with { IsSettable = true });
                        SB.AppendLine("break;");
                    }


                }
            }
        }

        SB.AppendLine("else");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("reader.Skip();");
        }
    }

    private void GenderedFormLinkNullableGetterReader(Type type, string gettter, Context ctx)
    {
        var itype = type.GetGenericArguments()[0];
        if (!itype.InheritsFrom(typeof(IFormLinkNullableGetter<>)))
        {
            throw new Exception("Not a valid type parameter");
        }
            
        SB.AppendLine("if (reader.TokenType != JsonTokenType.Null)");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("if (reader.TokenType != JsonTokenType.StartObject)");
            using (var _ = SB.IncreaseDepth())
                SB.AppendLine("throw new JsonException();");

            if (!ctx.IsSettable)
                throw new Exception("No way to set this value!");
            
            var maleName = GetItem();
            var femaleName = GetItem();
            var itypeCS = TypeToCS(itype.GetGenericArguments()[0]);
            SB.AppendLine($"var {maleName} = FormLinkNullable<{itypeCS}>.Null;");
            SB.AppendLine($"var {femaleName} = FormLinkNullable<{itypeCS}>.Null;");

            SB.AppendLine("reader.Read();");
            SB.AppendLine("while(true)");
            using (SB.CurlyBrace())
            {
                SB.AppendLine("if (reader.TokenType == JsonTokenType.EndObject)");
                using (SB.CurlyBrace())
                {
                    SB.AppendLine("break;");
                }

                var prop = GetProp();
                SB.AppendLine($"var {prop} = reader.GetString();");
                SB.AppendLine("reader.Read();");
                SB.AppendLine($"switch({prop})");
                using (SB.CurlyBrace())
                {
                    SB.AppendLine("case \"Male\":");
                    using (SB.IncreaseDepth())
                    {
                        SB.AppendLine($"{maleName} = new FormLinkNullable<{itypeCS}>(SerializerExtensions.ReadFormKeyValue(ref reader, options));");
                        SB.AppendLine("break;");
                    }



                    SB.AppendLine("case \"Female\":");
                    using (SB.IncreaseDepth())
                    {
                        SB.AppendLine($"{femaleName} =  new FormLinkNullable<{itypeCS}>(SerializerExtensions.ReadFormKeyValue(ref reader, options));");
                        SB.AppendLine("break;");
                    }

                }
            }
            SB.AppendLine($"{gettter} = new GenderedItem<{TypeToCS(itype)}>({maleName}, {femaleName});");
        }

        SB.AppendLine("else");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("reader.Skip();");
        }
    }

    private void GenderedItemGetterWriter(Type type, string getter, Context ctx)
    {
        var itype = type.GetGenericArguments()[0];

        SB.AppendLine($"if ({getter} == null)");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("writer.WriteNullValue();");
        }

        SB.AppendLine("else");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("writer.WriteStartObject();");
            SB.AppendLine("writer.WritePropertyName(\"Male\");");
            EmitWriter(itype, $"{getter}.Male", ctx);
            SB.AppendLine("writer.WritePropertyName(\"Female\");");
            EmitWriter(itype, $"{getter}.Female", ctx);
            SB.AppendLine("writer.WriteEndObject();");
        }
    }

    private void MemorySliceReader(Type type, string getter, Context ctx)
    {
        SB.AppendLine($"{getter} = reader.GetBytesFromBase64();");
    }

    private void NullableReader(Type type, string getter, Context ctx)
    {
        SB.AppendLine("if (reader.TokenType != JsonTokenType.Null)");
        using (SB.CurlyBrace())
        {
            EmitReader(type.GetGenericArguments()[0], getter, ctx with { IsSettable = true });
        }
    }

    private void MemorySliceWriter(Type type, string getter, Context ctx)
    {
        SB.AppendLine($"writer.WriteBase64StringValue({getter}.Value);");
    }

    private void NullableWriter(Type type, string getter, Context ctx)
    {
        var itype = type.GetGenericArguments()[0];
        SB.AppendLine($"if ({getter} == null)");
        using (SB.IncreaseDepth())
            SB.AppendLine("writer.WriteNullValue();");
        SB.AppendLine("else");
        using (SB.CurlyBrace())
        {
            EmitWriter(itype, getter, ctx with { IsNullable = true });
        }
    }

    private void TranslatedStringReader(Type type, string getter, Context ctx)
    {
        if (ctx.IsSettable)
            SB.AppendLine($"{getter} ??= new TranslatedString(Language.English);");
        SB.AppendLine($"SerializerExtensions.ReadTranslatedString(ref reader, {getter}, options);");
    }

    private void TranslatedStringWriter(Type type, string getter, Context ctx)
    {
        SB.AppendLine($"writer.WriteTranslatedString({getter}, options);");
    }


    private string GetProp()
    {
        genSym++;
        return $"prop{genSym}";
    }
    
    private string GetItem()
    {
        genSym++;
        return $"itm{genSym}";
    }
    
    private void PrimitiveWriter<T>(Type info, string getter, Context ctx)
    {
        if (typeof(T) == typeof(float) || 
            typeof(T) == typeof(int) || 
            typeof(T) == typeof(uint) || 
            typeof(T) == typeof(byte) || 
            typeof(T) == typeof(short))
        {
            SB.AppendLine($"writer.WriteNumberValue((long){getter});");
        }
        else if (typeof(T) == typeof(ushort))
        {
            SB.AppendLine($"writer.WriteNumberValue((uint){getter});");
        }
        else if (typeof(T) == typeof(bool))
        {
            SB.AppendLine($"writer.WriteBooleanValue({getter});");
        }
        else if (typeof(T) == typeof(string))
        {
            SB.AppendLine($"writer.WriteStringValue({getter});");
        }
        else if (typeof(T) == typeof(Color))
        {
            SB.AppendLine($"writer.WriteStringValue({getter}.Value.ToArgb().ToString(\"x8\"));");
        }
        else if (typeof(T) == typeof(P3Int16))
        {
            SB.AppendLine($"writer.WriteP3Int16({getter}, options);");
        }
        else if (typeof(T) == typeof(P3Float))
        {
            SB.AppendLine($"writer.WriteP3Float({getter}, options);");
        }
        else if (typeof(T) == typeof(P2Int))
        {
            SB.AppendLine($"writer.WriteP2Int({getter}, options);");
        }
        else
        {
            throw new NotImplementedException($"No writer for {info.Name}");
        }
    }

    private void PrimitiveReader<T>(Type type, string getter, Context ctx)
    {
        if (typeof(T) == typeof(float))
        {
            SB.AppendLine($"{getter} = reader.GetSingle();");
        }
        else if (typeof(T) == typeof(int))
        {
            SB.AppendLine($"{getter} = reader.GetInt32();");
        }
        else if (typeof(T) == typeof(uint))
        {
            SB.AppendLine($"{getter} = reader.GetUInt32();");
        }
        else if (typeof(T) == typeof(short))
        {
            SB.AppendLine($"{getter} = reader.GetInt16();");
        }
        else if (typeof(T) == typeof(ushort))
        {
            SB.AppendLine($"{getter} = reader.GetUInt16();");
        }
        else if (typeof(T) == typeof(byte))
        {
            SB.AppendLine($"{getter} = reader.GetByte();");
        }
        else if (typeof(T) == typeof(bool))
        {
            SB.AppendLine($"{getter} = reader.GetBoolean();");
        }
        else if (typeof(T) == typeof(Color))
        {
            SB.AppendLine($"{getter} = Color.FromArgb(int.Parse(reader.GetString(), NumberStyles.HexNumber));");
        }
        else if (typeof(T) == typeof(string))
        {
            SB.AppendLine($"{getter} = reader.GetString();");
        }
        else if (typeof(T) == typeof(P3Float))
        {
            SB.AppendLine($"{getter} = SerializerExtensions.ReadP3Float(ref reader, options);");
        }
        else if (typeof(T) == typeof(P3Int16))
        {
            SB.AppendLine($"{getter} = SerializerExtensions.ReadP3Int16(ref reader, options);");
        }
        else if (typeof(T) == typeof(P2Int))
        {
            SB.AppendLine($"{getter} = SerializerExtensions.ReadP2Int(ref reader, options);");
        }
        else
        {
            throw new NotImplementedException($"{type}");
        }
    }

    public void Write(string path)
    {
        SB.Generate(path);
    }

    public void EmitTypeHeader(Type tGetter, string baseName)
    {
        SB.AppendLine($"writer.WriteFormKeyHeader(value, options);");
    }

    public static bool IsSettable(PropertyInfo pi)
    {
        var setMethod = pi.SetMethod;
        if (setMethod == null) return false;
        if (!setMethod.IsPublic) return false;
        var isExternalInitType = typeof(System.Runtime.CompilerServices.IsExternalInit);
        return !setMethod.ReturnParameter.GetRequiredCustomModifiers().Contains(isExternalInitType);
    }


    private void IFormLinkNullableWriter(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"if ({getter}.IsNull)");
        
        using (SB.IncreaseDepth()) 
            SB.AppendLine("writer.WriteNullValue();");

        SB.AppendLine("else");
        
        using (SB.IncreaseDepth()) 
            SB.AppendLine($"writer.WriteStringValue({getter}.FormKey.ToString());");

    }

    private void IFormLinkNullableReader(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"if (reader.TokenType != JsonTokenType.Null)");
        using var _ = SB.IncreaseDepth();
        SB.AppendLine($"{getter}.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));");
    }
    
    private void IFormLinkNullableGetterReader(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"if (reader.TokenType != JsonTokenType.Null)");
        using var _ = SB.IncreaseDepth();
        SB.AppendLine($"{getter}.FormKey.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));");
    }

    private void IFormLinkReader(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"{getter}.SetTo(SerializerExtensions.ReadFormKeyValue(ref reader, options));");
    }
    
    private void IFormLinkWriter(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"writer.WriteStringValue({getter}.FormKey.ToString());");
    }

    private void LoquiObjectWriter(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"if ({getter} != null)");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("writer.WriteStartObject();");
            foreach (var p in VisitorGenerator.Members(info))
            {
                SB.AppendLine("");
                SB.AppendLine($"// {p.Name}");
                SB.AppendLine($"writer.WritePropertyName(\"{p.Name}\");");
                EmitWriter(p.PropertyType, getter + "." + p.Name, ctx);
            }

            SB.AppendLine("writer.WriteEndObject();");
        }

        SB.AppendLine("else");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("writer.WriteNullValue();");
        }
    }


    private void LoquiObjectReader(Type type, string getter, Context ctx)
    {
        if (!ctx.IsConstructed)
        {
            EmitCtor(getter, type);
        }

        ctx = ctx with {IsConstructed = false};

        SB.AppendLine("if (reader.TokenType != JsonTokenType.Null)");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("if (reader.TokenType != JsonTokenType.StartObject)");
            using (SB.IncreaseDepth())
                SB.AppendLine("throw new JsonException();");

            SB.AppendLine("while (true)");
            using (SB.CurlyBrace())
            {
                SB.AppendLine("reader.Read();");
                SB.AppendLine("if (reader.TokenType == JsonTokenType.EndObject)");
                using (SB.IncreaseDepth())
                    SB.AppendLine("break;");

                var propName = GetProp();
                SB.AppendLine($"var {propName} = reader.GetString();");
                SB.AppendLine("reader.Read();");

                SB.AppendLine($"switch({propName})");
                using (SB.CurlyBrace())
                {
                    foreach (var prop in VisitorGenerator.Members(type))
                    {
                        SB.AppendLine($"case \"{prop.Name}\":");

                        using var _ = SB.IncreaseDepth();
                        EmitReader(prop.PropertyType, $"{getter}.{prop.Name}",
                            ctx with { IsSettable = IsSettable(prop) });
                        SB.AppendLine("break;");

                    }
                }
            }
        }
        SB.AppendLine("else");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("reader.Skip();");
        }
    }

    private string CleanName(string s)
    {
        return s.Replace("+", ".");
    }

    /// <summary>
    /// Gets the CS representation of the type.
    /// </summary>
    /// <returns></returns>
    private string TypeToCS(Type t)
    {
        if (t.IsPrimitive)
            return t.Name;
        if (t.IsGenericType)
        {
            var fname = t.GetGenericTypeDefinition().FullName!.Split("`").First();
            return $"{fname}<" + string.Join(",", t.GetGenericArguments().Select(TypeToCS)) + ">";
        }

        return t.FullName!.Replace("+", ".");
    }
    
    private void EnumWriter(Type info, string getter, Context ctx)
    {
        if (ctx.IsNullable)
            getter += ".Value";
        
        if (info.CustomAttributes.Any(a => a.AttributeType == typeof(FlagsAttribute)))
            SB.AppendLine($"writer.WriteFlags({getter});");
        else
            SB.AppendLine($"writer.WriteEnum({getter});");
    }
    
    
    private void EnumReader(Type type, string getter, Context ctx)
    {
        if (type.CustomAttributes.Any(a => a.AttributeType == typeof(FlagsAttribute)))
            SB.AppendLine($"{getter} = SerializerExtensions.ReadFlags<{CleanName(type.FullName)}>(ref reader, options);");
        else
            SB.AppendLine($"{getter} = SerializerExtensions.ReadEnum<{CleanName(type.FullName)}>(ref reader, options);");
    }

    private void IReadOnlyListWriter(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"if ({getter} != null)");
        using (SB.CurlyBrace())
        {
            var itype = info.GetGenericArguments()[0];
            SB.AppendLine("writer.WriteStartArray();");
            var sym = GetItem();
            SB.AppendLine($"foreach(var {sym} in {getter})");
            using (SB.CurlyBrace())
            {
                EmitWriter(itype, sym, ctx);
            }

            SB.AppendLine("writer.WriteEndArray();");
        }

        SB.AppendLine("else");
        using (SB.CurlyBrace())
        {
            SB.AppendLine("writer.WriteNullValue();");
        }
    }

    private void ExtendedListReader(Type info, string getter, Context ctx)
    {
        var itype = info.GetGenericArguments()[0];

        SB.AppendLine("if (reader.TokenType != JsonTokenType.Null)");
        using (SB.CurlyBrace())
        {
            if (ctx.IsSettable)
                SB.AppendLine($"{getter} ??= new();");

            SB.AppendLine("if (reader.TokenType != JsonTokenType.StartArray)");
            using (SB.IncreaseDepth())
                SB.AppendLine("throw new JsonException();");

            SB.AppendLine("while (true)");
            using (SB.CurlyBrace())
            {
                SB.AppendLine("reader.Read();");
                SB.AppendLine("if (reader.TokenType == JsonTokenType.EndArray)");
                using (SB.IncreaseDepth())
                    SB.AppendLine("break;");

                if (itype.InheritsFrom(typeof(IFormLinkGetter<>)))
                {
                    EmitExtendedListFormLinkGetterReadOne(info, getter, ctx with { IsSettable = true });
                }
                else
                {
                    EmitExtendedListOtherReadOne(info, itype, getter, ctx with { IsSettable = true });
                }
            }
        }
    }

    private void EmitExtendedListOtherReadOne(Type info, Type itemType, string getter, Context ctx)
    {
        var sym = GetItem();
        if (itemType.IsPrimitive)
        {
            SB.AppendLine($"{itemType.Name} {sym};");
            EmitReader(itemType, sym, ctx with {IsSettable = false});
        }
        else
        {
            EmitCtor(sym, itemType, true);
            EmitReader(itemType, sym, ctx with {IsSettable = false, IsConstructed = true});
        }

        SB.AppendLine($"{getter}.Add({sym});");
    }

    private void EmitExtendedListFormLinkGetterReadOne(Type info, string getter, Context ctx)
    {
        SB.AppendLine($"{getter}.Add(SerializerExtensions.ReadFormKeyValue(ref reader, options));");
    }

    public void EmitWriter(Type type, string getter, Context ctx)
    {
        
        var (_, emitter) = _writerEmitters.FirstOrDefault(e => type.InheritsFrom(e.Key));

        
        if (emitter == null)
            throw new Exception($"No emitter for property of type {type.FullName}");
        emitter(type, getter, ctx);
    }

    public void EmitReader(Type type, string getter, Context ctx)
    {
        var (_, emitter) = _readerEmitters.FirstOrDefault(e => type.InheritsFrom(e.Key));
        if (emitter == null)
            throw new Exception($"No emitter for property of type {type.FullName}");
        emitter(type, getter, ctx);
    }

    public void EmitCtor(string retval, Type tMain, bool emitVar = false)
    {
        var prefix = emitVar ? "var " : "";
        if (tMain.InheritsFrom(typeof(IMajorRecord)))
        {
            if (_game == GameRelease.SkyrimLE || _game == GameRelease.SkyrimSE)
            {
                SB.AppendLine(
                    $"{prefix}{retval} = new {tMain.FullName}(SerializerExtensions.ReadFormKeyHeader(ref reader, options), SkyrimRelease.{_game});");
            }
            else
            {
                throw new NotImplementedException();
            }

            return;
        }

        if (tMain.GetConstructors().Any(t => t.GetParameters().Length == 0))
        {
            SB.AppendLine($"{prefix}{retval} = new {tMain.FullName}();");
            return;
        }

        throw new NotImplementedException();
    }
}
