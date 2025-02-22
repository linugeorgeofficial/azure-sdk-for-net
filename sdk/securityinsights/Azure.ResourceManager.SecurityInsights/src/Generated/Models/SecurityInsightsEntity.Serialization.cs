// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static SecurityInsightsEntity DeserializeSecurityInsightsEntity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Account": return SecurityInsightsAccountEntity.DeserializeSecurityInsightsAccountEntity(element);
                    case "AzureResource": return SecurityInsightsAzureResourceEntity.DeserializeSecurityInsightsAzureResourceEntity(element);
                    case "Bookmark": return SecurityInsightsHuntingBookmark.DeserializeSecurityInsightsHuntingBookmark(element);
                    case "CloudApplication": return SecurityInsightsCloudApplicationEntity.DeserializeSecurityInsightsCloudApplicationEntity(element);
                    case "DnsResolution": return SecurityInsightsDnsEntity.DeserializeSecurityInsightsDnsEntity(element);
                    case "File": return SecurityInsightsFileEntity.DeserializeSecurityInsightsFileEntity(element);
                    case "FileHash": return SecurityInsightsFileHashEntity.DeserializeSecurityInsightsFileHashEntity(element);
                    case "Host": return SecurityInsightsHostEntity.DeserializeSecurityInsightsHostEntity(element);
                    case "IoTDevice": return SecurityInsightsIotDeviceEntity.DeserializeSecurityInsightsIotDeviceEntity(element);
                    case "Ip": return SecurityInsightsIPEntity.DeserializeSecurityInsightsIPEntity(element);
                    case "MailCluster": return SecurityInsightsMailClusterEntity.DeserializeSecurityInsightsMailClusterEntity(element);
                    case "MailMessage": return SecurityInsightsMailMessageEntity.DeserializeSecurityInsightsMailMessageEntity(element);
                    case "Mailbox": return SecurityInsightsMailboxEntity.DeserializeSecurityInsightsMailboxEntity(element);
                    case "Malware": return SecurityInsightsMalwareEntity.DeserializeSecurityInsightsMalwareEntity(element);
                    case "Process": return SecurityInsightsProcessEntity.DeserializeSecurityInsightsProcessEntity(element);
                    case "RegistryKey": return SecurityInsightsRegistryKeyEntity.DeserializeSecurityInsightsRegistryKeyEntity(element);
                    case "RegistryValue": return SecurityInsightsRegistryValueEntity.DeserializeSecurityInsightsRegistryValueEntity(element);
                    case "SecurityAlert": return SecurityInsightsAlert.DeserializeSecurityInsightsAlert(element);
                    case "SecurityGroup": return SecurityInsightsGroupEntity.DeserializeSecurityInsightsGroupEntity(element);
                    case "SubmissionMail": return SecurityInsightsSubmissionMailEntity.DeserializeSecurityInsightsSubmissionMailEntity(element);
                    case "Url": return SecurityInsightsUriEntity.DeserializeSecurityInsightsUriEntity(element);
                }
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
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
            }
            return new SecurityInsightsEntity(id, name, type, systemData.Value, kind);
        }
    }
}
