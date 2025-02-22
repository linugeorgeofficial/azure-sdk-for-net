// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class PrivateLinkServiceProxy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(RemotePrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("remotePrivateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(RemotePrivateLinkServiceConnectionState);
            }
            if (Optional.IsDefined(RemotePrivateEndpointConnection))
            {
                writer.WritePropertyName("remotePrivateEndpointConnection"u8);
                JsonSerializer.Serialize(writer, RemotePrivateEndpointConnection);
            }
            if (Optional.IsCollectionDefined(GroupConnectivityInformation))
            {
                writer.WritePropertyName("groupConnectivityInformation"u8);
                writer.WriteStartArray();
                foreach (var item in GroupConnectivityInformation)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PrivateLinkServiceProxy DeserializePrivateLinkServiceProxy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<DeviceUpdatePrivateLinkServiceConnectionState> remotePrivateLinkServiceConnectionState = default;
            Optional<SubResource> remotePrivateEndpointConnection = default;
            Optional<IList<GroupConnectivityInformation>> groupConnectivityInformation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remotePrivateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    remotePrivateLinkServiceConnectionState = DeviceUpdatePrivateLinkServiceConnectionState.DeserializeDeviceUpdatePrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
                if (property.NameEquals("remotePrivateEndpointConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    remotePrivateEndpointConnection = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("groupConnectivityInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GroupConnectivityInformation> array = new List<GroupConnectivityInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.GroupConnectivityInformation.DeserializeGroupConnectivityInformation(item));
                    }
                    groupConnectivityInformation = array;
                    continue;
                }
            }
            return new PrivateLinkServiceProxy(id.Value, remotePrivateLinkServiceConnectionState.Value, remotePrivateEndpointConnection, Optional.ToList(groupConnectivityInformation));
        }
    }
}
