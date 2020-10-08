// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics.Models
{
    public partial class MediaGraphCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static MediaGraphCredentials DeserializeMediaGraphCredentials(JsonElement element)
        {
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.MediaGraphHttpHeaderCredentials": return MediaGraphHttpHeaderCredentials.DeserializeMediaGraphHttpHeaderCredentials(element);
                    case "#Microsoft.Media.MediaGraphUsernamePasswordCredentials": return MediaGraphUsernamePasswordCredentials.DeserializeMediaGraphUsernamePasswordCredentials(element);
                }
            }
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphCredentials(type);
        }
    }
}
