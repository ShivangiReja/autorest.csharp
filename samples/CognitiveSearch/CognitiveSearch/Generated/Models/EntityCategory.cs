// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> A string indicating what entity categories to return. </summary>
    public enum EntityCategory
    {
        /// <summary> location. </summary>
        Location,
        /// <summary> organization. </summary>
        Organization,
        /// <summary> person. </summary>
        Person,
        /// <summary> quantity. </summary>
        Quantity,
        /// <summary> datetime. </summary>
        Datetime,
        /// <summary> url. </summary>
        Url,
        /// <summary> email. </summary>
        Email
    }
}