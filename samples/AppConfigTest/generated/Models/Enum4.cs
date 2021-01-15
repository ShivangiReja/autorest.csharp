// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AppConfiguration.Models
{
    /// <summary> The Enum4. </summary>
    public readonly partial struct Enum4 : IEquatable<Enum4>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Enum4"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum4(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyValue = "key";
        private const string LabelValue = "label";
        private const string ContentTypeValue = "content_type";
        private const string ValueValue = "value";
        private const string LastModifiedValue = "last_modified";
        private const string TagsValue = "tags";
        private const string LockedValue = "locked";
        private const string EtagValue = "etag";

        /// <summary> key. </summary>
        public static Enum4 Key { get; } = new Enum4(KeyValue);
        /// <summary> label. </summary>
        public static Enum4 Label { get; } = new Enum4(LabelValue);
        /// <summary> content_type. </summary>
        public static Enum4 ContentType { get; } = new Enum4(ContentTypeValue);
        /// <summary> value. </summary>
        public static Enum4 Value { get; } = new Enum4(ValueValue);
        /// <summary> last_modified. </summary>
        public static Enum4 LastModified { get; } = new Enum4(LastModifiedValue);
        /// <summary> tags. </summary>
        public static Enum4 Tags { get; } = new Enum4(TagsValue);
        /// <summary> locked. </summary>
        public static Enum4 Locked { get; } = new Enum4(LockedValue);
        /// <summary> etag. </summary>
        public static Enum4 Etag { get; } = new Enum4(EtagValue);
        /// <summary> Determines if two <see cref="Enum4"/> values are the same. </summary>
        public static bool operator ==(Enum4 left, Enum4 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum4"/> values are not the same. </summary>
        public static bool operator !=(Enum4 left, Enum4 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum4"/>. </summary>
        public static implicit operator Enum4(string value) => new Enum4(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum4 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum4 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}