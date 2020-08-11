// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveServices.TextAnalytics.Models
{
    internal static class ErrorCodeValueExtensions
    {
        public static string ToSerialString(this ErrorCodeValue value) => value switch
        {
            ErrorCodeValue.InvalidRequest => "InvalidRequest",
            ErrorCodeValue.InvalidArgument => "InvalidArgument",
            ErrorCodeValue.InternalServerError => "InternalServerError",
            ErrorCodeValue.ServiceUnavailable => "ServiceUnavailable",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ErrorCodeValue value.")
        };

        public static ErrorCodeValue ToErrorCodeValue(this string value)
        {
            if (string.Equals(value, "InvalidRequest", StringComparison.InvariantCultureIgnoreCase)) return ErrorCodeValue.InvalidRequest;
            if (string.Equals(value, "InvalidArgument", StringComparison.InvariantCultureIgnoreCase)) return ErrorCodeValue.InvalidArgument;
            if (string.Equals(value, "InternalServerError", StringComparison.InvariantCultureIgnoreCase)) return ErrorCodeValue.InternalServerError;
            if (string.Equals(value, "ServiceUnavailable", StringComparison.InvariantCultureIgnoreCase)) return ErrorCodeValue.ServiceUnavailable;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ErrorCodeValue value.");
        }
    }
}
