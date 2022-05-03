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
        services.AddSingleton<JsonConverter, IAmmunitionGetter_Converter>();
        services.AddSingleton<JsonConverter, Ammunition_Converter>();
        services.AddSingleton<JsonConverter, IAnimatedObjectGetter_Converter>();
        services.AddSingleton<JsonConverter, AnimatedObject_Converter>();
        services.AddSingleton<JsonConverter, IArmorGetter_Converter>();
        services.AddSingleton<JsonConverter, Armor_Converter>();
        services.AddSingleton<JsonConverter, IArmorAddonGetter_Converter>();
        services.AddSingleton<JsonConverter, ArmorAddon_Converter>();
        services.AddSingleton<JsonConverter, IArtObjectGetter_Converter>();
        services.AddSingleton<JsonConverter, ArtObject_Converter>();
        services.AddSingleton<JsonConverter, IAssociationTypeGetter_Converter>();
        services.AddSingleton<JsonConverter, AssociationType_Converter>();
        services.AddSingleton<JsonConverter, IBodyPartDataGetter_Converter>();
        services.AddSingleton<JsonConverter, BodyPartData_Converter>();
        services.AddSingleton<JsonConverter, IBookGetter_Converter>();
        services.AddSingleton<JsonConverter, Book_Converter>();
        return services;
    }
    public static (Type Main, Type Getter)[] SupportedRecords = new[]
    {
        (typeof(Mutagen.Bethesda.Skyrim.AcousticSpace), typeof(Mutagen.Bethesda.Skyrim.IAcousticSpaceGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.ActionRecord), typeof(Mutagen.Bethesda.Skyrim.IActionRecordGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.Activator), typeof(Mutagen.Bethesda.Skyrim.IActivatorGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.ActorValueInformation), typeof(Mutagen.Bethesda.Skyrim.IActorValueInformationGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.AddonNode), typeof(Mutagen.Bethesda.Skyrim.IAddonNodeGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.AlchemicalApparatus), typeof(Mutagen.Bethesda.Skyrim.IAlchemicalApparatusGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.Ammunition), typeof(Mutagen.Bethesda.Skyrim.IAmmunitionGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.AnimatedObject), typeof(Mutagen.Bethesda.Skyrim.IAnimatedObjectGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.Armor), typeof(Mutagen.Bethesda.Skyrim.IArmorGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.ArmorAddon), typeof(Mutagen.Bethesda.Skyrim.IArmorAddonGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.ArtObject), typeof(Mutagen.Bethesda.Skyrim.IArtObjectGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.AssociationType), typeof(Mutagen.Bethesda.Skyrim.IAssociationTypeGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.BodyPartData), typeof(Mutagen.Bethesda.Skyrim.IBodyPartDataGetter)),
        (typeof(Mutagen.Bethesda.Skyrim.Book), typeof(Mutagen.Bethesda.Skyrim.IBookGetter)),
    };
}
