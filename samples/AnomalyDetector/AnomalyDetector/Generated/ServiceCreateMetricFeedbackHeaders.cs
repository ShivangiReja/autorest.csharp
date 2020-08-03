// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace AnomalyDetector
{
    internal class ServiceCreateMetricFeedbackHeaders
    {
        private readonly Response _response;
        public ServiceCreateMetricFeedbackHeaders(Response response)
        {
            _response = response;
        }
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
