// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The private link service connection status. </summary>
    public readonly partial struct AppConfigurationPrivateLinkServiceConnectionStatus : IEquatable<AppConfigurationPrivateLinkServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPrivateLinkServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppConfigurationPrivateLinkServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static AppConfigurationPrivateLinkServiceConnectionStatus Pending { get; } = new AppConfigurationPrivateLinkServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static AppConfigurationPrivateLinkServiceConnectionStatus Approved { get; } = new AppConfigurationPrivateLinkServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static AppConfigurationPrivateLinkServiceConnectionStatus Rejected { get; } = new AppConfigurationPrivateLinkServiceConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static AppConfigurationPrivateLinkServiceConnectionStatus Disconnected { get; } = new AppConfigurationPrivateLinkServiceConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="AppConfigurationPrivateLinkServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(AppConfigurationPrivateLinkServiceConnectionStatus left, AppConfigurationPrivateLinkServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppConfigurationPrivateLinkServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(AppConfigurationPrivateLinkServiceConnectionStatus left, AppConfigurationPrivateLinkServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppConfigurationPrivateLinkServiceConnectionStatus"/>. </summary>
        public static implicit operator AppConfigurationPrivateLinkServiceConnectionStatus(string value) => new AppConfigurationPrivateLinkServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppConfigurationPrivateLinkServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppConfigurationPrivateLinkServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
