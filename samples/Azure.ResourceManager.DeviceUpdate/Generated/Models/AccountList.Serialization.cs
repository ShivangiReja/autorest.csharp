// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    internal partial class AccountList
    {
        internal static AccountList DeserializeAccountList(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<AccountData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AccountData> array = new List<AccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccountData.DeserializeAccountData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AccountList(nextLink.Value, Optional.ToList(value));
        }
    }
}
