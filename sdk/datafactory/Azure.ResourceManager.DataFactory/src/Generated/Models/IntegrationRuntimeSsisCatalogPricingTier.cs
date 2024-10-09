// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The pricing tier for the catalog database. The valid values could be found in https://azure.microsoft.com/en-us/pricing/details/sql-database/. </summary>
    public readonly partial struct IntegrationRuntimeSsisCatalogPricingTier : IEquatable<IntegrationRuntimeSsisCatalogPricingTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeSsisCatalogPricingTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeSsisCatalogPricingTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";
        private const string PremiumRSValue = "PremiumRS";

        /// <summary> Basic. </summary>
        public static IntegrationRuntimeSsisCatalogPricingTier Basic { get; } = new IntegrationRuntimeSsisCatalogPricingTier(BasicValue);
        /// <summary> Standard. </summary>
        public static IntegrationRuntimeSsisCatalogPricingTier Standard { get; } = new IntegrationRuntimeSsisCatalogPricingTier(StandardValue);
        /// <summary> Premium. </summary>
        public static IntegrationRuntimeSsisCatalogPricingTier Premium { get; } = new IntegrationRuntimeSsisCatalogPricingTier(PremiumValue);
        /// <summary> PremiumRS. </summary>
        public static IntegrationRuntimeSsisCatalogPricingTier PremiumRS { get; } = new IntegrationRuntimeSsisCatalogPricingTier(PremiumRSValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeSsisCatalogPricingTier"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeSsisCatalogPricingTier left, IntegrationRuntimeSsisCatalogPricingTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeSsisCatalogPricingTier"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeSsisCatalogPricingTier left, IntegrationRuntimeSsisCatalogPricingTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IntegrationRuntimeSsisCatalogPricingTier"/>. </summary>
        public static implicit operator IntegrationRuntimeSsisCatalogPricingTier(string value) => new IntegrationRuntimeSsisCatalogPricingTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeSsisCatalogPricingTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeSsisCatalogPricingTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
