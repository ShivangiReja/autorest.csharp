// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class CustomEntitiesTask : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters");
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("enable");
            writer.WriteBooleanValue(Enable);
            writer.WriteEndObject();
        }
    }
}
