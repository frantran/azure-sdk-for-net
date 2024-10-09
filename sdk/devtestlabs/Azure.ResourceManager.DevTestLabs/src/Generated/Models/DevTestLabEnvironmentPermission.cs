// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The access rights to be granted to the user when provisioning an environment. </summary>
    public readonly partial struct DevTestLabEnvironmentPermission : IEquatable<DevTestLabEnvironmentPermission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabEnvironmentPermission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabEnvironmentPermission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReaderValue = "Reader";
        private const string ContributorValue = "Contributor";

        /// <summary> Reader. </summary>
        public static DevTestLabEnvironmentPermission Reader { get; } = new DevTestLabEnvironmentPermission(ReaderValue);
        /// <summary> Contributor. </summary>
        public static DevTestLabEnvironmentPermission Contributor { get; } = new DevTestLabEnvironmentPermission(ContributorValue);
        /// <summary> Determines if two <see cref="DevTestLabEnvironmentPermission"/> values are the same. </summary>
        public static bool operator ==(DevTestLabEnvironmentPermission left, DevTestLabEnvironmentPermission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabEnvironmentPermission"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabEnvironmentPermission left, DevTestLabEnvironmentPermission right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevTestLabEnvironmentPermission"/>. </summary>
        public static implicit operator DevTestLabEnvironmentPermission(string value) => new DevTestLabEnvironmentPermission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabEnvironmentPermission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabEnvironmentPermission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
