// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> Model1 inherits from Model2. </summary>
    public partial class Model1 : Model2
    {
        /// <summary> Initializes a new instance of Model1. </summary>
        /// <param name="location"> The location. </param>
        public Model1(LocationData location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of Model1. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="mango"> Fruit. </param>
        /// <param name="strawberry"> Fruit. </param>
        internal Model1(ResourceGroupResourceIdentifier id, string name, ResourceType type, LocationData location, IDictionary<string, string> tags, string mango, string strawberry) : base(id, name, type, location, tags, mango)
        {
            Strawberry = strawberry;
        }

        /// <summary> Fruit. </summary>
        public string Strawberry { get; set; }
    }
}
