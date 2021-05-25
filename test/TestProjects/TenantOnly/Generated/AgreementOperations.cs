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

namespace TenantOnly
{
    /// <summary> A class representing the operations that can be performed over a specific Agreement. </summary>
    public partial class AgreementOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, Agreement>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AgreementsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="AgreementOperations"/> class for mocking. </summary>
        protected AgreementOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AgreementOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal AgreementOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = Pipeline;
            RestClient = new AgreementsRestOperations(_clientDiagnostics, _pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/agreements";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<Agreement>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<Agreement> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.Name, Id.Name, null, cancellationToken);
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an agreement by ID. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Agreement>> GetAsync(string expand, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an agreement by ID. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Agreement> Get(string expand, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.Name, Id.Name, expand, cancellationToken);
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
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
    }
}
