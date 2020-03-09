// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using extensible_enums_swagger.Models;

namespace extensible_enums_swagger
{
    public partial class PetClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal PetRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PetClient. </summary>
        internal PetClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new PetRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <param name="petId"> Pet id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Pet>> GetByPetIdAsync(string petId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetByPetIdAsync(petId, cancellationToken).ConfigureAwait(false);
        }
        /// <param name="petId"> Pet id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Pet> GetByPetId(string petId, CancellationToken cancellationToken = default)
        {
            return RestClient.GetByPetId(petId, cancellationToken);
        }
        /// <param name="petParam"> The Pet to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Pet>> AddPetAsync(Pet petParam, CancellationToken cancellationToken = default)
        {
            return await RestClient.AddPetAsync(petParam, cancellationToken).ConfigureAwait(false);
        }
        /// <param name="petParam"> The Pet to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Pet> AddPet(Pet petParam, CancellationToken cancellationToken = default)
        {
            return RestClient.AddPet(petParam, cancellationToken);
        }
    }
}