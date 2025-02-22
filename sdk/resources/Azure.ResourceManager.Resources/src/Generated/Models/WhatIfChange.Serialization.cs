// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class WhatIfChange
    {
        internal static WhatIfChange DeserializeWhatIfChange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            WhatIfChangeType changeType = default;
            Optional<string> unsupportedReason = default;
            Optional<BinaryData> before = default;
            Optional<BinaryData> after = default;
            Optional<IReadOnlyList<WhatIfPropertyChange>> delta = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changeType"u8))
                {
                    changeType = property.Value.GetString().ToWhatIfChangeType();
                    continue;
                }
                if (property.NameEquals("unsupportedReason"u8))
                {
                    unsupportedReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("before"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    before = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("after"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    after = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WhatIfPropertyChange> array = new List<WhatIfPropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatIfPropertyChange.DeserializeWhatIfPropertyChange(item));
                    }
                    delta = array;
                    continue;
                }
            }
            return new WhatIfChange(resourceId, changeType, unsupportedReason.Value, before.Value, after.Value, Optional.ToList(delta));
        }
    }
}
