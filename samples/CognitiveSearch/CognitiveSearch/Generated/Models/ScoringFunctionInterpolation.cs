// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Defines the function used to interpolate score boosting across a range of documents. </summary>
    public enum ScoringFunctionInterpolation
    {
        /// <summary> linear. </summary>
        Linear,
        /// <summary> constant. </summary>
        Constant,
        /// <summary> quadratic. </summary>
        Quadratic,
        /// <summary> logarithmic. </summary>
        Logarithmic
    }
}