// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Management.Storage.Models;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a PrivateEndpointConnection along with the instance operations that can be performed on it. </summary>
    public class PrivateEndpointConnection : PrivateEndpointConnectionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PrivateEndpointConnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PrivateEndpointConnection(ResourceOperationsBase options, PrivateEndpointConnectionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PrivateEndpointConnectionData. </summary>
        public PrivateEndpointConnectionData Data { get; private set; }
    }
}
