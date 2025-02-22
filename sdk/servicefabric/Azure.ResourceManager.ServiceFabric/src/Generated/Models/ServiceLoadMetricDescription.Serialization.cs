// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServiceLoadMetricDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteStringValue(Weight.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryDefaultLoad))
            {
                writer.WritePropertyName("primaryDefaultLoad"u8);
                writer.WriteNumberValue(PrimaryDefaultLoad.Value);
            }
            if (Optional.IsDefined(SecondaryDefaultLoad))
            {
                writer.WritePropertyName("secondaryDefaultLoad"u8);
                writer.WriteNumberValue(SecondaryDefaultLoad.Value);
            }
            if (Optional.IsDefined(DefaultLoad))
            {
                writer.WritePropertyName("defaultLoad"u8);
                writer.WriteNumberValue(DefaultLoad.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceLoadMetricDescription DeserializeServiceLoadMetricDescription(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<ServiceLoadMetricWeight> weight = default;
            Optional<int> primaryDefaultLoad = default;
            Optional<int> secondaryDefaultLoad = default;
            Optional<int> defaultLoad = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weight = new ServiceLoadMetricWeight(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryDefaultLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryDefaultLoad = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("secondaryDefaultLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    secondaryDefaultLoad = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultLoad = property.Value.GetInt32();
                    continue;
                }
            }
            return new ServiceLoadMetricDescription(name, Optional.ToNullable(weight), Optional.ToNullable(primaryDefaultLoad), Optional.ToNullable(secondaryDefaultLoad), Optional.ToNullable(defaultLoad));
        }
    }
}
