// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Request parameter to copy an existing custom model from the source resource to a target resource referenced by the resource ID. </summary>
    public partial class CopyRequest
    {
        /// <summary> Initializes a new instance of CopyRequest. </summary>
        /// <param name="targetResourceId"> Azure Resource Id of the target Form Recognizer resource where the model is copied to. </param>
        /// <param name="targetResourceRegion"> Location of the target Azure resource. A valid Azure region name supported by Cognitive Services. </param>
        /// <param name="copyAuthorization"> Entity that encodes claims to authorize the copy request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/>, <paramref name="targetResourceRegion"/>, or <paramref name="copyAuthorization"/> is null. </exception>
        public CopyRequest(string targetResourceId, string targetResourceRegion, CopyAuthorizationResult copyAuthorization)
        {
            if (targetResourceId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceId));
            }
            if (targetResourceRegion == null)
            {
                throw new ArgumentNullException(nameof(targetResourceRegion));
            }
            if (copyAuthorization == null)
            {
                throw new ArgumentNullException(nameof(copyAuthorization));
            }

            TargetResourceId = targetResourceId;
            TargetResourceRegion = targetResourceRegion;
            CopyAuthorization = copyAuthorization;
        }

        /// <summary> Azure Resource Id of the target Form Recognizer resource where the model is copied to. </summary>
        public string TargetResourceId { get; }
        /// <summary> Location of the target Azure resource. A valid Azure region name supported by Cognitive Services. </summary>
        public string TargetResourceRegion { get; }
        /// <summary> Entity that encodes claims to authorize the copy request. </summary>
        public CopyAuthorizationResult CopyAuthorization { get; }
    }
}
