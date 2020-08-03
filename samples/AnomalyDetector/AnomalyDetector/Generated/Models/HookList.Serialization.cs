// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class HookList
    {
        internal static HookList DeserializeHookList(JsonElement element)
        {
            string nextLink = default;
            IReadOnlyList<HookListValueItem> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HookListValueItem> array = new List<HookListValueItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(HookListValueItem.DeserializeHookListValueItem(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new HookList(nextLink, value);
        }
    }
}
