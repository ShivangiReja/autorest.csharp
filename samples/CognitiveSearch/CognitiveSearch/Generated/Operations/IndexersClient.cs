// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    public partial class IndexersClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal IndexersRestClient RestClient { get; }
        /// <summary> Initializes a new instance of IndexersClient. </summary>
        internal IndexersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string searchServiceName, string searchDnsSuffix = "search.windows.net", string ApiVersion = "2019-05-06")
        {
            RestClient = new IndexersRestClient(clientDiagnostics, pipeline, searchServiceName, searchDnsSuffix, ApiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Resets the change tracking state associated with an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ResetAsync(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.ResetAsync(indexerName, clientRequestId, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Resets the change tracking state associated with an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Reset(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.Reset(indexerName, clientRequestId, cancellationToken);
        }
        /// <summary> Runs an indexer on-demand. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RunAsync(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.RunAsync(indexerName, clientRequestId, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Runs an indexer on-demand. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Run(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.Run(indexerName, clientRequestId, cancellationToken);
        }
        /// <summary> Creates a new indexer or updates an indexer if it already exists. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="indexer"> The definition of the indexer to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Indexer>> CreateOrUpdateAsync(string indexerName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, Indexer indexer, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(indexerName, clientRequestId, ifMatch, ifNoneMatch, indexer, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Creates a new indexer or updates an indexer if it already exists. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="indexer"> The definition of the indexer to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Indexer> CreateOrUpdate(string indexerName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, Indexer indexer, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(indexerName, clientRequestId, ifMatch, ifNoneMatch, indexer, cancellationToken);
        }
        /// <summary> Deletes an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string indexerName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(indexerName, clientRequestId, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Deletes an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string indexerName, Guid? clientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(indexerName, clientRequestId, ifMatch, ifNoneMatch, cancellationToken);
        }
        /// <summary> Retrieves an indexer definition. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Indexer>> GetAsync(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(indexerName, clientRequestId, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Retrieves an indexer definition. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Indexer> Get(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(indexerName, clientRequestId, cancellationToken);
        }
        /// <summary> Lists all indexers available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListIndexersResult>> ListAsync(string select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListAsync(select, clientRequestId, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Lists all indexers available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListIndexersResult> List(string select, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.List(select, clientRequestId, cancellationToken);
        }
        /// <summary> Creates a new indexer. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="indexer"> The definition of the indexer to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Indexer>> CreateAsync(Guid? clientRequestId, Indexer indexer, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(clientRequestId, indexer, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Creates a new indexer. </summary>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="indexer"> The definition of the indexer to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Indexer> Create(Guid? clientRequestId, Indexer indexer, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(clientRequestId, indexer, cancellationToken);
        }
        /// <summary> Returns the current status and execution history of an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IndexerExecutionInfo>> GetStatusAsync(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetStatusAsync(indexerName, clientRequestId, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Returns the current status and execution history of an indexer. </summary>
        /// <param name="indexerName"> The name of the indexer to reset. </param>
        /// <param name="clientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IndexerExecutionInfo> GetStatus(string indexerName, Guid? clientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.GetStatus(indexerName, clientRequestId, cancellationToken);
        }
    }
}