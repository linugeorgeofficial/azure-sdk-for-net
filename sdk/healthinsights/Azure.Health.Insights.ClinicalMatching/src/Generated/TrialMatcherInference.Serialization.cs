// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class TrialMatcherInference
    {
        internal static TrialMatcherInference DeserializeTrialMatcherInference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TrialMatcherInferenceType type = default;
            string value = default;
            Optional<string> description = default;
            Optional<float?> confidenceScore = default;
            Optional<IReadOnlyList<TrialMatcherInferenceEvidence>> evidence = default;
            Optional<string> id = default;
            Optional<ClinicalTrialSource?> source = default;
            Optional<ClinicalTrialMetadata> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new TrialMatcherInferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        confidenceScore = null;
                        continue;
                    }
                    confidenceScore = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("evidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TrialMatcherInferenceEvidence> array = new List<TrialMatcherInferenceEvidence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrialMatcherInferenceEvidence.DeserializeTrialMatcherInferenceEvidence(item));
                    }
                    evidence = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        source = null;
                        continue;
                    }
                    source = new ClinicalTrialSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = ClinicalTrialMetadata.DeserializeClinicalTrialMetadata(property.Value);
                    continue;
                }
            }
            return new TrialMatcherInference(type, value, description, Optional.ToNullable(confidenceScore), Optional.ToList(evidence), id, Optional.ToNullable(source), metadata);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrialMatcherInference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrialMatcherInference(document.RootElement);
        }
    }
}
