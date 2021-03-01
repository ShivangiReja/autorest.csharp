// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json.Serialization;

namespace ModelWithConverterUsage.Models
{
    /// <summary> The product documentation. </summary>
    [JsonConverter(typeof(ProductConverter))]
    public partial class Product
    {
        /// <summary> Initializes a new instance of Product. </summary>
        /// <param name="constProperty"> Constant string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="constProperty"/> is null. </exception>
        public Product(string constProperty)
        {
            if (constProperty == null)
            {
                throw new ArgumentNullException(nameof(constProperty));
            }

            ConstProperty = constProperty;
        }

        /// <summary> Constant string. </summary>
        public string ConstProperty { get; set; }
    }
}
