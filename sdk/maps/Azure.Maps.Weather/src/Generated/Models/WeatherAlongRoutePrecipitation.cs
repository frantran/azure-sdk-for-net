// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> Precipitation forecast of the weather along the route. </summary>
    public partial class WeatherAlongRoutePrecipitation
    {
        /// <summary> Initializes a new instance of <see cref="WeatherAlongRoutePrecipitation"/>. </summary>
        internal WeatherAlongRoutePrecipitation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WeatherAlongRoutePrecipitation"/>. </summary>
        /// <param name="dbz"> The forecasted precipitation intensity in dBZ (decibels relative to Z) from 0.0 to 100.0. </param>
        /// <param name="type"> Precipitation type. If precipitation should occur, the type that it will be: "RAIN," "HAIL," "SNOW," "ICE," or "MIX.". </param>
        internal WeatherAlongRoutePrecipitation(double? dbz, string type)
        {
            Dbz = dbz;
            Type = type;
        }

        /// <summary> The forecasted precipitation intensity in dBZ (decibels relative to Z) from 0.0 to 100.0. </summary>
        public double? Dbz { get; }
        /// <summary> Precipitation type. If precipitation should occur, the type that it will be: "RAIN," "HAIL," "SNOW," "ICE," or "MIX.". </summary>
        public string Type { get; }
    }
}
