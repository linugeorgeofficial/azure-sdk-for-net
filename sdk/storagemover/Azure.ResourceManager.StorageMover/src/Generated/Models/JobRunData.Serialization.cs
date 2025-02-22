// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageMover.Models;

namespace Azure.ResourceManager.StorageMover
{
    public partial class JobRunData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static JobRunData DeserializeJobRunData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<JobRunStatus> status = default;
            Optional<JobRunScanStatus> scanStatus = default;
            Optional<string> agentName = default;
            Optional<ResourceIdentifier> agentResourceId = default;
            Optional<DateTimeOffset> executionStartTime = default;
            Optional<DateTimeOffset> executionEndTime = default;
            Optional<DateTimeOffset> lastStatusUpdate = default;
            Optional<long> itemsScanned = default;
            Optional<long> itemsExcluded = default;
            Optional<long> itemsUnsupported = default;
            Optional<long> itemsNoTransferNeeded = default;
            Optional<long> itemsFailed = default;
            Optional<long> itemsTransferred = default;
            Optional<long> bytesScanned = default;
            Optional<long> bytesExcluded = default;
            Optional<long> bytesUnsupported = default;
            Optional<long> bytesNoTransferNeeded = default;
            Optional<long> bytesFailed = default;
            Optional<long> bytesTransferred = default;
            Optional<string> sourceName = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<BinaryData> sourceProperties = default;
            Optional<string> targetName = default;
            Optional<ResourceIdentifier> targetResourceId = default;
            Optional<BinaryData> targetProperties = default;
            Optional<BinaryData> jobDefinitionProperties = default;
            Optional<JobRunError> error = default;
            Optional<StorageMoverProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new JobRunStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scanStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scanStatus = new JobRunScanStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentName"u8))
                        {
                            agentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("agentResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            agentResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("executionStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            executionStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("executionEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            executionEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastStatusUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastStatusUpdate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("itemsScanned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            itemsScanned = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsExcluded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            itemsExcluded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsUnsupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            itemsUnsupported = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsNoTransferNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            itemsNoTransferNeeded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsFailed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            itemsFailed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("itemsTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            itemsTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesScanned"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bytesScanned = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesExcluded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bytesExcluded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesUnsupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bytesUnsupported = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesNoTransferNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bytesNoTransferNeeded = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesFailed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bytesFailed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sourceName"u8))
                        {
                            sourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sourceProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("targetName"u8))
                        {
                            targetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("jobDefinitionProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            jobDefinitionProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("error"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = JobRunError.DeserializeJobRunError(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new StorageMoverProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new JobRunData(id, name, type, systemData.Value, Optional.ToNullable(status), Optional.ToNullable(scanStatus), agentName.Value, agentResourceId.Value, Optional.ToNullable(executionStartTime), Optional.ToNullable(executionEndTime), Optional.ToNullable(lastStatusUpdate), Optional.ToNullable(itemsScanned), Optional.ToNullable(itemsExcluded), Optional.ToNullable(itemsUnsupported), Optional.ToNullable(itemsNoTransferNeeded), Optional.ToNullable(itemsFailed), Optional.ToNullable(itemsTransferred), Optional.ToNullable(bytesScanned), Optional.ToNullable(bytesExcluded), Optional.ToNullable(bytesUnsupported), Optional.ToNullable(bytesNoTransferNeeded), Optional.ToNullable(bytesFailed), Optional.ToNullable(bytesTransferred), sourceName.Value, sourceResourceId.Value, sourceProperties.Value, targetName.Value, targetResourceId.Value, targetProperties.Value, jobDefinitionProperties.Value, error.Value, Optional.ToNullable(provisioningState));
        }
    }
}
