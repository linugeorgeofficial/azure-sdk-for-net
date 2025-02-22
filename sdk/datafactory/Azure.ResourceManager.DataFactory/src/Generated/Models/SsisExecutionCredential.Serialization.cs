// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisExecutionCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domain"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Domain);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Domain.ToString()).RootElement);
#endif
            writer.WritePropertyName("userName"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UserName);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(UserName.ToString()).RootElement);
#endif
            writer.WritePropertyName("password"u8);
            writer.WriteObjectValue(Password);
            writer.WriteEndObject();
        }

        internal static SsisExecutionCredential DeserializeSsisExecutionCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData domain = default;
            BinaryData userName = default;
            FactorySecretString password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    domain = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = FactorySecretString.DeserializeFactorySecretString(property.Value);
                    continue;
                }
            }
            return new SsisExecutionCredential(domain, userName, password);
        }
    }
}
