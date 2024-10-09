// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Load balancing algorithm for ramp up period. </summary>
    public readonly partial struct SessionHostLoadBalancingAlgorithm : IEquatable<SessionHostLoadBalancingAlgorithm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SessionHostLoadBalancingAlgorithm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SessionHostLoadBalancingAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BreadthFirstValue = "BreadthFirst";
        private const string DepthFirstValue = "DepthFirst";

        /// <summary> BreadthFirst. </summary>
        public static SessionHostLoadBalancingAlgorithm BreadthFirst { get; } = new SessionHostLoadBalancingAlgorithm(BreadthFirstValue);
        /// <summary> DepthFirst. </summary>
        public static SessionHostLoadBalancingAlgorithm DepthFirst { get; } = new SessionHostLoadBalancingAlgorithm(DepthFirstValue);
        /// <summary> Determines if two <see cref="SessionHostLoadBalancingAlgorithm"/> values are the same. </summary>
        public static bool operator ==(SessionHostLoadBalancingAlgorithm left, SessionHostLoadBalancingAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SessionHostLoadBalancingAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(SessionHostLoadBalancingAlgorithm left, SessionHostLoadBalancingAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SessionHostLoadBalancingAlgorithm"/>. </summary>
        public static implicit operator SessionHostLoadBalancingAlgorithm(string value) => new SessionHostLoadBalancingAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SessionHostLoadBalancingAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SessionHostLoadBalancingAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
