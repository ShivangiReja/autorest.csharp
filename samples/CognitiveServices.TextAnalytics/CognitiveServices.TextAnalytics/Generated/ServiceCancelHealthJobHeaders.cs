// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace CognitiveServices.TextAnalytics
{
    internal class ServiceCancelHealthJobHeaders
    {
        private readonly Response _response;
        public ServiceCancelHealthJobHeaders(Response response)
        {
            _response = response;
        }
        public string OperationLocation => _response.Headers.TryGetValue("Operation-Location", out string value) ? value : null;
    }
}
