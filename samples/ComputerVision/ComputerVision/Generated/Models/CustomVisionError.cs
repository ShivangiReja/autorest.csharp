// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ComputerVision.Models
{
    /// <summary> The CustomVisionError. </summary>
    internal partial class CustomVisionError
    {
        /// <summary> Initializes a new instance of CustomVisionError. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> A message explaining the error reported by the service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal CustomVisionError(CustomVisionErrorCodes code, string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
        }

        /// <summary> The error code. </summary>
        public CustomVisionErrorCodes Code { get; }
        /// <summary> A message explaining the error reported by the service. </summary>
        public string Message { get; }
    }
}
