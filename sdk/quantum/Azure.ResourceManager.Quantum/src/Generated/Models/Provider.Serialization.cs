// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quantum.Models
{
    public partial class Provider : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderId))
            {
                writer.WritePropertyName("providerId"u8);
                writer.WriteStringValue(ProviderId);
            }
            if (Optional.IsDefined(ProviderSku))
            {
                writer.WritePropertyName("providerSku"u8);
                writer.WriteStringValue(ProviderSku);
            }
            if (Optional.IsDefined(InstanceUri))
            {
                writer.WritePropertyName("instanceUri"u8);
                writer.WriteStringValue(InstanceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ApplicationName))
            {
                writer.WritePropertyName("applicationName"u8);
                writer.WriteStringValue(ApplicationName);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ResourceUsageId))
            {
                writer.WritePropertyName("resourceUsageId"u8);
                writer.WriteStringValue(ResourceUsageId);
            }
            writer.WriteEndObject();
        }

        internal static Provider DeserializeProvider(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> providerId = default;
            Optional<string> providerSku = default;
            Optional<Uri> instanceUri = default;
            Optional<string> applicationName = default;
            Optional<Status> provisioningState = default;
            Optional<string> resourceUsageId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerId"u8))
                {
                    providerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSku"u8))
                {
                    providerSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instanceUri = null;
                        continue;
                    }
                    instanceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationName"u8))
                {
                    applicationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new Status(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceUsageId"u8))
                {
                    resourceUsageId = property.Value.GetString();
                    continue;
                }
            }
            return new Provider(providerId.Value, providerSku.Value, instanceUri.Value, applicationName.Value, Optional.ToNullable(provisioningState), resourceUsageId.Value);
        }
    }
}
