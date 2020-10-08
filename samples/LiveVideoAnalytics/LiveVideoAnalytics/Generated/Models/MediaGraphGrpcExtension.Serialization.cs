// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace LiveVideoAnalytics.Models
{
    public partial class MediaGraphGrpcExtension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataTransfer");
            writer.WriteObjectValue(DataTransfer);
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint");
                writer.WriteObjectValue(Endpoint);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image");
                writer.WriteObjectValue(Image);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MediaGraphGrpcExtension DeserializeMediaGraphGrpcExtension(JsonElement element)
        {
            MediaGraphGrpcExtensionDataTransfer dataTransfer = default;
            Optional<MediaGraphEndpoint> endpoint = default;
            Optional<MediaGraphImage> image = default;
            string type = default;
            string name = default;
            IList<MediaGraphNodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataTransfer"))
                {
                    dataTransfer = MediaGraphGrpcExtensionDataTransfer.DeserializeMediaGraphGrpcExtensionDataTransfer(property.Value);
                    continue;
                }
                if (property.NameEquals("endpoint"))
                {
                    endpoint = MediaGraphEndpoint.DeserializeMediaGraphEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    image = MediaGraphImage.DeserializeMediaGraphImage(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<MediaGraphNodeInput> array = new List<MediaGraphNodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaGraphNodeInput.DeserializeMediaGraphNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new MediaGraphGrpcExtension(type, name, inputs, endpoint.Value, image.Value, dataTransfer);
        }
    }
}
