// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the operations that can be performed over a specific TrackedResourceModel2. </summary>
    public partial class TrackedResourceModel2Operations : ResourceOperationsBase<ResourceGroupResourceIdentifier, TrackedResourceModel2>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private TrackedResourceModel2SRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="TrackedResourceModel2Operations"/> class for mocking. </summary>
        protected TrackedResourceModel2Operations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TrackedResourceModel2Operations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal TrackedResourceModel2Operations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new TrackedResourceModel2SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/trackedResourceModel2s";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<TrackedResourceModel2>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TrackedResourceModel2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<TrackedResourceModel2> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new TrackedResourceModel2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async Task<Response<TrackedResourceModel2>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TrackedResourceModel2(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public Response<TrackedResourceModel2> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new TrackedResourceModel2(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async Task<Response<TrackedResourceModel2>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.SetTags");
            scope.Start();
            try
            {
                await TagResourceOperations.DeleteAsync(cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TrackedResourceModel2(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public Response<TrackedResourceModel2> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException($"{nameof(tags)} provided cannot be null.", nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.SetTags");
            scope.Start();
            try
            {
                TagResourceOperations.Delete(cancellationToken);
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new TrackedResourceModel2(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async Task<Response<TrackedResourceModel2>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResourceOperations.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagContainer.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TrackedResourceModel2(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public Response<TrackedResourceModel2> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException($"{nameof(key)} provided cannot be null or a whitespace.", nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel2Operations.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResourceOperations.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagContainer.CreateOrUpdate(originalTags.Value.Data, cancellationToken);
                var originalResponse = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new TrackedResourceModel2(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
