// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeDeviceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DataResidency))
            {
                writer.WritePropertyName("dataResidency"u8);
                writer.WriteObjectValue(DataResidency);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeDeviceData DeserializeDataBoxEdgeDeviceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataBoxEdgeSku> sku = default;
            Optional<ETag> etag = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<DataBoxEdgeDeviceKind> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DataBoxEdgeDeviceStatus> dataBoxEdgeDeviceStatus = default;
            Optional<string> serialNumber = default;
            Optional<string> description = default;
            Optional<string> modelDescription = default;
            Optional<DataBoxEdgeDeviceType> deviceType = default;
            Optional<string> friendlyName = default;
            Optional<string> culture = default;
            Optional<string> deviceModel = default;
            Optional<string> deviceSoftwareVersion = default;
            Optional<long> deviceLocalCapacity = default;
            Optional<string> timeZone = default;
            Optional<string> deviceHcsVersion = default;
            Optional<IReadOnlyList<DataBoxEdgeRoleType>> configuredRoleTypes = default;
            Optional<int> nodeCount = default;
            Optional<DataBoxEdgeResourceMoveDetails> resourceMoveDetails = default;
            Optional<EdgeProfile> edgeProfile = default;
            Optional<DataResidency> dataResidency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = DataBoxEdgeSku.DeserializeDataBoxEdgeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new DataBoxEdgeDeviceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("dataBoxEdgeDeviceStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataBoxEdgeDeviceStatus = new DataBoxEdgeDeviceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("modelDescription"u8))
                        {
                            modelDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deviceType = new DataBoxEdgeDeviceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("culture"u8))
                        {
                            culture = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceModel"u8))
                        {
                            deviceModel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceSoftwareVersion"u8))
                        {
                            deviceSoftwareVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceLocalCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deviceLocalCapacity = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("timeZone"u8))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceHcsVersion"u8))
                        {
                            deviceHcsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configuredRoleTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataBoxEdgeRoleType> array = new List<DataBoxEdgeRoleType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DataBoxEdgeRoleType(item.GetString()));
                            }
                            configuredRoleTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("resourceMoveDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceMoveDetails = DataBoxEdgeResourceMoveDetails.DeserializeDataBoxEdgeResourceMoveDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("edgeProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            edgeProfile = EdgeProfile.DeserializeEdgeProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataResidency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataResidency = DataResidency.DeserializeDataResidency(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataBoxEdgeDeviceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, Optional.ToNullable(etag), identity, Optional.ToNullable(kind), Optional.ToNullable(dataBoxEdgeDeviceStatus), serialNumber.Value, description.Value, modelDescription.Value, Optional.ToNullable(deviceType), friendlyName.Value, culture.Value, deviceModel.Value, deviceSoftwareVersion.Value, Optional.ToNullable(deviceLocalCapacity), timeZone.Value, deviceHcsVersion.Value, Optional.ToList(configuredRoleTypes), Optional.ToNullable(nodeCount), resourceMoveDetails.Value, edgeProfile.Value, dataResidency.Value);
        }
    }
}
