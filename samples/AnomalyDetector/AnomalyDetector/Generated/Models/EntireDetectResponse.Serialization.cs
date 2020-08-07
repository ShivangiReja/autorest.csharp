// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class EntireDetectResponse
    {
        internal static EntireDetectResponse DeserializeEntireDetectResponse(JsonElement element)
        {
            int period = default;
            IReadOnlyList<float> expectedValues = default;
            IReadOnlyList<float> upperMargins = default;
            IReadOnlyList<float> lowerMargins = default;
            IReadOnlyList<bool> isAnomaly = default;
            IReadOnlyList<bool> isNegativeAnomaly = default;
            IReadOnlyList<bool> isPositiveAnomaly = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("period"))
                {
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expectedValues"))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    expectedValues = array;
                    continue;
                }
                if (property.NameEquals("upperMargins"))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    upperMargins = array;
                    continue;
                }
                if (property.NameEquals("lowerMargins"))
                {
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    lowerMargins = array;
                    continue;
                }
                if (property.NameEquals("isAnomaly"))
                {
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isAnomaly = array;
                    continue;
                }
                if (property.NameEquals("isNegativeAnomaly"))
                {
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isNegativeAnomaly = array;
                    continue;
                }
                if (property.NameEquals("isPositiveAnomaly"))
                {
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isPositiveAnomaly = array;
                    continue;
                }
            }
            return new EntireDetectResponse(period, expectedValues, upperMargins, lowerMargins, isAnomaly, isNegativeAnomaly, isPositiveAnomaly);
        }
    }
}
