// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests. </summary>
    internal readonly partial struct EventSerializationType : IEquatable<EventSerializationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventSerializationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventSerializationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CsvValue = "Csv";
        private const string AvroValue = "Avro";
        private const string JsonValue = "Json";
        private const string CustomClrValue = "CustomClr";
        private const string ParquetValue = "Parquet";

        /// <summary> Csv. </summary>
        public static EventSerializationType Csv { get; } = new EventSerializationType(CsvValue);
        /// <summary> Avro. </summary>
        public static EventSerializationType Avro { get; } = new EventSerializationType(AvroValue);
        /// <summary> Json. </summary>
        public static EventSerializationType Json { get; } = new EventSerializationType(JsonValue);
        /// <summary> CustomClr. </summary>
        public static EventSerializationType CustomClr { get; } = new EventSerializationType(CustomClrValue);
        /// <summary> Parquet. </summary>
        public static EventSerializationType Parquet { get; } = new EventSerializationType(ParquetValue);
        /// <summary> Determines if two <see cref="EventSerializationType"/> values are the same. </summary>
        public static bool operator ==(EventSerializationType left, EventSerializationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventSerializationType"/> values are not the same. </summary>
        public static bool operator !=(EventSerializationType left, EventSerializationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventSerializationType"/>. </summary>
        public static implicit operator EventSerializationType(string value) => new EventSerializationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventSerializationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventSerializationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
