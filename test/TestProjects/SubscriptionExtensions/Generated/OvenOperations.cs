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
using SubscriptionExtensions.Models;

namespace SubscriptionExtensions
{
    /// <summary> A class representing the operations that can be performed over a specific Oven. </summary>
    public partial class OvenOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, Oven>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal OvensRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="OvenOperations"/> class for mocking. </summary>
        protected OvenOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OvenOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal OvenOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = Pipeline;
            RestClient = new OvensRestOperations(_clientDiagnostics, _pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/virtualMachines";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<Oven>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Oven(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<Oven> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new Oven(this, response.Value), response.GetRawResponse());
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
        public async Task<Response<Oven>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.AddTagAsync");
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
        public Response<Oven> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.AddTag");
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
        public async Task<OvensCreateOrUpdateOperation> StartAddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenOperations.StartAddTagAsync");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new OvenData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = await RestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new OvensCreateOrUpdateOperation(this, _clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, patchable).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public OvensCreateOrUpdateOperation StartAddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenOperations.StartAddTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new OvenData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = RestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new OvensCreateOrUpdateOperation(this, _clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, patchable).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<Response<Oven>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.SetTagsAsync");
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
        public Response<Oven> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.SetTags");
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
        public async Task<OvensCreateOrUpdateOperation> StartSetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenOperations.StartSetTagsAsync");
            scope.Start();
            try
            {
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new OvenData(locationData);
                patchable.Tags.ReplaceWith(tags);
                var response = await RestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new OvensCreateOrUpdateOperation(this, _clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, patchable).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public OvensCreateOrUpdateOperation StartSetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenOperations.StartSetTags");
            scope.Start();
            try
            {
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new OvenData(locationData);
                patchable.Tags.ReplaceWith(tags);
                var response = RestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new OvensCreateOrUpdateOperation(this, _clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, patchable).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<Response<Oven>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.RemoveTagAsync");
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
        public Response<Oven> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenOperations.RemoveTag");
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
        public async Task<OvensCreateOrUpdateOperation> StartRemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenOperations.StartRemoveTagAsync");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new OvenData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = await RestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new OvensCreateOrUpdateOperation(this, _clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, patchable).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public OvensCreateOrUpdateOperation StartRemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenOperations.StartRemoveTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                Id.TryGetLocation(out LocationData locationData);
                var patchable = new OvenData(locationData);
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = RestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new OvensCreateOrUpdateOperation(this, _clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, patchable).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
