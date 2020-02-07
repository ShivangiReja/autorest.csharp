// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The Match. </summary>
    public partial class Match
    {
        /// <summary> If a well-known item is recognized, a decimal number denoting the confidence level between 0 and 1 will be returned. </summary>
        public double Score { get; set; }
        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; set; }
        /// <summary> Start position (in Unicode characters) for the entity match text. </summary>
        public int Offset { get; set; }
        /// <summary> Length (in Unicode characters) for the entity match text. </summary>
        public int Length { get; set; }
    }
}