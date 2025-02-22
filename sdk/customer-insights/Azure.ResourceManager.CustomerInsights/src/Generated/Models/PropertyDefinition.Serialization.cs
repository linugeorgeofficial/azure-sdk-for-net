// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PropertyDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ArrayValueSeparator))
            {
                writer.WritePropertyName("arrayValueSeparator"u8);
                writer.WriteStringValue(ArrayValueSeparator);
            }
            if (Optional.IsCollectionDefined(EnumValidValues))
            {
                writer.WritePropertyName("enumValidValues"u8);
                writer.WriteStartArray();
                foreach (var item in EnumValidValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("fieldName"u8);
            writer.WriteStringValue(FieldName);
            writer.WritePropertyName("fieldType"u8);
            writer.WriteStringValue(FieldType);
            if (Optional.IsDefined(IsArray))
            {
                writer.WritePropertyName("isArray"u8);
                writer.WriteBooleanValue(IsArray.Value);
            }
            if (Optional.IsDefined(IsEnum))
            {
                writer.WritePropertyName("isEnum"u8);
                writer.WriteBooleanValue(IsEnum.Value);
            }
            if (Optional.IsDefined(IsFlagEnum))
            {
                writer.WritePropertyName("isFlagEnum"u8);
                writer.WriteBooleanValue(IsFlagEnum.Value);
            }
            if (Optional.IsDefined(IsImage))
            {
                writer.WritePropertyName("isImage"u8);
                writer.WriteBooleanValue(IsImage.Value);
            }
            if (Optional.IsDefined(IsLocalizedString))
            {
                writer.WritePropertyName("isLocalizedString"u8);
                writer.WriteBooleanValue(IsLocalizedString.Value);
            }
            if (Optional.IsDefined(IsName))
            {
                writer.WritePropertyName("isName"u8);
                writer.WriteBooleanValue(IsName.Value);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("isRequired"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (Optional.IsDefined(PropertyId))
            {
                writer.WritePropertyName("propertyId"u8);
                writer.WriteStringValue(PropertyId);
            }
            if (Optional.IsDefined(SchemaItemPropLink))
            {
                writer.WritePropertyName("schemaItemPropLink"u8);
                writer.WriteStringValue(SchemaItemPropLink);
            }
            if (Optional.IsDefined(MaxLength))
            {
                writer.WritePropertyName("maxLength"u8);
                writer.WriteNumberValue(MaxLength.Value);
            }
            if (Optional.IsDefined(IsAvailableInGraph))
            {
                writer.WritePropertyName("isAvailableInGraph"u8);
                writer.WriteBooleanValue(IsAvailableInGraph.Value);
            }
            writer.WriteEndObject();
        }

        internal static PropertyDefinition DeserializePropertyDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> arrayValueSeparator = default;
            Optional<IList<ProfileEnumValidValuesFormat>> enumValidValues = default;
            string fieldName = default;
            string fieldType = default;
            Optional<bool> isArray = default;
            Optional<bool> isEnum = default;
            Optional<bool> isFlagEnum = default;
            Optional<bool> isImage = default;
            Optional<bool> isLocalizedString = default;
            Optional<bool> isName = default;
            Optional<bool> isRequired = default;
            Optional<string> propertyId = default;
            Optional<string> schemaItemPropLink = default;
            Optional<int> maxLength = default;
            Optional<bool> isAvailableInGraph = default;
            Optional<IReadOnlyList<DataSourcePrecedence>> dataSourcePrecedenceRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arrayValueSeparator"u8))
                {
                    arrayValueSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enumValidValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProfileEnumValidValuesFormat> array = new List<ProfileEnumValidValuesFormat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProfileEnumValidValuesFormat.DeserializeProfileEnumValidValuesFormat(item));
                    }
                    enumValidValues = array;
                    continue;
                }
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldType"u8))
                {
                    fieldType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArray"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isArray = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEnum = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isFlagEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isFlagEnum = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isImage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isLocalizedString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isLocalizedString = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isName = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("propertyId"u8))
                {
                    propertyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaItemPropLink"u8))
                {
                    schemaItemPropLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isAvailableInGraph"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAvailableInGraph = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dataSourcePrecedenceRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataSourcePrecedence> array = new List<DataSourcePrecedence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataSourcePrecedence.DeserializeDataSourcePrecedence(item));
                    }
                    dataSourcePrecedenceRules = array;
                    continue;
                }
            }
            return new PropertyDefinition(arrayValueSeparator.Value, Optional.ToList(enumValidValues), fieldName, fieldType, Optional.ToNullable(isArray), Optional.ToNullable(isEnum), Optional.ToNullable(isFlagEnum), Optional.ToNullable(isImage), Optional.ToNullable(isLocalizedString), Optional.ToNullable(isName), Optional.ToNullable(isRequired), propertyId.Value, schemaItemPropLink.Value, Optional.ToNullable(maxLength), Optional.ToNullable(isAvailableInGraph), Optional.ToList(dataSourcePrecedenceRules));
        }
    }
}
