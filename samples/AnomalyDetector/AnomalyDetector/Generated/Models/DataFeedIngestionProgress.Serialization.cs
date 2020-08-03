// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class DataFeedIngestionProgress
    {
        internal static DataFeedIngestionProgress DeserializeDataFeedIngestionProgress(JsonElement element)
        {
            DateTimeOffset? latestSuccessTimestamp = default;
            DateTimeOffset? latestActiveTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latestSuccessTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latestSuccessTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("latestActiveTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latestActiveTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DataFeedIngestionProgress(latestSuccessTimestamp, latestActiveTimestamp);
        }
    }
}
