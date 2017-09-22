// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsLro.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for delete202NonRetry400 operation.
    /// </summary>
    public partial class LROSADsDelete202NonRetry400HeadersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LROSADsDelete202NonRetry400HeadersInner class.
        /// </summary>
        public LROSADsDelete202NonRetry400HeadersInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LROSADsDelete202NonRetry400HeadersInner class.
        /// </summary>
        /// <param name="location">Location to poll for result status: will be
        /// set to /lro/retryerror/delete/202/retry/200</param>
        /// <param name="retryAfter">Number of milliseconds until the next poll
        /// should be sent, will be set to zero</param>
        public LROSADsDelete202NonRetry400HeadersInner(string location = default(string), int? retryAfter = default(int?))
        {
            Location = location;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to
        /// /lro/retryerror/delete/202/retry/200
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets number of milliseconds until the next poll should be
        /// sent, will be set to zero
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}