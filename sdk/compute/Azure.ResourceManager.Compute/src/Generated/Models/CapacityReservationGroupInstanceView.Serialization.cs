// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class CapacityReservationGroupInstanceView
    {
        internal static CapacityReservationGroupInstanceView DeserializeCapacityReservationGroupInstanceView(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<CapacityReservationInstanceViewWithName>> capacityReservations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacityReservations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CapacityReservationInstanceViewWithName> array = new List<CapacityReservationInstanceViewWithName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CapacityReservationInstanceViewWithName.DeserializeCapacityReservationInstanceViewWithName(item));
                    }
                    capacityReservations = array;
                    continue;
                }
            }
            return new CapacityReservationGroupInstanceView(Optional.ToList(capacityReservations));
        }
    }
}
