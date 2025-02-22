// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class TagResourceContractDetails
    {
        internal static TagResourceContractDetails DeserializeTagResourceContractDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AssociatedTagProperties tag = default;
            Optional<AssociatedApiProperties> api = default;
            Optional<AssociatedOperationProperties> operation = default;
            Optional<AssociatedProductProperties> product = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tag"u8))
                {
                    tag = AssociatedTagProperties.DeserializeAssociatedTagProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("api"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    api = AssociatedApiProperties.DeserializeAssociatedApiProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("operation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operation = AssociatedOperationProperties.DeserializeAssociatedOperationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("product"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    product = AssociatedProductProperties.DeserializeAssociatedProductProperties(property.Value);
                    continue;
                }
            }
            return new TagResourceContractDetails(tag, api.Value, operation.Value, product.Value);
        }
    }
}
