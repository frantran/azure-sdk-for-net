// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Quota request status. </summary>
    public readonly partial struct QuotaRequestState : IEquatable<QuotaRequestState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QuotaRequestState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QuotaRequestState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string InvalidValue = "Invalid";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string InProgressValue = "InProgress";

        /// <summary> Accepted. </summary>
        public static QuotaRequestState Accepted { get; } = new QuotaRequestState(AcceptedValue);
        /// <summary> Invalid. </summary>
        public static QuotaRequestState Invalid { get; } = new QuotaRequestState(InvalidValue);
        /// <summary> Succeeded. </summary>
        public static QuotaRequestState Succeeded { get; } = new QuotaRequestState(SucceededValue);
        /// <summary> Failed. </summary>
        public static QuotaRequestState Failed { get; } = new QuotaRequestState(FailedValue);
        /// <summary> InProgress. </summary>
        public static QuotaRequestState InProgress { get; } = new QuotaRequestState(InProgressValue);
        /// <summary> Determines if two <see cref="QuotaRequestState"/> values are the same. </summary>
        public static bool operator ==(QuotaRequestState left, QuotaRequestState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QuotaRequestState"/> values are not the same. </summary>
        public static bool operator !=(QuotaRequestState left, QuotaRequestState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="QuotaRequestState"/>. </summary>
        public static implicit operator QuotaRequestState(string value) => new QuotaRequestState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QuotaRequestState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QuotaRequestState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
