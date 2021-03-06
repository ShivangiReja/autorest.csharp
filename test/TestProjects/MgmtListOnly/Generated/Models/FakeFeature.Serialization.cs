// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtListOnly.Models
{
    public partial class FakeFeature
    {
        internal static FakeFeature DeserializeFakeFeature(JsonElement element)
        {
            Optional<string> foo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("foo"))
                {
                    foo = property.Value.GetString();
                    continue;
                }
            }
            return new FakeFeature(foo.Value);
        }
    }
}
