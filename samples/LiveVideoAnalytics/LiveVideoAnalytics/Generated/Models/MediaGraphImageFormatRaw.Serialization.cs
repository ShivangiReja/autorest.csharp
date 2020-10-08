// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics.Models
{
    public partial class MediaGraphImageFormatRaw : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PixelFormat))
            {
                writer.WritePropertyName("pixelFormat");
                writer.WriteStringValue(PixelFormat.Value.ToString());
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static MediaGraphImageFormatRaw DeserializeMediaGraphImageFormatRaw(JsonElement element)
        {
            Optional<MediaGraphImageFormatRawPixelFormat> pixelFormat = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pixelFormat"))
                {
                    pixelFormat = new MediaGraphImageFormatRawPixelFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphImageFormatRaw(type, Optional.ToNullable(pixelFormat));
        }
    }
}
