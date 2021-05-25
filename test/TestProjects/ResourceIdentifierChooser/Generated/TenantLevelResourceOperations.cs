// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing the operations that can be performed over a specific TenantLevelResource. </summary>
    public partial class TenantLevelResourceOperations : ResourceOperationsBase<TenantResourceIdentifier, TenantLevelResource>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TenantLevelResourcesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="TenantLevelResourceOperations"/> class for mocking. </summary>
        protected TenantLevelResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantLevelResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal TenantLevelResourceOperations(ResourceOperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = Pipeline;
            Id.TryGetSubscriptionId(out var subscriptionId);
            RestClient = new TenantLevelResourcesRestOperations(_clientDiagnostics, _pipeline, subscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/TenantLevelResources";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<TenantLevelResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantLevelResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<TenantLevelResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.Name, cancellationToken);
                return Response.FromValue(new TenantLevelResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<Response<TenantLevelResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.AddTagAsync");
            scope.Start();
            try
            {
                var operation = await StartAddTagAsync(key, value, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public Response<TenantLevelResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.AddTag");
            scope.Start();
            try
            {
                var operation = StartAddTag(key, value, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<TenantLevelResourcesPutOperation> StartAddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.StartAddTagAsync");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TenantLevelResourceData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = await RestClient.PutAsync(Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new TenantLevelResourcesPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public TenantLevelResourcesPutOperation StartAddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.StartAddTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TenantLevelResourceData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = RestClient.Put(Id.Name, patchable, cancellationToken);
                return new TenantLevelResourcesPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<Response<TenantLevelResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.SetTagsAsync");
            scope.Start();
            try
            {
                var operation = await StartSetTagsAsync(tags, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public Response<TenantLevelResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.SetTags");
            scope.Start();
            try
            {
                var operation = StartSetTags(tags, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<TenantLevelResourcesPutOperation> StartSetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.StartSetTagsAsync");
            scope.Start();
            try
            {
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TenantLevelResourceData(locationData);
                patchable.Tags.ReplaceWith(tags);
                var response = await RestClient.PutAsync(Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new TenantLevelResourcesPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public TenantLevelResourcesPutOperation StartSetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.StartSetTags");
            scope.Start();
            try
            {
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TenantLevelResourceData(locationData);
                patchable.Tags.ReplaceWith(tags);
                var response = RestClient.Put(Id.Name, patchable, cancellationToken);
                return new TenantLevelResourcesPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<Response<TenantLevelResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.RemoveTagAsync");
            scope.Start();
            try
            {
                var operation = await StartRemoveTagAsync(key, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public Response<TenantLevelResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.RemoveTag");
            scope.Start();
            try
            {
                var operation = StartRemoveTag(key, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<TenantLevelResourcesPutOperation> StartRemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.StartRemoveTagAsync");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TenantLevelResourceData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = await RestClient.PutAsync(Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new TenantLevelResourcesPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public TenantLevelResourcesPutOperation StartRemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceOperations.StartRemoveTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new TenantLevelResourceData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = RestClient.Put(Id.Name, patchable, cancellationToken);
                return new TenantLevelResourcesPutOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
