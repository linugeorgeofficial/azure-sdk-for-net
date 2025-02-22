// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class VirtualDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(DeviceKey))
            {
                writer.WritePropertyName("deviceKey"u8);
                writer.WriteNumberValue(DeviceKey.Value);
            }
            if (Optional.IsDefined(DiskMode))
            {
                writer.WritePropertyName("diskMode"u8);
                writer.WriteStringValue(DiskMode.Value.ToString());
            }
            if (Optional.IsDefined(ControllerKey))
            {
                writer.WritePropertyName("controllerKey"u8);
                writer.WriteNumberValue(ControllerKey.Value);
            }
            if (Optional.IsDefined(UnitNumber))
            {
                writer.WritePropertyName("unitNumber"u8);
                writer.WriteNumberValue(UnitNumber.Value);
            }
            if (Optional.IsDefined(DeviceName))
            {
                writer.WritePropertyName("deviceName"u8);
                writer.WriteStringValue(DeviceName);
            }
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static VirtualDisk DeserializeVirtualDisk(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> label = default;
            Optional<string> diskObjectId = default;
            Optional<int> diskSizeGB = default;
            Optional<int> deviceKey = default;
            Optional<DiskMode> diskMode = default;
            Optional<int> controllerKey = default;
            Optional<int> unitNumber = default;
            Optional<string> deviceName = default;
            Optional<DiskType> diskType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskObjectId"u8))
                {
                    diskObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deviceKey = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskMode = new DiskMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controllerKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    controllerKey = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unitNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unitNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceName"u8))
                {
                    deviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskType = new DiskType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualDisk(name.Value, label.Value, diskObjectId.Value, Optional.ToNullable(diskSizeGB), Optional.ToNullable(deviceKey), Optional.ToNullable(diskMode), Optional.ToNullable(controllerKey), Optional.ToNullable(unitNumber), deviceName.Value, Optional.ToNullable(diskType));
        }
    }
}
