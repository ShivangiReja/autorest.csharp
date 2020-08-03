// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class SmartDetectionCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sensitivity");
            writer.WriteNumberValue(Sensitivity);
            writer.WritePropertyName("anomalyDetectorDirection");
            writer.WriteStringValue(AnomalyDetectorDirection.ToString());
            writer.WritePropertyName("suppressCondition");
            writer.WriteObjectValue(SuppressCondition);
            writer.WriteEndObject();
        }

        internal static SmartDetectionCondition DeserializeSmartDetectionCondition(JsonElement element)
        {
            double sensitivity = default;
            AnomalyDetectorDirection anomalyDetectorDirection = default;
            SuppressCondition suppressCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitivity"))
                {
                    sensitivity = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("anomalyDetectorDirection"))
                {
                    anomalyDetectorDirection = new AnomalyDetectorDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suppressCondition"))
                {
                    suppressCondition = SuppressCondition.DeserializeSuppressCondition(property.Value);
                    continue;
                }
            }
            return new SmartDetectionCondition(sensitivity, anomalyDetectorDirection, suppressCondition);
        }
    }
}
