// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Gets or sets the frequency of the schedule. </summary>
    public readonly partial struct AutomationScheduleFrequency : IEquatable<AutomationScheduleFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationScheduleFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationScheduleFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneTimeValue = "OneTime";
        private const string DayValue = "Day";
        private const string HourValue = "Hour";
        private const string WeekValue = "Week";
        private const string MonthValue = "Month";
        private const string MinuteValue = "Minute";

        /// <summary> OneTime. </summary>
        public static AutomationScheduleFrequency OneTime { get; } = new AutomationScheduleFrequency(OneTimeValue);
        /// <summary> Day. </summary>
        public static AutomationScheduleFrequency Day { get; } = new AutomationScheduleFrequency(DayValue);
        /// <summary> Hour. </summary>
        public static AutomationScheduleFrequency Hour { get; } = new AutomationScheduleFrequency(HourValue);
        /// <summary> Week. </summary>
        public static AutomationScheduleFrequency Week { get; } = new AutomationScheduleFrequency(WeekValue);
        /// <summary> Month. </summary>
        public static AutomationScheduleFrequency Month { get; } = new AutomationScheduleFrequency(MonthValue);
        /// <summary> The minimum allowed interval for Minute schedules is 15 minutes. </summary>
        public static AutomationScheduleFrequency Minute { get; } = new AutomationScheduleFrequency(MinuteValue);
        /// <summary> Determines if two <see cref="AutomationScheduleFrequency"/> values are the same. </summary>
        public static bool operator ==(AutomationScheduleFrequency left, AutomationScheduleFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationScheduleFrequency"/> values are not the same. </summary>
        public static bool operator !=(AutomationScheduleFrequency left, AutomationScheduleFrequency right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutomationScheduleFrequency"/>. </summary>
        public static implicit operator AutomationScheduleFrequency(string value) => new AutomationScheduleFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationScheduleFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationScheduleFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
