// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace constants.Models
{
    /// <summary> The ModelAsStringRequiredOneValueNoDefaultEnum. </summary>
    public readonly partial struct ModelAsStringRequiredOneValueNoDefaultEnum : IEquatable<ModelAsStringRequiredOneValueNoDefaultEnum>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ModelAsStringRequiredOneValueNoDefaultEnum"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelAsStringRequiredOneValueNoDefaultEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Value1Value = "value1";

        /// <summary> value1. </summary>
        public static ModelAsStringRequiredOneValueNoDefaultEnum Value1 { get; } = new ModelAsStringRequiredOneValueNoDefaultEnum(Value1Value);
        /// <summary> Determines if two <see cref="ModelAsStringRequiredOneValueNoDefaultEnum"/> values are the same. </summary>
        public static bool operator ==(ModelAsStringRequiredOneValueNoDefaultEnum left, ModelAsStringRequiredOneValueNoDefaultEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelAsStringRequiredOneValueNoDefaultEnum"/> values are not the same. </summary>
        public static bool operator !=(ModelAsStringRequiredOneValueNoDefaultEnum left, ModelAsStringRequiredOneValueNoDefaultEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelAsStringRequiredOneValueNoDefaultEnum"/>. </summary>
        public static implicit operator ModelAsStringRequiredOneValueNoDefaultEnum(string value) => new ModelAsStringRequiredOneValueNoDefaultEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelAsStringRequiredOneValueNoDefaultEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelAsStringRequiredOneValueNoDefaultEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
