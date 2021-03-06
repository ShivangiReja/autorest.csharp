// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Output.Models.Serialization.Json
{
    internal class JsonAdditionalPropertiesSerialization
    {
        public ObjectTypeProperty Property { get; }
        public JsonSerialization ValueSerialization { get; }
        public CSharpType Type { get; }

        public JsonAdditionalPropertiesSerialization(ObjectTypeProperty property, JsonSerialization valueSerialization, CSharpType type)
        {
            Property = property;
            ValueSerialization = valueSerialization;
            Type = type;
        }
    }
}
