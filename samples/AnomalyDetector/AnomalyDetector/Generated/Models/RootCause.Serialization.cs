// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class RootCause
    {
        internal static RootCause DeserializeRootCause(JsonElement element)
        {
            DimensionGroupIdentity rootCause = default;
            IReadOnlyList<string> path = default;
            double? score = default;
            string description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rootCause"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rootCause = DimensionGroupIdentity.DeserializeDimensionGroupIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    path = array;
                    continue;
                }
                if (property.NameEquals("score"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    score = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new RootCause(rootCause, path, score, description);
        }
    }
}
