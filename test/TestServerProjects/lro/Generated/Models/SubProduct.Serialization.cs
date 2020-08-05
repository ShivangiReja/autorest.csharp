// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace lro.Models
{
    public partial class SubProduct : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SubProduct DeserializeSubProduct(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> provisioningState = default;
            Optional<SubProductPropertiesProvisioningStateValues> provisioningStateValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningStateValues"))
                        {
                            provisioningStateValues = new SubProductPropertiesProvisioningStateValues(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SubProduct(id.Value, provisioningState.Value, Optional.ToNullable(provisioningStateValues));
        }
    }
}
