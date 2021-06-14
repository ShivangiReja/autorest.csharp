// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> Extension methods for convenient access on SubscriptionOperations in a client. </summary>
    public static partial class SubscriptionExtensions
    {
        #region Account
        private static AccountsRestOperations GetAccountsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new AccountsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the Accounts for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<Account> ListAccountAsync(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetAccountsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscriptionAsync(clientDiagnostics, restOperations);
                return new PhWrappingAsyncPageable<AccountData, Account>(
                result,
                s => new Account(subscription, s));
            }
            );
        }

        /// <summary> Returns list of Accounts. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static AsyncPageable<AccountData> ListBySubscriptionAsync(ClientDiagnostics clientDiagnostics, AccountsRestOperations restOperations, CancellationToken cancellationToken = default)
        {
            async Task<Page<AccountData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("AccountOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AccountData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("AccountOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the Accounts for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<Account> ListAccount(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetAccountsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscription(clientDiagnostics, restOperations);
                return new PhWrappingPageable<AccountData, Account>(
                result,
                s => new Account(subscription, s));
            }
            );
        }

        /// <summary> Returns list of Accounts. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static Pageable<AccountData> ListBySubscription(ClientDiagnostics clientDiagnostics, AccountsRestOperations restOperations, CancellationToken cancellationToken = default)
        {
            Page<AccountData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("AccountOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AccountData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("AccountOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscriptionNextPage(nextLink, cancellationToken);
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

        /// <summary> Filters the list of Accounts for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<GenericResource> ListAccountByNameAsync(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(AccountOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, top, cancellationToken);
        }

        /// <summary> Filters the list of Accounts for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<GenericResource> ListAccountByName(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(AccountOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, top, cancellationToken);
        }
        #endregion
    }
}
