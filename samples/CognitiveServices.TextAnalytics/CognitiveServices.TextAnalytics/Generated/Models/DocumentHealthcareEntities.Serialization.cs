// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class DocumentHealthcareEntities
    {
        internal static DocumentHealthcareEntities DeserializeDocumentHealthcareEntities(JsonElement element)
        {
            string id = default;
            IReadOnlyList<HealthcareEntity> entities = default;
            IReadOnlyList<HealthcareRelation> relations = default;
            IReadOnlyList<TextAnalyticsWarning> warnings = default;
            Optional<DocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<HealthcareEntity> array = new List<HealthcareEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntity.DeserializeHealthcareEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("relations"))
                {
                    List<HealthcareRelation> array = new List<HealthcareRelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelation.DeserializeHealthcareRelation(item));
                    }
                    relations = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<TextAnalyticsWarning> array = new List<TextAnalyticsWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsWarning.DeserializeTextAnalyticsWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    statistics = DocumentStatistics.DeserializeDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new DocumentHealthcareEntities(id, entities, relations, warnings, statistics.Value);
        }
    }
}
