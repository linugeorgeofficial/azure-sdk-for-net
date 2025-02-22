// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForContainersGcpOffering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NativeCloudConnection))
            {
                writer.WritePropertyName("nativeCloudConnection"u8);
                writer.WriteObjectValue(NativeCloudConnection);
            }
            if (Optional.IsDefined(DataPipelineNativeCloudConnection))
            {
                writer.WritePropertyName("dataPipelineNativeCloudConnection"u8);
                writer.WriteObjectValue(DataPipelineNativeCloudConnection);
            }
            if (Optional.IsDefined(IsAuditLogsAutoProvisioningEnabled))
            {
                writer.WritePropertyName("auditLogsAutoProvisioningFlag"u8);
                writer.WriteBooleanValue(IsAuditLogsAutoProvisioningEnabled.Value);
            }
            if (Optional.IsDefined(IsDefenderAgentAutoProvisioningEnabled))
            {
                writer.WritePropertyName("defenderAgentAutoProvisioningFlag"u8);
                writer.WriteBooleanValue(IsDefenderAgentAutoProvisioningEnabled.Value);
            }
            if (Optional.IsDefined(IsPolicyAgentAutoProvisioningEnabled))
            {
                writer.WritePropertyName("policyAgentAutoProvisioningFlag"u8);
                writer.WriteBooleanValue(IsPolicyAgentAutoProvisioningEnabled.Value);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            writer.WriteEndObject();
        }

        internal static DefenderForContainersGcpOffering DeserializeDefenderForContainersGcpOffering(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DefenderForContainersGcpOfferingNativeCloudConnection> nativeCloudConnection = default;
            Optional<DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection> dataPipelineNativeCloudConnection = default;
            Optional<bool> auditLogsAutoProvisioningFlag = default;
            Optional<bool> defenderAgentAutoProvisioningFlag = default;
            Optional<bool> policyAgentAutoProvisioningFlag = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nativeCloudConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nativeCloudConnection = DefenderForContainersGcpOfferingNativeCloudConnection.DeserializeDefenderForContainersGcpOfferingNativeCloudConnection(property.Value);
                    continue;
                }
                if (property.NameEquals("dataPipelineNativeCloudConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataPipelineNativeCloudConnection = DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection.DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(property.Value);
                    continue;
                }
                if (property.NameEquals("auditLogsAutoProvisioningFlag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    auditLogsAutoProvisioningFlag = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defenderAgentAutoProvisioningFlag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defenderAgentAutoProvisioningFlag = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyAgentAutoProvisioningFlag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policyAgentAutoProvisioningFlag = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderForContainersGcpOffering(offeringType, description.Value, nativeCloudConnection.Value, dataPipelineNativeCloudConnection.Value, Optional.ToNullable(auditLogsAutoProvisioningFlag), Optional.ToNullable(defenderAgentAutoProvisioningFlag), Optional.ToNullable(policyAgentAutoProvisioningFlag));
        }
    }
}
