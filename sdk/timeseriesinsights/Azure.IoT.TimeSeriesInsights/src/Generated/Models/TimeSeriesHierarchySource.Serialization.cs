// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesHierarchySource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(InstanceFieldNames))
            {
                writer.WritePropertyName("instanceFieldNames"u8);
                writer.WriteStartArray();
                foreach (var item in InstanceFieldNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static TimeSeriesHierarchySource DeserializeTimeSeriesHierarchySource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> instanceFieldNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceFieldNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    instanceFieldNames = array;
                    continue;
                }
            }
            return new TimeSeriesHierarchySource(Optional.ToList(instanceFieldNames));
        }
    }
}
