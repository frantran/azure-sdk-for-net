// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Specifies an action for a newly unmanaged resource. Delete will attempt to delete the resource from Azure. Detach will leave the resource in it's current state. </summary>
    public readonly partial struct DeploymentStacksDeleteDetachEnum : IEquatable<DeploymentStacksDeleteDetachEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentStacksDeleteDetachEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentStacksDeleteDetachEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "delete";
        private const string DetachValue = "detach";

        /// <summary> delete. </summary>
        public static DeploymentStacksDeleteDetachEnum Delete { get; } = new DeploymentStacksDeleteDetachEnum(DeleteValue);
        /// <summary> detach. </summary>
        public static DeploymentStacksDeleteDetachEnum Detach { get; } = new DeploymentStacksDeleteDetachEnum(DetachValue);
        /// <summary> Determines if two <see cref="DeploymentStacksDeleteDetachEnum"/> values are the same. </summary>
        public static bool operator ==(DeploymentStacksDeleteDetachEnum left, DeploymentStacksDeleteDetachEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentStacksDeleteDetachEnum"/> values are not the same. </summary>
        public static bool operator !=(DeploymentStacksDeleteDetachEnum left, DeploymentStacksDeleteDetachEnum right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeploymentStacksDeleteDetachEnum"/>. </summary>
        public static implicit operator DeploymentStacksDeleteDetachEnum(string value) => new DeploymentStacksDeleteDetachEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentStacksDeleteDetachEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentStacksDeleteDetachEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
