// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_string.Models;

namespace body_string
{
    public partial class EnumClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal EnumRestClient RestClient { get; }
        /// <summary> Initializes a new instance of EnumClient. </summary>
        internal EnumClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new EnumRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Colors>> GetNotExpandableAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetNotExpandableAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Colors> GetNotExpandable(CancellationToken cancellationToken = default)
        {
            return RestClient.GetNotExpandable(cancellationToken);
        }
        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="stringBody"> The Colors to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutNotExpandableAsync(Colors stringBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutNotExpandableAsync(stringBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="stringBody"> The Colors to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutNotExpandable(Colors stringBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutNotExpandable(stringBody, cancellationToken);
        }
        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Colors>> GetReferencedAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetReferencedAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Colors> GetReferenced(CancellationToken cancellationToken = default)
        {
            return RestClient.GetReferenced(cancellationToken);
        }
        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="enumStringBody"> The Colors to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutReferencedAsync(Colors enumStringBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutReferencedAsync(enumStringBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="enumStringBody"> The Colors to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutReferenced(Colors enumStringBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutReferenced(enumStringBody, cancellationToken);
        }
        /// <summary> Get value &apos;green-color&apos; from the constant. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RefColorConstant>> GetReferencedConstantAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetReferencedConstantAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get value &apos;green-color&apos; from the constant. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RefColorConstant> GetReferencedConstant(CancellationToken cancellationToken = default)
        {
            return RestClient.GetReferencedConstant(cancellationToken);
        }
        /// <summary> Sends value &apos;green-color&apos; from a constant. </summary>
        /// <param name="enumStringBody"> The RefColorConstant to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutReferencedConstantAsync(RefColorConstant enumStringBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutReferencedConstantAsync(enumStringBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Sends value &apos;green-color&apos; from a constant. </summary>
        /// <param name="enumStringBody"> The RefColorConstant to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutReferencedConstant(RefColorConstant enumStringBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutReferencedConstant(enumStringBody, cancellationToken);
        }
    }
}