// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class ComponentsIfu7BjSchemasTasksstatePropertiesTasksPropertiesEntitylinkingtasksItemsAllof1
    {
        internal static ComponentsIfu7BjSchemasTasksstatePropertiesTasksPropertiesEntitylinkingtasksItemsAllof1 DeserializeComponentsIfu7BjSchemasTasksstatePropertiesTasksPropertiesEntitylinkingtasksItemsAllof1(JsonElement element)
        {
            Optional<EntityLinkingResult> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = EntityLinkingResult.DeserializeEntityLinkingResult(property.Value);
                    continue;
                }
            }
            return new ComponentsIfu7BjSchemasTasksstatePropertiesTasksPropertiesEntitylinkingtasksItemsAllof1(results.Value);
        }
    }
}
