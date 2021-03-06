// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    public partial class WritableSubRes2ResourcesPutOperation : Operation<WritableSubRes2Resource>
    {
        private readonly OperationOrResponseInternals<WritableSubRes2Resource> _operation;

        /// <summary> Initializes a new instance of WritableSubRes2ResourcesPutOperation for mocking. </summary>
        protected WritableSubRes2ResourcesPutOperation()
        {
        }

        internal WritableSubRes2ResourcesPutOperation(ResourceOperationsBase operationsBase, Response<WritableSubRes2ResourceData> response)
        {
            _operation = new OperationOrResponseInternals<WritableSubRes2Resource>(Response.FromValue(new WritableSubRes2Resource(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override WritableSubRes2Resource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WritableSubRes2Resource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WritableSubRes2Resource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
