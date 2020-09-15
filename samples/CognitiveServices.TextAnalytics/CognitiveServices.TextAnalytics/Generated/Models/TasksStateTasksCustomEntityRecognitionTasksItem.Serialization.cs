// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class TasksStateTasksCustomEntityRecognitionTasksItem
    {
        internal static TasksStateTasksCustomEntityRecognitionTasksItem DeserializeTasksStateTasksCustomEntityRecognitionTasksItem(JsonElement element)
        {
            Optional<CustomEntitiesResult> results = default;
            DateTimeOffset lastUpdateDateTime = default;
            string name = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = CustomEntitiesResult.DeserializeCustomEntitiesResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
            }
            return new TasksStateTasksCustomEntityRecognitionTasksItem(lastUpdateDateTime, name, status, results.Value);
        }
    }
}
