// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace url_multi_collectionFormat
{
    public partial class QueriesClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal QueriesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of QueriesClient. </summary>
        internal QueriesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new QueriesRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArrayStringMultiNullAsync(IEnumerable<string> arrayQuery, CancellationToken cancellationToken = default)
        {
            return await RestClient.ArrayStringMultiNullAsync(arrayQuery, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get a null array of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> a null array of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ArrayStringMultiNull(IEnumerable<string> arrayQuery, CancellationToken cancellationToken = default)
        {
            return RestClient.ArrayStringMultiNull(arrayQuery, cancellationToken);
        }
        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArrayStringMultiEmptyAsync(IEnumerable<string> arrayQuery, CancellationToken cancellationToken = default)
        {
            return await RestClient.ArrayStringMultiEmptyAsync(arrayQuery, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get an empty array [] of string using the multi-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ArrayStringMultiEmpty(IEnumerable<string> arrayQuery, CancellationToken cancellationToken = default)
        {
            return RestClient.ArrayStringMultiEmpty(arrayQuery, cancellationToken);
        }
        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArrayStringMultiValidAsync(IEnumerable<string> arrayQuery, CancellationToken cancellationToken = default)
        {
            return await RestClient.ArrayStringMultiValidAsync(arrayQuery, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get an array of string [&apos;ArrayQuery1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the mult-array format. </summary>
        /// <param name="arrayQuery"> an empty array [] of string using the multi-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ArrayStringMultiValid(IEnumerable<string> arrayQuery, CancellationToken cancellationToken = default)
        {
            return RestClient.ArrayStringMultiValid(arrayQuery, cancellationToken);
        }
    }
}