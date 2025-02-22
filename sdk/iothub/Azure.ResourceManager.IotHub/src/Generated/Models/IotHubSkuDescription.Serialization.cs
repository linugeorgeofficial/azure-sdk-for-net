// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubSkuDescription
    {
        internal static IotHubSkuDescription DeserializeIotHubSkuDescription(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceType> resourceType = default;
            IotHubSkuInfo sku = default;
            IotHubCapacity capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = IotHubSkuInfo.DeserializeIotHubSkuInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    capacity = IotHubCapacity.DeserializeIotHubCapacity(property.Value);
                    continue;
                }
            }
            return new IotHubSkuDescription(Optional.ToNullable(resourceType), sku, capacity);
        }
    }
}
