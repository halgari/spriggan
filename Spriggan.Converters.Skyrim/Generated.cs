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

public static class GeneratedConvertersExtensions
{
    public static IServiceCollection UseConverters(this IServiceCollection services)
    {
        services.AddSingleton<JsonConverter, IAcousticSpaceGetter_Converter>();
        services.AddSingleton<JsonConverter, AcousticSpace_Converter>();
        services.AddSingleton<JsonConverter, IActionRecordGetter_Converter>();
        services.AddSingleton<JsonConverter, ActionRecord_Converter>();
        services.AddSingleton<JsonConverter, IActivatorGetter_Converter>();
        services.AddSingleton<JsonConverter, Activator_Converter>();
        services.AddSingleton<JsonConverter, IActorValueInformationGetter_Converter>();
        services.AddSingleton<JsonConverter, ActorValueInformation_Converter>();
        services.AddSingleton<JsonConverter, IAddonNodeGetter_Converter>();
        services.AddSingleton<JsonConverter, AddonNode_Converter>();
        services.AddSingleton<JsonConverter, IAlchemicalApparatusGetter_Converter>();
        services.AddSingleton<JsonConverter, AlchemicalApparatus_Converter>();
        return services;
    }
    public static Type[] SupportedRecords = new[]
    {
        typeof(Mutagen.Bethesda.Skyrim.AcousticSpace),
        typeof(Mutagen.Bethesda.Skyrim.ActionRecord),
        typeof(Mutagen.Bethesda.Skyrim.Activator),
        typeof(Mutagen.Bethesda.Skyrim.ActorValueInformation),
        typeof(Mutagen.Bethesda.Skyrim.AddonNode),
        typeof(Mutagen.Bethesda.Skyrim.AlchemicalApparatus),
    };
}
