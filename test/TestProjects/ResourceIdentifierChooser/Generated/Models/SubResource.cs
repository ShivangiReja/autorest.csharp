// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ResourceIdentifierChooser
{
    /// <summary> Reference to another subresource. </summary>
    public partial class SubResource
    {
        /// <summary> Initializes a new instance of SubResource. </summary>
        public SubResource()
        {
        }

        /// <summary> Initializes a new instance of SubResource. </summary>
        /// <param name="id"> Resource ID. </param>
        internal SubResource(string id)
        {
            Id = id;
        }

        /// <summary> Resource ID. </summary>
        public string Id { get; set; }
    }
}