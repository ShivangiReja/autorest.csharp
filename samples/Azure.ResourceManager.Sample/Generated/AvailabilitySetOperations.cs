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

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing the operations that can be performed over a specific AvailabilitySet. </summary>
    public partial class AvailabilitySetOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, AvailabilitySet>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AvailabilitySetsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetOperations"/> class for mocking. </summary>
        protected AvailabilitySetOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal AvailabilitySetOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = Pipeline;
            RestClient = new AvailabilitySetsRestOperations(_clientDiagnostics, _pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/availabilitySets";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<AvailabilitySet>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<AvailabilitySet> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new AvailabilitySet(this, response.Value), response.GetRawResponse());
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

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartDeleteAsync");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartDelete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Operation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartDeleteAsync");
            scope.Start();
            try
            {
                var response = await RestClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an availability set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartDelete");
            scope.Start();
            try
            {
                var response = RestClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new AvailabilitySetsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<Response<AvailabilitySet>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.AddTagAsync");
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
        public Response<AvailabilitySet> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.AddTag");
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
        public async Task<AvailabilitySetsUpdateOperation> StartAddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartAddTagAsync");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new AvailabilitySetUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = await RestClient.UpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public AvailabilitySetsUpdateOperation StartAddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartAddTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new AvailabilitySetUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = RestClient.Update(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new AvailabilitySetsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<Response<AvailabilitySet>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.SetTagsAsync");
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
        public Response<AvailabilitySet> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.SetTags");
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
        public async Task<AvailabilitySetsUpdateOperation> StartSetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartSetTagsAsync");
            scope.Start();
            try
            {
                var patchable = new AvailabilitySetUpdate();
                patchable.Tags.ReplaceWith(tags);
                var response = await RestClient.UpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public AvailabilitySetsUpdateOperation StartSetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartSetTags");
            scope.Start();
            try
            {
                var patchable = new AvailabilitySetUpdate();
                patchable.Tags.ReplaceWith(tags);
                var response = RestClient.Update(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new AvailabilitySetsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<Response<AvailabilitySet>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.RemoveTagAsync");
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
        public Response<AvailabilitySet> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.RemoveTag");
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
        public async Task<AvailabilitySetsUpdateOperation> StartRemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartRemoveTagAsync");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new AvailabilitySetUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = await RestClient.UpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public AvailabilitySetsUpdateOperation StartRemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetOperations.StartRemoveTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new AvailabilitySetUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = RestClient.Update(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new AvailabilitySetsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
