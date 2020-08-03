// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace AnomalyDetector.Models
{
    /// <summary> The ViewMode. </summary>
    public readonly partial struct ViewMode : IEquatable<ViewMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ViewMode"/> values are the same. </summary>
        public ViewMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrivateValue = "Private";
        private const string PublicValue = "Public";

        /// <summary> Private. </summary>
        public static ViewMode Private { get; } = new ViewMode(PrivateValue);
        /// <summary> Public. </summary>
        public static ViewMode Public { get; } = new ViewMode(PublicValue);
        /// <summary> Determines if two <see cref="ViewMode"/> values are the same. </summary>
        public static bool operator ==(ViewMode left, ViewMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ViewMode"/> values are not the same. </summary>
        public static bool operator !=(ViewMode left, ViewMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ViewMode"/>. </summary>
        public static implicit operator ViewMode(string value) => new ViewMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ViewMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ViewMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
