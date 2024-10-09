// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Trigger reference type. </summary>
    public readonly partial struct TriggerReferenceType : IEquatable<TriggerReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TriggerReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TriggerReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TriggerReferenceValue = "TriggerReference";

        /// <summary> TriggerReference. </summary>
        public static TriggerReferenceType TriggerReference { get; } = new TriggerReferenceType(TriggerReferenceValue);
        /// <summary> Determines if two <see cref="TriggerReferenceType"/> values are the same. </summary>
        public static bool operator ==(TriggerReferenceType left, TriggerReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TriggerReferenceType"/> values are not the same. </summary>
        public static bool operator !=(TriggerReferenceType left, TriggerReferenceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TriggerReferenceType"/>. </summary>
        public static implicit operator TriggerReferenceType(string value) => new TriggerReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TriggerReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TriggerReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
