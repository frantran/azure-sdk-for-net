// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The name of the authentication key to regenerate. </summary>
    public readonly partial struct IntegrationRuntimeAuthKeyName : IEquatable<IntegrationRuntimeAuthKeyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeAuthKeyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeAuthKeyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuthKey1Value = "authKey1";
        private const string AuthKey2Value = "authKey2";

        /// <summary> authKey1. </summary>
        public static IntegrationRuntimeAuthKeyName AuthKey1 { get; } = new IntegrationRuntimeAuthKeyName(AuthKey1Value);
        /// <summary> authKey2. </summary>
        public static IntegrationRuntimeAuthKeyName AuthKey2 { get; } = new IntegrationRuntimeAuthKeyName(AuthKey2Value);
        /// <summary> Determines if two <see cref="IntegrationRuntimeAuthKeyName"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeAuthKeyName left, IntegrationRuntimeAuthKeyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeAuthKeyName"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeAuthKeyName left, IntegrationRuntimeAuthKeyName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IntegrationRuntimeAuthKeyName"/>. </summary>
        public static implicit operator IntegrationRuntimeAuthKeyName(string value) => new IntegrationRuntimeAuthKeyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeAuthKeyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeAuthKeyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
