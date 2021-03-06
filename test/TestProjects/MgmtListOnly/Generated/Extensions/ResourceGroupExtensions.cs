// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using MgmtListOnly.Models;

namespace MgmtListOnly
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region Fakes
        /// <summary> Gets an object representing a FakeContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="FakeContainer" /> object. </returns>
        public static FakeContainer GetFakes(this ResourceGroupOperations resourceGroup)
        {
            return new FakeContainer(resourceGroup);
        }
        #endregion

        #region ResourceGroupFeature
        private static ResourceGroupFeaturesRestOperations GetResourceGroupFeaturesRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ResourceGroupFeaturesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the ResourceGroupFeatures for this ResourceGroupOperations. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static AsyncPageable<ResourceGroupFeature> ListResourceGroupFeaturesAsync(this ResourceGroupOperations resourceGroup, string location, string expand = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceGroupFeaturesRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                async Task<Page<ResourceGroupFeature>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListResourceGroupFeatures");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(resourceGroup.Id.Name, location, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ResourceGroupFeature>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListResourceGroupFeatures");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, resourceGroup.Id.Name, location, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the ResourceGroupFeatures for this ResourceGroupOperations. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static Pageable<ResourceGroupFeature> ListResourceGroupFeatures(this ResourceGroupOperations resourceGroup, string location, string expand = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceGroupFeaturesRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                Page<ResourceGroupFeature> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListResourceGroupFeatures");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(resourceGroup.Id.Name, location, expand, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ResourceGroupFeature> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListResourceGroupFeatures");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, resourceGroup.Id.Name, location, expand, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        #endregion

        #region ResourceGroupNonPageableFeature
        private static ResourceGroupNonPageableFeaturesRestOperations GetResourceGroupNonPageableFeaturesRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ResourceGroupNonPageableFeaturesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists all features in a resource group. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static async Task<Response<IReadOnlyList<ResourceGroupNonPageableFeature>>> ListResourceGroupNonPageableFeaturesAsync(this ResourceGroupOperations resourceGroup, string location, string expand = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceGroupNonPageableFeaturesRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListResourceGroupNonPageableFeatures");
                scope.Start();
                try
                {
                    var response = await restOperations.ListAsync(resourceGroup.Id.Name, location, expand, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(response.Value.Value, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Lists all features in a resource group. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="location"> The location. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static Response<IReadOnlyList<ResourceGroupNonPageableFeature>> ListResourceGroupNonPageableFeatures(this ResourceGroupOperations resourceGroup, string location, string expand = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceGroupNonPageableFeaturesRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListResourceGroupNonPageableFeatures");
                scope.Start();
                try
                {
                    var response = restOperations.List(resourceGroup.Id.Name, location, expand, cancellationToken);
                    return Response.FromValue(response.Value.Value, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        #endregion

        #region Key
        private static KeysRestOperations GetKeysRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new KeysRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Publish a key. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="publisher"> The publisher. </param>
        /// <param name="version"> The version. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisher"/> or <paramref name="version"/> is null. </exception>
        public static async Task<Response<KeyPublishResult>> PublishKeyAsync(this ResourceGroupOperations resourceGroup, string publisher, string version, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetKeysRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PublishKey");
                scope.Start();
                try
                {
                    var response = await restOperations.PublishAsync(resourceGroup.Id.Name, publisher, version, expand, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Publish a key. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="publisher"> The publisher. </param>
        /// <param name="version"> The version. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisher"/> or <paramref name="version"/> is null. </exception>
        public static Response<KeyPublishResult> PublishKey(this ResourceGroupOperations resourceGroup, string publisher, string version, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetKeysRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.PublishKey");
                scope.Start();
                try
                {
                    var response = restOperations.Publish(resourceGroup.Id.Name, publisher, version, expand, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Get all the published keys. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="publisher"> The publisher. </param>
        /// <param name="version"> The version. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisher"/> or <paramref name="version"/> is null. </exception>
        public static async Task<Response<IReadOnlyList<PublishedKey>>> ListKeysPublishedAsync(this ResourceGroupOperations resourceGroup, string publisher, string version, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            return await resourceGroup.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetKeysRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListKeysPublished");
                scope.Start();
                try
                {
                    var response = await restOperations.ListPublishedAsync(resourceGroup.Id.Name, publisher, version, expand, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(response.Value.Value, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Get all the published keys. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <param name="publisher"> The publisher. </param>
        /// <param name="version"> The version. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisher"/> or <paramref name="version"/> is null. </exception>
        public static Response<IReadOnlyList<PublishedKey>> ListKeysPublished(this ResourceGroupOperations resourceGroup, string publisher, string version, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            return resourceGroup.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetKeysRestOperations(clientDiagnostics, credential, options, pipeline, resourceGroup.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("ResourceGroupExtensions.ListKeysPublished");
                scope.Start();
                try
                {
                    var response = restOperations.ListPublished(resourceGroup.Id.Name, publisher, version, expand, cancellationToken);
                    return Response.FromValue(response.Value.Value, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        #endregion
    }
}
