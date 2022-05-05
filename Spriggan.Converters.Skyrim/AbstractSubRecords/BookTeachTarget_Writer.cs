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

internal static class BookTeachTarget_Writer
{
    public static void WriteOuter(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.BookTeachTarget? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteStartObject();
            switch (value)
            {
                case Mutagen.Bethesda.Skyrim.IBookSkillGetter itm1:
                    writer.WriteString("$type", "BookSkill");
                    BookSkill_Writer.WriteInner(writer, itm1, options);
                    break;
                case Mutagen.Bethesda.Skyrim.IBookSpellGetter itm2:
                    writer.WriteString("$type", "BookSpell");
                    BookSpell_Writer.WriteInner(writer, itm2, options);
                    break;
                case Mutagen.Bethesda.Skyrim.IBookTeachesNothingGetter itm3:
                    writer.WriteString("$type", "BookTeachesNothing");
                    BookTeachesNothing_Writer.WriteInner(writer, itm3, options);
                    break;
            }
            writer.WriteEndObject();
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}
