// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.DelegatedNetwork.Models
{
    internal partial class Orchestrators
    {
        internal static Orchestrators DeserializeOrchestrators(JsonElement element)
        {
            IReadOnlyList<Orchestrator> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<Orchestrator> array = new List<Orchestrator>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Orchestrator.DeserializeOrchestrator(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new Orchestrators(value, nextLink.Value);
        }
    }
}
