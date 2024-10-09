// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> A Radiology Insights inference types. </summary>
    public readonly partial struct RadiologyInsightsInferenceType : IEquatable<RadiologyInsightsInferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RadiologyInsightsInferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AgeMismatchValue = "ageMismatch";
        private const string LateralityDiscrepancyValue = "lateralityDiscrepancy";
        private const string SexMismatchValue = "sexMismatch";
        private const string CompleteOrderDiscrepancyValue = "completeOrderDiscrepancy";
        private const string LimitedOrderDiscrepancyValue = "limitedOrderDiscrepancy";
        private const string FindingValue = "finding";
        private const string CriticalResultValue = "criticalResult";
        private const string FollowupRecommendationValue = "followupRecommendation";
        private const string FollowupCommunicationValue = "followupCommunication";
        private const string RadiologyProcedureValue = "radiologyProcedure";

        /// <summary> Age mismatch inference type. </summary>
        public static RadiologyInsightsInferenceType AgeMismatch { get; } = new RadiologyInsightsInferenceType(AgeMismatchValue);
        /// <summary> Laterality discrepancy inference type. </summary>
        public static RadiologyInsightsInferenceType LateralityDiscrepancy { get; } = new RadiologyInsightsInferenceType(LateralityDiscrepancyValue);
        /// <summary> Sex mismatch inference type. </summary>
        public static RadiologyInsightsInferenceType SexMismatch { get; } = new RadiologyInsightsInferenceType(SexMismatchValue);
        /// <summary> Complete order discrepancy inference type. </summary>
        public static RadiologyInsightsInferenceType CompleteOrderDiscrepancy { get; } = new RadiologyInsightsInferenceType(CompleteOrderDiscrepancyValue);
        /// <summary> Limited order discrepancy inference type. </summary>
        public static RadiologyInsightsInferenceType LimitedOrderDiscrepancy { get; } = new RadiologyInsightsInferenceType(LimitedOrderDiscrepancyValue);
        /// <summary> Finding inference type. </summary>
        public static RadiologyInsightsInferenceType Finding { get; } = new RadiologyInsightsInferenceType(FindingValue);
        /// <summary> Critical finding inference type. </summary>
        public static RadiologyInsightsInferenceType CriticalResult { get; } = new RadiologyInsightsInferenceType(CriticalResultValue);
        /// <summary> Recommendation inference type. </summary>
        public static RadiologyInsightsInferenceType FollowupRecommendation { get; } = new RadiologyInsightsInferenceType(FollowupRecommendationValue);
        /// <summary> Followup Communication inference type. </summary>
        public static RadiologyInsightsInferenceType FollowupCommunication { get; } = new RadiologyInsightsInferenceType(FollowupCommunicationValue);
        /// <summary> Radiology Procedure inference type. </summary>
        public static RadiologyInsightsInferenceType RadiologyProcedure { get; } = new RadiologyInsightsInferenceType(RadiologyProcedureValue);
        /// <summary> Determines if two <see cref="RadiologyInsightsInferenceType"/> values are the same. </summary>
        public static bool operator ==(RadiologyInsightsInferenceType left, RadiologyInsightsInferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RadiologyInsightsInferenceType"/> values are not the same. </summary>
        public static bool operator !=(RadiologyInsightsInferenceType left, RadiologyInsightsInferenceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RadiologyInsightsInferenceType"/>. </summary>
        public static implicit operator RadiologyInsightsInferenceType(string value) => new RadiologyInsightsInferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RadiologyInsightsInferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RadiologyInsightsInferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
