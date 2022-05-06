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

internal static class INavigationMeshGetter_Writer
{
    public static void WriteInner(Utf8JsonWriter writer, Mutagen.Bethesda.Skyrim.INavigationMeshGetter? value, JsonSerializerOptions options)
    {
        if (value != null)
        {
            writer.WriteStartObject();
            
            // Data
            writer.WritePropertyName("Data");
            if (value.Data != null)
            {
                writer.WriteStartObject();
                
                // NavmeshVersion
                writer.WritePropertyName("NavmeshVersion");
                writer.WriteNumberValue(value.Data.NavmeshVersion);
                
                // Magic
                writer.WritePropertyName("Magic");
                writer.WriteNumberValue(value.Data.Magic);
                
                // Parent
                writer.WritePropertyName("Parent");
                IANavmeshParentGetter_Writer.WriteOuter(writer, value.Data.Parent, options);
                
                // Vertices
                writer.WritePropertyName("Vertices");
                if (value.Data.Vertices != null)
                {
                    writer.WriteStartArray();
                    foreach(var itm1 in value.Data.Vertices)
                    {
                        writer.WriteP3Float(itm1, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNullValue();
                }
                
                // Triangles
                writer.WritePropertyName("Triangles");
                if (value.Data.Triangles != null)
                {
                    writer.WriteStartArray();
                    foreach(var itm2 in value.Data.Triangles)
                    {
                        if (itm2 != null)
                        {
                            writer.WriteStartObject();
                            
                            // Vertices
                            writer.WritePropertyName("Vertices");
                            writer.WriteP3Int16(itm2.Vertices, options);
                            
                            // EdgeLink_0_1
                            writer.WritePropertyName("EdgeLink_0_1");
                            writer.WriteNumberValue(itm2.EdgeLink_0_1);
                            
                            // EdgeLink_1_2
                            writer.WritePropertyName("EdgeLink_1_2");
                            writer.WriteNumberValue(itm2.EdgeLink_1_2);
                            
                            // EdgeLink_2_0
                            writer.WritePropertyName("EdgeLink_2_0");
                            writer.WriteNumberValue(itm2.EdgeLink_2_0);
                            
                            // Flags
                            writer.WritePropertyName("Flags");
                            writer.WriteFlags(itm2.Flags);
                            
                            // CoverFlags
                            writer.WritePropertyName("CoverFlags");
                            writer.WriteNumberValue((uint)itm2.CoverFlags);
                            
                            // IsCover
                            writer.WritePropertyName("IsCover");
                            writer.WriteBooleanValue(itm2.IsCover);
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
                
                // EdgeLinks
                writer.WritePropertyName("EdgeLinks");
                if (value.Data.EdgeLinks != null)
                {
                    writer.WriteStartArray();
                    foreach(var itm3 in value.Data.EdgeLinks)
                    {
                        if (itm3 != null)
                        {
                            writer.WriteStartObject();
                            
                            // Unknown
                            writer.WritePropertyName("Unknown");
                            writer.WriteNumberValue(itm3.Unknown);
                            
                            // Mesh
                            writer.WritePropertyName("Mesh");
                            writer.WriteStringValue(itm3.Mesh.FormKey.ToString());
                            
                            // TriangleIndex
                            writer.WritePropertyName("TriangleIndex");
                            writer.WriteNumberValue(itm3.TriangleIndex);
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
                
                // DoorTriangles
                writer.WritePropertyName("DoorTriangles");
                if (value.Data.DoorTriangles != null)
                {
                    writer.WriteStartArray();
                    foreach(var itm4 in value.Data.DoorTriangles)
                    {
                        if (itm4 != null)
                        {
                            writer.WriteStartObject();
                            
                            // TriangleBeforeDoor
                            writer.WritePropertyName("TriangleBeforeDoor");
                            writer.WriteNumberValue(itm4.TriangleBeforeDoor);
                            
                            // Unknown
                            writer.WritePropertyName("Unknown");
                            writer.WriteNumberValue(itm4.Unknown);
                            
                            // Door
                            writer.WritePropertyName("Door");
                            writer.WriteStringValue(itm4.Door.FormKey.ToString());
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
                
                // NavmeshGridDivisor
                writer.WritePropertyName("NavmeshGridDivisor");
                writer.WriteNumberValue(value.Data.NavmeshGridDivisor);
                
                // MaxDistanceX
                writer.WritePropertyName("MaxDistanceX");
                writer.WriteNumberValue(value.Data.MaxDistanceX);
                
                // MaxDistanceY
                writer.WritePropertyName("MaxDistanceY");
                writer.WriteNumberValue(value.Data.MaxDistanceY);
                
                // Min
                writer.WritePropertyName("Min");
                writer.WriteP3Float(value.Data.Min, options);
                
                // Max
                writer.WritePropertyName("Max");
                writer.WriteP3Float(value.Data.Max, options);
                
                // NavmeshGrid
                writer.WritePropertyName("NavmeshGrid");
                writer.WriteBase64StringValue(value.Data.NavmeshGrid);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }
            
            // ONAM
            writer.WritePropertyName("ONAM");
            if (value.ONAM == null)
                writer.WriteNullValue();
            else
            {
                writer.WriteBase64StringValue(value.ONAM.Value);
            }
            
            // PNAM
            writer.WritePropertyName("PNAM");
            if (value.PNAM == null)
                writer.WriteNullValue();
            else
            {
                writer.WriteBase64StringValue(value.PNAM.Value);
            }
            
            // NNAM
            writer.WritePropertyName("NNAM");
            if (value.NNAM == null)
                writer.WriteNullValue();
            else
            {
                writer.WriteBase64StringValue(value.NNAM.Value);
            }
            
            // MajorFlags
            writer.WritePropertyName("MajorFlags");
            writer.WriteFlags(value.MajorFlags);
            
            // FormVersion
            writer.WritePropertyName("FormVersion");
            writer.WriteNumberValue((uint)value.FormVersion);
            
            // Version2
            writer.WritePropertyName("Version2");
            writer.WriteNumberValue((uint)value.Version2);
            
            // IsCompressed
            writer.WritePropertyName("IsCompressed");
            writer.WriteBooleanValue(value.IsCompressed);
            
            // IsDeleted
            writer.WritePropertyName("IsDeleted");
            writer.WriteBooleanValue(value.IsDeleted);
            
            // MajorRecordFlagsRaw
            writer.WritePropertyName("MajorRecordFlagsRaw");
            writer.WriteNumberValue(value.MajorRecordFlagsRaw);
            
            // VersionControl
            writer.WritePropertyName("VersionControl");
            writer.WriteNumberValue(value.VersionControl);
            
            // EditorID
            writer.WritePropertyName("EditorID");
            writer.WriteStringValue(value.EditorID);
            writer.WriteEndObject();
        }
        else
        {
            writer.WriteNullValue();
        }
    }
}
