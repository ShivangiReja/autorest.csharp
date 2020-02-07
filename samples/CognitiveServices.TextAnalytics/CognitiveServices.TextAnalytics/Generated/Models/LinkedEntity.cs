// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The LinkedEntity. </summary>
    public partial class LinkedEntity
    {
        /// <summary> Entity Linking formal name. </summary>
        public string Name { get; set; }
        /// <summary> List of instances this entity appears in the text. </summary>
        public ICollection<Match> Matches { get; set; } = new System.Collections.Generic.List<CognitiveServices.TextAnalytics.Models.Match>();
        /// <summary> Language used in the data source. </summary>
        public string Language { get; set; }
        /// <summary> Unique identifier of the recognized entity from the data source. </summary>
        public string Id { get; set; }
        /// <summary> URL for the entity&apos;s page from the data source. </summary>
        public string Url { get; set; }
        /// <summary> Data source used to extract entity linking, such as Wiki/Bing etc. </summary>
        public string DataSource { get; set; }
    }
}