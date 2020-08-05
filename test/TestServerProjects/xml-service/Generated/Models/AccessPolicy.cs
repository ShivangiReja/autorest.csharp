// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace xml_service.Models
{
    /// <summary> An Access policy. </summary>
    public partial class AccessPolicy
    {
        /// <summary> Initializes a new instance of AccessPolicy. </summary>
        /// <param name="start"> the date-time the policy is active. </param>
        /// <param name="expiry"> the date-time the policy expires. </param>
        /// <param name="permission"> the permissions for the acl policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="permission"/> is null. </exception>
        public AccessPolicy(DateTimeOffset start, DateTimeOffset expiry, string permission)
        {
            if (permission == null)
            {
                throw new ArgumentNullException(nameof(permission));
            }

            Start = start;
            Expiry = expiry;
            Permission = permission;
        }

        /// <summary> the date-time the policy is active. </summary>
        public DateTimeOffset Start { get; set; }
        /// <summary> the date-time the policy expires. </summary>
        public DateTimeOffset Expiry { get; set; }
        /// <summary> the permissions for the acl policy. </summary>
        public string Permission { get; set; }
    }
}
