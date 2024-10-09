// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The connection state of the device. </summary>
    public readonly partial struct ModuleConnectionState : IEquatable<ModuleConnectionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModuleConnectionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModuleConnectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisconnectedValue = "Disconnected";
        private const string ConnectedValue = "Connected";

        /// <summary> Disconnected. </summary>
        public static ModuleConnectionState Disconnected { get; } = new ModuleConnectionState(DisconnectedValue);
        /// <summary> Connected. </summary>
        public static ModuleConnectionState Connected { get; } = new ModuleConnectionState(ConnectedValue);
        /// <summary> Determines if two <see cref="ModuleConnectionState"/> values are the same. </summary>
        public static bool operator ==(ModuleConnectionState left, ModuleConnectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModuleConnectionState"/> values are not the same. </summary>
        public static bool operator !=(ModuleConnectionState left, ModuleConnectionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ModuleConnectionState"/>. </summary>
        public static implicit operator ModuleConnectionState(string value) => new ModuleConnectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModuleConnectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModuleConnectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
