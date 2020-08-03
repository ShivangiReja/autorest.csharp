// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace AnomalyDetector.Models
{
    /// <summary> The IncidentResultList. </summary>
    public partial class IncidentResultList
    {
        /// <summary> Initializes a new instance of IncidentResultList. </summary>
        internal IncidentResultList()
        {
        }

        /// <summary> Initializes a new instance of IncidentResultList. </summary>
        /// <param name="nextLink"> . </param>
        /// <param name="value"> . </param>
        internal IncidentResultList(string nextLink, IReadOnlyList<IncidentResult> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        public string NextLink { get; }
        public IReadOnlyList<IncidentResult> Value { get; }
    }
}
