// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Access level allowed for this remote application type. </summary>
    public readonly partial struct EdgeRemoteApplicationAccessLevel : IEquatable<EdgeRemoteApplicationAccessLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeRemoteApplicationAccessLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeRemoteApplicationAccessLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ReadOnlyValue = "ReadOnly";
        private const string ReadWriteValue = "ReadWrite";
        private const string FullAccessValue = "FullAccess";

        /// <summary> None. </summary>
        public static EdgeRemoteApplicationAccessLevel None { get; } = new EdgeRemoteApplicationAccessLevel(NoneValue);
        /// <summary> ReadOnly. </summary>
        public static EdgeRemoteApplicationAccessLevel ReadOnly { get; } = new EdgeRemoteApplicationAccessLevel(ReadOnlyValue);
        /// <summary> ReadWrite. </summary>
        public static EdgeRemoteApplicationAccessLevel ReadWrite { get; } = new EdgeRemoteApplicationAccessLevel(ReadWriteValue);
        /// <summary> FullAccess. </summary>
        public static EdgeRemoteApplicationAccessLevel FullAccess { get; } = new EdgeRemoteApplicationAccessLevel(FullAccessValue);
        /// <summary> Determines if two <see cref="EdgeRemoteApplicationAccessLevel"/> values are the same. </summary>
        public static bool operator ==(EdgeRemoteApplicationAccessLevel left, EdgeRemoteApplicationAccessLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeRemoteApplicationAccessLevel"/> values are not the same. </summary>
        public static bool operator !=(EdgeRemoteApplicationAccessLevel left, EdgeRemoteApplicationAccessLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EdgeRemoteApplicationAccessLevel"/>. </summary>
        public static implicit operator EdgeRemoteApplicationAccessLevel(string value) => new EdgeRemoteApplicationAccessLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeRemoteApplicationAccessLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeRemoteApplicationAccessLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
