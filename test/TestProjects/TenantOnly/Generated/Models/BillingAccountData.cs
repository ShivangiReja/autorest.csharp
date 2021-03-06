// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace TenantOnly
{
    /// <summary> A class representing the BillingAccount data model. </summary>
    public partial class BillingAccountData : TrackedResource<TenantResourceIdentifier>
    {
        /// <summary> Initializes a new instance of BillingAccountData. </summary>
        /// <param name="location"> The location. </param>
        public BillingAccountData(LocationData location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of BillingAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="bar"> . </param>
        internal BillingAccountData(TenantResourceIdentifier id, string name, ResourceType type, LocationData location, IDictionary<string, string> tags, string bar) : base(id, name, type, location, tags)
        {
            Bar = bar;
        }

        public string Bar { get; set; }
    }
}
