// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A Class representing a SubscriptionLevelResource along with the instance operations that can be performed on it. </summary>
    public class SubscriptionLevelResource : SubscriptionLevelResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "SubscriptionLevelResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SubscriptionLevelResource(ResourceOperationsBase options, SubscriptionLevelResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the SubscriptionLevelResourceData. </summary>
        public SubscriptionLevelResourceData Data { get; private set; }
    }
}
