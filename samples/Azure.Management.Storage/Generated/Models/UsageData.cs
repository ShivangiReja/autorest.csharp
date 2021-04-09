// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> A class representing the Usage data model. </summary>
    public partial class UsageData
    {
        /// <summary> Initializes a new instance of UsageData. </summary>
        internal UsageData()
        {
        }

        /// <summary> Initializes a new instance of UsageData. </summary>
        /// <param name="unit"> Gets the unit of measurement. </param>
        /// <param name="currentValue"> Gets the current count of the allocated resources in the subscription. </param>
        /// <param name="limit"> Gets the maximum count of the resources that can be allocated in the subscription. </param>
        /// <param name="name"> Gets the name of the type of usage. </param>
        internal UsageData(UsageUnit? unit, int? currentValue, int? limit, UsageName name)
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Gets the unit of measurement. </summary>
        public UsageUnit? Unit { get; }
        /// <summary> Gets the current count of the allocated resources in the subscription. </summary>
        public int? CurrentValue { get; }
        /// <summary> Gets the maximum count of the resources that can be allocated in the subscription. </summary>
        public int? Limit { get; }
        /// <summary> Gets the name of the type of usage. </summary>
        public UsageName Name { get; }
    }
}