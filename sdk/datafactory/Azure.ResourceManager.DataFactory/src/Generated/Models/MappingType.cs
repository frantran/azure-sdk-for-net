// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Type of the CDC attribute mapping. Note: 'Advanced' mapping type is also saved as 'Derived'. </summary>
    public readonly partial struct MappingType : IEquatable<MappingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MappingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MappingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DirectValue = "Direct";
        private const string DerivedValue = "Derived";
        private const string AggregateValue = "Aggregate";

        /// <summary> Direct. </summary>
        public static MappingType Direct { get; } = new MappingType(DirectValue);
        /// <summary> Derived. </summary>
        public static MappingType Derived { get; } = new MappingType(DerivedValue);
        /// <summary> Aggregate. </summary>
        public static MappingType Aggregate { get; } = new MappingType(AggregateValue);
        /// <summary> Determines if two <see cref="MappingType"/> values are the same. </summary>
        public static bool operator ==(MappingType left, MappingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MappingType"/> values are not the same. </summary>
        public static bool operator !=(MappingType left, MappingType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MappingType"/>. </summary>
        public static implicit operator MappingType(string value) => new MappingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MappingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MappingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
